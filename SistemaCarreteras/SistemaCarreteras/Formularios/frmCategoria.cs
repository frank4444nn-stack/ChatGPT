using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            cboNombre.Items.Clear();

            cboNombre.Items.Add("Local");
            cboNombre.Items.Add("Comercial");
            cboNombre.Items.Add("Regional");
            cboNombre.Items.Add("Nacional");
            cboNombre.Items.Add("Autovía");

            cboNombre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Categoria CrearObjeto()
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = cboNombre.Text;

            Categoria resultado = new Categoria(codigo, nombre);

            return resultado;
        }

        public bool ValidarDatos()
        {
            bool resultado = true;
            int codigo;

            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código de la categoría.");
                resultado = false;
            }
            else if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un número entero.");
                resultado = false;
            }
            else if (codigo <= 0)
            {
                MessageBox.Show("El código debe ser mayor que cero.");
                resultado = false;
            }
            else if (cboNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                resultado = false;
            }
            else if (TListaCategoria.Buscar(codigo) != null)
            {
                MessageBox.Show("Ya existe una categoría con ese código.");
                resultado = false;
            }

            return resultado;
        }

        public void Guardar()
        {
            if (ValidarDatos()) this.DialogResult = DialogResult.OK;
        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
