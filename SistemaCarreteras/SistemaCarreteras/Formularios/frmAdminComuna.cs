using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmAdminComuna : Form
    {
        public frmAdminComuna()
        {
            InitializeComponent();
            Load += Formulario_Load;
            btnRegresar.Click += btnRegresar_Click;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            txtBuscar.TextChanged += Filtro_Cambiado;
            cboBuscarPor.SelectedIndexChanged += Filtro_Cambiado;
            Button btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.SetBounds(btnMostrarTodas.Left - 125, btnMostrarTodas.Top, 110, btnMostrarTodas.Height);
            btnEliminar.Click += btnEliminar_Click;
            Controls.Add(btnEliminar);
        }
        public void CargarDatos()
        {
            TListaDatos.CargarDatos();
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.AddRange(new object[] { "Nombre", "Cantón", "Provincia" });
            cboBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarPor.SelectedIndex = 0;
            dgvComunas.DataSource = null;
            dgvComunas.Columns.Clear();
            dgvComunas.AutoGenerateColumns = false;
            dgvComunas.ReadOnly = true;
            dgvComunas.AllowUserToAddRows = false;
            dgvComunas.AllowUserToDeleteRows = false;
            dgvComunas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComunas.MultiSelect = false;
            dgvComunas.Columns.Add("col0", "Código");
            dgvComunas.Columns.Add("col1", "Nombre");
            dgvComunas.Columns.Add("col2", "Cantón");
            dgvComunas.Columns.Add("col3", "Provincia");
        }
        public void Listar() { Buscar(); }
        public void Buscar()
        {
            dgvComunas.Rows.Clear();
            string texto = txtBuscar.Text.Trim().ToLower();
            string criterio = cboBuscarPor.Text;
            var datos = TListaComuna.GetLista().Where(op => texto == "" ||
                    (criterio == "Nombre" && op.Nombre.ToLower().Contains(texto)) ||
                    (criterio == "Cantón" && op.Canton.ToLower().Contains(texto)) ||
                    (criterio == "Provincia" && op.Provincia.ToLower().Contains(texto)));
            foreach (Comuna op in datos)
            {
                int fila = dgvComunas.Rows.Add(op.Codigo, op.Nombre, op.Canton, op.Provincia);
                dgvComunas.Rows[fila].Tag = op;
            }
            lblTotal.Text = "Total de comunas: " + dgvComunas.Rows.Count;
            dgvComunas.ClearSelection();
        }
        private Comuna Seleccionado()
        {
            if (dgvComunas.SelectedRows.Count == 0) return null;
            return dgvComunas.SelectedRows[0].Tag as Comuna;
        }
        public void Eliminar()
        {
            Comuna op = Seleccionado();
            if (op == null) { MessageBox.Show("Seleccione una fila para eliminar."); return; }
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool resultado = TListaComuna.Eliminar(op.Codigo);
                MessageBox.Show(resultado ? "Registro eliminado correctamente." : "No se puede eliminar: tiene relaciones con tramos o extremos.");
                Listar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) { Eliminar(); }
        private void Formulario_Load(object sender, EventArgs e) { CargarDatos(); Listar(); }
        private void Filtro_Cambiado(object sender, EventArgs e) { if (dgvComunas.Columns.Count > 0) Buscar(); }
        private void btnMostrarTodas_Click(object sender, EventArgs e) { txtBuscar.Clear(); cboBuscarPor.SelectedIndex = 0; Listar(); }
        private void btnRegresar_Click(object sender, EventArgs e) { Close(); }
    }
}
