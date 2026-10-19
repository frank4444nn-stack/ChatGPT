using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmTramo : Form
    {
        public frmTramo()
        {
            InitializeComponent();
            CargarDatos();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            txtKmInicial.TextChanged += Kilometros_TextChanged;
            txtKmFinal.TextChanged += Kilometros_TextChanged;
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }
        private bool modificando;
        public void CargarDatos()
        {
            cboCarretera.Items.Clear();
            cboCarretera.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Carretera op in TListaCarretera.GetLista()) cboCarretera.Items.Add(op);
            txtLongitud.ReadOnly = true;
        }
        public Tramo CrearObjeto()
        {
            return new Tramo((Carretera)cboCarretera.SelectedItem,
                int.Parse(txtNumero.Text), double.Parse(txtKmInicial.Text), double.Parse(txtKmFinal.Text));
        }
        public bool ValidarDatos()
        {
            int numero;
            double inicio, final;
            if (cboCarretera.SelectedItem == null || !int.TryParse(txtNumero.Text, out numero) || numero <= 0 ||
                !double.TryParse(txtKmInicial.Text, out inicio) || !double.TryParse(txtKmFinal.Text, out final))
            {
                MessageBox.Show("Seleccione la carretera e ingrese número y kilómetros válidos.");
                return false;
            }
            Tramo op = CrearObjeto();
            if (!TListaTramo.Validar(op))
            {
                MessageBox.Show("El kilómetro inicial debe ser no negativo y el final debe ser mayor. Use números finitos.");
                return false;
            }
            if (!modificando && TListaTramo.Buscar(op.Carretera.Codigo, numero) != null)
            {
                MessageBox.Show("El número de tramo ya existe en esa carretera.");
                return false;
            }
            return true;
        }
        public void setDatos(Tramo op)
        {
            modificando = true;
            cboCarretera.SelectedItem = op.Carretera;
            cboCarretera.Enabled = false; // Un tramo no puede transferirse a otra carretera.
            txtNumero.Text = op.Numero.ToString();
            txtNumero.ReadOnly = true;
            txtKmInicial.Text = op.KmInicial.ToString();
            txtKmFinal.Text = op.KmFinal.ToString();
            CalcularLongitud();
        }
        public void CalcularLongitud()
        {
            double inicio, final;
            txtLongitud.Clear();
            if (double.TryParse(txtKmInicial.Text, out inicio) && double.TryParse(txtKmFinal.Text, out final) &&
                !double.IsNaN(final - inicio) && !double.IsInfinity(final - inicio) && final > inicio && inicio >= 0)
                txtLongitud.Text = (final - inicio).ToString("0.##");
        }
        public void Guardar() { if (ValidarDatos()) DialogResult = DialogResult.OK; }
        private void btnGuardar_Click(object sender, EventArgs e) { Guardar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; }
        private void Kilometros_TextChanged(object sender, EventArgs e) { CalcularLongitud(); }
    }
}
