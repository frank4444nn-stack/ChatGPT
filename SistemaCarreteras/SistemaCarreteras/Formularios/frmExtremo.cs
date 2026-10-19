using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmExtremo : Form
    {
        public frmExtremo()
        {
            InitializeComponent();
            CargarDatos();
            label1.Text = "EXTREMO DE CARRETERA";
            label4.Text = "Kilómetro:";
            label10.Text = "Observación:";
            label8.Text = "Comuna destino:";
            cboCarretera.SelectedIndexChanged += cboCarretera_SelectedIndexChanged;
            cboCarreteraDestino.SelectedIndexChanged += cboCarreteraDestino_SelectedIndexChanged;
            cboTipoFinalizacion.SelectedIndexChanged += cboTipoFinalizacion_SelectedIndexChanged;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
            HabilitarDestino();
        }
        private bool modificando;
        public void CargarDatos()
        {
            foreach (ComboBox cbo in new ComboBox[] { cboCarretera, cboTramo, cboComuna, cboTipoExtremo,
                cboTipoFinalizacion, cboCarreteraDestino, cboTramoDestino, cboComunaDestino })
            {
                cbo.Items.Clear();
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            foreach (Carretera op in TListaCarretera.GetLista()) cboCarretera.Items.Add(op);
            foreach (Comuna op in TListaComuna.GetLista())
            {
                cboComuna.Items.Add(op);
                cboComunaDestino.Items.Add(op);
            }
            cboTipoExtremo.Items.AddRange(new object[] { "Inicio", "Final" });
            cboTipoFinalizacion.Items.AddRange(new object[] { "Finalización física", "Confluencia con otra carretera" });
        }
        public void CargarTramos()
        {
            cboTramo.Items.Clear();
            cboCarreteraDestino.Items.Clear();
            Carretera carretera = cboCarretera.SelectedItem as Carretera;
            if (carretera != null)
            {
                foreach (Tramo op in TListaTramo.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo).OrderBy(x => x.Numero))
                    cboTramo.Items.Add(op);
                foreach (Carretera op in TListaCarretera.GetLista().Where(x => x.Codigo != carretera.Codigo))
                    cboCarreteraDestino.Items.Add(op);
            }
            CargarTramosDestino();
        }
        public void CargarTramosDestino()
        {
            cboTramoDestino.Items.Clear();
            Carretera carretera = cboCarreteraDestino.SelectedItem as Carretera;
            if (carretera != null)
                foreach (Tramo op in TListaTramo.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo).OrderBy(x => x.Numero))
                    cboTramoDestino.Items.Add(op);
        }
        public void HabilitarDestino()
        {
            bool confluencia = cboTipoFinalizacion.Text == "Confluencia con otra carretera";
            cboCarreteraDestino.Enabled = cboTramoDestino.Enabled = cboComunaDestino.Enabled =
                txtKmDestino.Enabled = txtObservacion.Enabled = confluencia;
            if (!confluencia)
            {
                cboCarreteraDestino.SelectedIndex = -1;
                cboTramoDestino.Items.Clear();
                cboComunaDestino.SelectedIndex = -1;
                txtKmDestino.Clear();
                txtObservacion.Clear();
            }
        }
        public ExtremoCarretera CrearObjeto()
        {
            bool confluencia = cboTipoFinalizacion.Text == "Confluencia con otra carretera";
            return new ExtremoCarretera((Carretera)cboCarretera.SelectedItem, cboTipoExtremo.Text,
                (Tramo)cboTramo.SelectedItem, (Comuna)cboComuna.SelectedItem, double.Parse(txtKilometro.Text),
                cboTipoFinalizacion.Text, confluencia ? (Carretera)cboCarreteraDestino.SelectedItem : null,
                confluencia ? (Tramo)cboTramoDestino.SelectedItem : null,
                confluencia ? (Comuna)cboComunaDestino.SelectedItem : null,
                confluencia ? double.Parse(txtKmDestino.Text) : 0, confluencia ? txtObservacion.Text.Trim() : "");
        }
        public bool ValidarDatos()
        {
            double km;
            if (cboCarretera.SelectedItem == null || cboTramo.SelectedItem == null || cboComuna.SelectedItem == null ||
                cboTipoExtremo.SelectedItem == null || cboTipoFinalizacion.SelectedItem == null ||
                !double.TryParse(txtKilometro.Text, out km))
            {
                MessageBox.Show("Complete los datos del extremo e ingrese un kilómetro válido.");
                return false;
            }
            if (cboTipoFinalizacion.Text == "Confluencia con otra carretera" &&
                (cboCarreteraDestino.SelectedItem == null || cboTramoDestino.SelectedItem == null ||
                 cboComunaDestino.SelectedItem == null || !double.TryParse(txtKmDestino.Text, out km) ||
                 string.IsNullOrWhiteSpace(txtObservacion.Text)))
            {
                MessageBox.Show("Complete carretera, tramo, comuna, kilómetro de destino y observación.");
                return false;
            }
            ExtremoCarretera op = CrearObjeto();
            if (!TListaExtremoCarretera.Validar(op))
            {
                MessageBox.Show("Revise los rangos, la comuna recorrida y el inicio/final de la carretera. La confluencia debe ser con otra carretera y dentro de su tramo y comuna.");
                return false;
            }
            if (!modificando && TListaExtremoCarretera.Buscar(op.Carretera.Codigo, op.TipoExtremo) != null)
            {
                MessageBox.Show("Esa carretera ya tiene registrado ese tipo de extremo.");
                return false;
            }
            return true;
        }
        public void setDatos(ExtremoCarretera op)
        {
            modificando = true;
            cboCarretera.SelectedItem = op.Carretera;
            cboTipoExtremo.SelectedItem = op.TipoExtremo;
            cboCarretera.Enabled = cboTipoExtremo.Enabled = false;
            cboTramo.SelectedItem = op.Tramo;
            cboComuna.SelectedItem = op.Comuna;
            txtKilometro.Text = op.Kilometro.ToString();
            cboTipoFinalizacion.SelectedItem = op.TipoFinalizacion;
            if (op.TipoFinalizacion == "Confluencia con otra carretera")
            {
                cboCarreteraDestino.SelectedItem = op.CarreteraDestino;
                cboTramoDestino.SelectedItem = op.TramoDestino;
                cboComunaDestino.SelectedItem = op.ComunaDestino;
                txtKmDestino.Text = op.KmDestino.ToString();
                txtObservacion.Text = op.Observacion;
            }
        }
        public void Guardar() { if (ValidarDatos()) DialogResult = DialogResult.OK; }
        private void cboCarretera_SelectedIndexChanged(object sender, EventArgs e) { CargarTramos(); }
        private void cboCarreteraDestino_SelectedIndexChanged(object sender, EventArgs e) { CargarTramosDestino(); }
        private void cboTipoFinalizacion_SelectedIndexChanged(object sender, EventArgs e) { HabilitarDestino(); }
        private void btnGuardar_Click(object sender, EventArgs e) { Guardar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; }
    }
}
