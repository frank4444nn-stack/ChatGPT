using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmAdminComunaRecorrida : Form
    {
        public frmAdminComunaRecorrida()
        {
            InitializeComponent();
            Load += Formulario_Load;
            btnRegresar.Click += btnRegresar_Click;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            txtBuscar.TextChanged += Filtro_Cambiado;
            cboBuscarPor.SelectedIndexChanged += Filtro_Cambiado;
            btnInsertar.Click += btnInsertar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }
        public void CargarDatos()
        {
            TListaDatos.CargarDatos();
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.AddRange(new object[] { "Carretera", "Tramo", "Comuna", "Orden" });
            cboBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarPor.SelectedIndex = 0;
            dgvRecorridos.DataSource = null;
            dgvRecorridos.Columns.Clear();
            dgvRecorridos.AutoGenerateColumns = false;
            dgvRecorridos.ReadOnly = true;
            dgvRecorridos.AllowUserToAddRows = false;
            dgvRecorridos.AllowUserToDeleteRows = false;
            dgvRecorridos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecorridos.MultiSelect = false;
            dgvRecorridos.Columns.Add("col0", "Código carretera");
            dgvRecorridos.Columns.Add("col1", "Carretera");
            dgvRecorridos.Columns.Add("col2", "Tramo");
            dgvRecorridos.Columns.Add("col3", "Comuna");
            dgvRecorridos.Columns.Add("col4", "Orden");
            dgvRecorridos.Columns.Add("col5", "Km entrada");
            dgvRecorridos.Columns.Add("col6", "Km salida");
        }
        public void Listar() { Buscar(); }
        public void Buscar()
        {
            dgvRecorridos.Rows.Clear();
            string texto = txtBuscar.Text.Trim().ToLower();
            string criterio = cboBuscarPor.Text;
            var datos = TListaComunaRecorrida.GetLista().Where(op => texto == "" ||
                    (criterio == "Carretera" && (op.NombreCarretera.ToLower().Contains(texto) || op.Tramo.Carretera.Codigo.ToString() == texto)) ||
                    (criterio == "Tramo" && op.NumeroTramo.ToString() == texto) ||
                    (criterio == "Comuna" && op.NombreComuna.ToLower().Contains(texto)) ||
                    (criterio == "Orden" && op.Orden.ToString() == texto));
            datos = datos.OrderBy(op => op.Tramo.Carretera.Codigo).ThenBy(op => op.NumeroTramo).ThenBy(op => op.Orden);
            foreach (ComunaRecorrida op in datos)
            {
                int fila = dgvRecorridos.Rows.Add(op.Tramo.Carretera.Codigo, op.NombreCarretera, op.NumeroTramo, op.NombreComuna, op.Orden, op.KmEntrada, op.KmSalida);
                dgvRecorridos.Rows[fila].Tag = op;
            }
            lblTotal.Text = "Total de recorridos: " + dgvRecorridos.Rows.Count;
            dgvRecorridos.ClearSelection();
        }
        public void Nuevo()
        {
            if (TListaTramo.GetLista().Count == 0 || TListaComuna.GetLista().Count == 0)
            {
                MessageBox.Show("Se necesitan tramos y comunas registrados.");
                return;
            }
            using (frmComunaRecorrida frm = new frmComunaRecorrida())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = TListaComunaRecorrida.Agregar(frm.CrearObjeto());
                    MessageBox.Show(resultado ? "Registro ingresado correctamente." : "No se pudo guardar; revise duplicados y relaciones.");
                    Listar();
                }
            }
        }
        public void Actualizar()
        {
            ComunaRecorrida op = Seleccionado();
            if (op == null) { MessageBox.Show("Seleccione una fila para modificar."); return; }
            using (frmComunaRecorrida frm = new frmComunaRecorrida())
            {
                frm.setDatos(op);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = TListaComunaRecorrida.Modificar(op, frm.CrearObjeto());
                    MessageBox.Show(resultado ? "Registro modificado correctamente." : "No se pudo modificar; revise las relaciones existentes.");
                    Listar();
                }
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e) { Nuevo(); }
        private void btnModificar_Click(object sender, EventArgs e) { Actualizar(); }
        private ComunaRecorrida Seleccionado()
        {
            if (dgvRecorridos.SelectedRows.Count == 0) return null;
            return dgvRecorridos.SelectedRows[0].Tag as ComunaRecorrida;
        }
        public void Eliminar()
        {
            ComunaRecorrida op = Seleccionado();
            if (op == null) { MessageBox.Show("Seleccione una fila para eliminar."); return; }
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool resultado = TListaComunaRecorrida.Eliminar(op.Tramo.Carretera.Codigo, op.Tramo.Numero, op.Orden);
                MessageBox.Show(resultado ? "Registro eliminado correctamente." : "No se puede eliminar: tiene relaciones con tramos o extremos.");
                Listar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) { Eliminar(); }
        private void Formulario_Load(object sender, EventArgs e) { CargarDatos(); Listar(); }
        private void Filtro_Cambiado(object sender, EventArgs e) { if (dgvRecorridos.Columns.Count > 0) Buscar(); }
        private void btnMostrarTodas_Click(object sender, EventArgs e) { txtBuscar.Clear(); cboBuscarPor.SelectedIndex = 0; Listar(); }
        private void btnRegresar_Click(object sender, EventArgs e) { Close(); }
    }
}
