using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmComunaRecorrida : Form
    {
        public frmComunaRecorrida()
        {
            InitializeComponent();
            CargarDatos();
            label1.Text = "COMUNAS RECORRIDAS";
            label4.Text = "Kilómetro entrada:";
            label5.Text = "Kilómetro salida:";
            cboCarretera.SelectedIndexChanged += cboCarretera_SelectedIndexChanged;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }
        private ComunaRecorrida original;
        public void CargarDatos()
        {
            cboCarretera.Items.Clear();
            cboTramo.Items.Clear();
            cboComuna.Items.Clear();
            cboCarretera.DropDownStyle = cboTramo.DropDownStyle = cboComuna.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Carretera op in TListaCarretera.GetLista()) cboCarretera.Items.Add(op);
            foreach (Comuna op in TListaComuna.GetLista()) cboComuna.Items.Add(op);
        }
        public void CargarTramos()
        {
            cboTramo.Items.Clear();
            Carretera carretera = cboCarretera.SelectedItem as Carretera;
            if (carretera != null)
                foreach (Tramo op in TListaTramo.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo).OrderBy(x => x.Numero))
                    cboTramo.Items.Add(op);
        }
        public ComunaRecorrida CrearObjeto()
        {
            return new ComunaRecorrida((Tramo)cboTramo.SelectedItem, (Comuna)cboComuna.SelectedItem,
                int.Parse(txtOrden.Text), double.Parse(txtKmEntrada.Text), double.Parse(txtKmSalida.Text));
        }
        public bool ValidarDatos()
        {
            int orden;
            double entrada, salida;
            if (cboTramo.SelectedItem == null || cboComuna.SelectedItem == null ||
                !int.TryParse(txtOrden.Text, out orden) || orden <= 0 ||
                !double.TryParse(txtKmEntrada.Text, out entrada) || !double.TryParse(txtKmSalida.Text, out salida))
            {
                MessageBox.Show("Seleccione carretera, tramo y comuna; ingrese orden positivo y kilómetros válidos.");
                return false;
            }
            ComunaRecorrida op = CrearObjeto();
            if (!TListaComunaRecorrida.Validar(op))
            {
                MessageBox.Show("Entrada y salida deben estar dentro del tramo, con entrada menor o igual a salida.");
                return false;
            }
            ComunaRecorrida existe = TListaComunaRecorrida.Buscar(op.Tramo.Carretera.Codigo, op.Tramo.Numero, op.Orden);
            if (existe != null && existe != original)
            {
                MessageBox.Show("El orden ya está ocupado en ese tramo.");
                return false;
            }
            if (original != null && !TListaComunaRecorrida.PuedeModificar(original, op))
            {
                MessageBox.Show("El cambio dejaría un extremo fuera de su comuna recorrida. Modifique primero el extremo.");
                return false;
            }
            return true;
        }
        public void setDatos(ComunaRecorrida op)
        {
            original = op;
            cboCarretera.SelectedItem = op.Tramo.Carretera;
            cboTramo.SelectedItem = op.Tramo;
            cboComuna.SelectedItem = op.Comuna;
            txtOrden.Text = op.Orden.ToString();
            txtKmEntrada.Text = op.KmEntrada.ToString();
            txtKmSalida.Text = op.KmSalida.ToString();
        }
        public void Guardar() { if (ValidarDatos()) DialogResult = DialogResult.OK; }
        private void cboCarretera_SelectedIndexChanged(object sender, EventArgs e) { CargarTramos(); }
        private void btnGuardar_Click(object sender, EventArgs e) { Guardar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; }
    }
}
