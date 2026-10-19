using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmComuna : Form
    {
        public frmComuna()
        {
            InitializeComponent();
            label1.Text = "DATOS DE LA COMUNA";
            CargarDatos();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }
        private bool modificando;
        public void CargarDatos()
        {
            
        }
        public Comuna CrearObjeto()
        {
            return new Comuna(int.Parse(txtCodigo.Text), txtNombre.Text.Trim(), txtCanton.Text.Trim(), txtProvincia.Text.Trim());
        }
        private bool Avisar(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public bool ValidarDatos()
        {
            int codigo;
            if (!int.TryParse(txtCodigo.Text, out codigo) || codigo <= 0)
                return Avisar("Ingrese un código entero mayor que cero.");
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCanton.Text) || string.IsNullOrWhiteSpace(txtProvincia.Text))
                return Avisar("Complete nombre, cantón y provincia.");
            if (!modificando && TListaComuna.Buscar(codigo) != null)
                return Avisar("Ya existe una comuna con ese código.");
            return true;
        }
        public void setDatos(Comuna op)
        {
            modificando = true;
            txtCodigo.Text = op.Codigo.ToString();
            txtCodigo.ReadOnly = true;
            txtNombre.Text = op.Nombre;
            txtCanton.Text = op.Canton;
            txtProvincia.Text = op.Provincia;
        }
        public void Guardar()
        {
            if (ValidarDatos()) DialogResult = DialogResult.OK;
        }
        private void btnGuardar_Click(object sender, EventArgs e) { Guardar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; }
    }
}
