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
    public partial class frmAdminCarretera : Form
    {
        public frmAdminCarretera()
        {
            InitializeComponent();
        }

        public void CargarDatos() { TListaDatos.CargarDatos(); }

        public void Listar()
        {
            var datos = TListaCarretera.GetLista()
                .Select(x => new
                {
                    x.Codigo,
                    x.Nombre,
                    Categoria = x.NombreCategoria,
                    LongitudTotal = TListaTramo.GetLista().Where(t => t.Carretera.Codigo == x.Codigo).Sum(t => t.Longitud)
                }).ToList();

            dgvCarreteras.DataSource = null;
            dgvCarreteras.DataSource = datos;

            lblTotal.Text = "Total de carreteras: " + datos.Count;
        }

        public void Buscar()
        {
            string texto = txtBuscar.Text.Trim().ToLower();
            string criterio = cboCategoria.Text;

            var consulta = TListaCarretera.GetLista().AsEnumerable();

            if (texto != "")
            {
                if (criterio == "Código")
                {
                    consulta = consulta.Where(x =>
                        x.Codigo.ToString().Contains(texto));
                }
                else if (criterio == "Nombre")
                {
                    consulta = consulta.Where(x =>
                        x.Nombre != null &&
                        x.Nombre.ToLower().Contains(texto));
                }
                else if (criterio == "Categoría")
                {
                    consulta = consulta.Where(x =>
                        x.NombreCategoria.ToLower().Contains(texto));
                }
            }

            var datos = consulta.Select(x => new
            {
                x.Codigo,
                x.Nombre,
                Categoria = x.NombreCategoria,
                    LongitudTotal = TListaTramo.GetLista().Where(t => t.Carretera.Codigo == x.Codigo).Sum(t => t.Longitud)
            }).ToList();

            dgvCarreteras.DataSource = null;
            dgvCarreteras.DataSource = datos;

            lblTotal.Text = "Total de carreteras: " + datos.Count;
        }
        private void frmAdminCarretera_Load(object sender, EventArgs e)
        {
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("Código");
            cboCategoria.Items.Add("Nombre");
            cboCategoria.Items.Add("Categoría");

            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.SelectedIndex = 0;

            dgvCarreteras.ReadOnly = true;
            dgvCarreteras.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCarreteras.MultiSelect = false;
            dgvCarreteras.AllowUserToAddRows = false;
            dgvCarreteras.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            CargarDatos();
            Listar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cboCategoria.SelectedIndex = 0;
            Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
