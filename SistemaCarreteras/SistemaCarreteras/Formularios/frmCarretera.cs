using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmCarretera : Form
    {
        public frmCarretera()
        {
            InitializeComponent();
            CargarDatos();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }
        private bool modificando;
        public void CargarDatos()
        {
            cboNombre.Items.Clear();
            cboNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Categoria op in TListaCategoria.GetLista()) cboNombre.Items.Add(op);
        }
        public Carretera CrearObjeto()
        {
            return new Carretera(int.Parse(txtCodigo.Text), txtNombre.Text.Trim(), (Categoria)cboNombre.SelectedItem);
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cboNombre.SelectedItem == null)
                return Avisar("Ingrese el nombre y seleccione la categoría.");
            if (!modificando && TListaCarretera.Buscar(codigo) != null)
                return Avisar("Ya existe una carretera con ese código.");
            return true;
        }
        public void setDatos(Carretera op)
        {
            modificando = true;
            txtCodigo.Text = op.Codigo.ToString();
            txtCodigo.ReadOnly = true;
            txtNombre.Text = op.Nombre;
            cboNombre.SelectedItem = op.Categoria;
        }
        public void Guardar()
        {
            if (ValidarDatos()) DialogResult = DialogResult.OK;
        }
        private void btnGuardar_Click(object sender, EventArgs e) { Guardar(); }
        private void btnCancelar_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; }
    }
}
