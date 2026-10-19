using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmAdminTramo : Form
    {
        public frmAdminTramo()
        {
            InitializeComponent();
            Load += Formulario_Load;
            btnRegresar.Click += btnRegresar_Click;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            txtBuscar.TextChanged += Filtro_Cambiado;
            cboBuscarPor.SelectedIndexChanged += Filtro_Cambiado;
            txtBuscar.Width = Math.Min(txtBuscar.Width, cboBuscarPor.Left - txtBuscar.Left - 15);
        }
        public void CargarDatos()
        {
            TListaDatos.CargarDatos();
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.AddRange(new object[] { "Carretera", "Número", "Rango de kilómetros" });
            cboBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarPor.SelectedIndex = 0;
            dgvTramos.DataSource = null;
            dgvTramos.Columns.Clear();
            dgvTramos.AutoGenerateColumns = false;
            dgvTramos.ReadOnly = true;
            dgvTramos.AllowUserToAddRows = false;
            dgvTramos.AllowUserToDeleteRows = false;
            dgvTramos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTramos.MultiSelect = false;
            dgvTramos.Columns.Add("col0", "Código carretera");
            dgvTramos.Columns.Add("col1", "Carretera");
            dgvTramos.Columns.Add("col2", "Número");
            dgvTramos.Columns.Add("col3", "Km inicial");
            dgvTramos.Columns.Add("col4", "Km final");
            dgvTramos.Columns.Add("col5", "Longitud");
        }
        public void Listar() { Buscar(); }
        public void Buscar()
        {
            dgvTramos.Rows.Clear();
            string texto = txtBuscar.Text.Trim().ToLower();
            string criterio = cboBuscarPor.Text;
            double desde = 0, hasta = 0;
            if (criterio == "Rango de kilómetros" && texto != "")
            {
                string[] partes = texto.Split(';');
                if (partes.Length != 2 || !double.TryParse(partes[0], out desde) ||
                    !double.TryParse(partes[1], out hasta) || double.IsNaN(desde) || double.IsNaN(hasta) ||
                    double.IsInfinity(desde) || double.IsInfinity(hasta) || desde < 0 || desde > hasta)
                {
                    lblTotal.Text = "Use desde;hasta, por ejemplo 0;20";
                    return;
                }
            }
            var datos = TListaTramo.GetLista().Where(op => texto == "" ||
                    (criterio == "Carretera" && (op.NombreCarretera.ToLower().Contains(texto) || op.Carretera.Codigo.ToString() == texto)) ||
                    (criterio == "Número" && op.Numero.ToString() == texto) ||
                    (criterio == "Rango de kilómetros" && op.KmInicial <= hasta && op.KmFinal >= desde));
            datos = datos.OrderBy(op => op.Carretera.Codigo).ThenBy(op => op.Numero);
            foreach (Tramo op in datos)
            {
                int fila = dgvTramos.Rows.Add(op.Carretera.Codigo, op.NombreCarretera, op.Numero, op.KmInicial, op.KmFinal, op.Longitud);
                dgvTramos.Rows[fila].Tag = op;
            }
            lblTotal.Text = "Total de tramos: " + dgvTramos.Rows.Count;
            dgvTramos.ClearSelection();
        }
        private void Formulario_Load(object sender, EventArgs e) { CargarDatos(); Listar(); }
        private void Filtro_Cambiado(object sender, EventArgs e) { if (dgvTramos.Columns.Count > 0) Buscar(); }
        private void btnMostrarTodas_Click(object sender, EventArgs e) { txtBuscar.Clear(); cboBuscarPor.SelectedIndex = 0; Listar(); }
        private void btnRegresar_Click(object sender, EventArgs e) { Close(); }
    }
}
