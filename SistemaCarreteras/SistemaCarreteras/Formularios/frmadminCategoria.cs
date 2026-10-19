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
    public partial class frmadminCategoria : Form
    {
        public frmadminCategoria()
        {
            InitializeComponent();
        }

        public void CargarDatos() { TListaDatos.CargarDatos(); }

        public void Listar()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = TListaCategoria.GetLista();

            lblTotal.Text = "Total de categorías: " +
                TListaCategoria.listaCategorias.Count;
        }

        public void Nuevo()
        {
            using (frmCategoria frm = new frmCategoria())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = TListaCategoria.Agregar(frm.CrearObjeto());
                    MessageBox.Show(resultado ? "Categoría registrada correctamente." : "No se pudo registrar la categoría.");
                    Listar();
                }
            }
        }
        private void frmadminCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Listar();

            dgvCategorias.ReadOnly = true;
            dgvCategorias.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
