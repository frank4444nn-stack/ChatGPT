using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmAdminExtremo : Form
    {
        public frmAdminExtremo()
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
            cboBuscarPor.Items.AddRange(new object[] { "Carretera", "Tipo de extremo", "Finalización", "Destino" });
            cboBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarPor.SelectedIndex = 0;
            dgvExtremos.DataSource = null;
            dgvExtremos.Columns.Clear();
            dgvExtremos.AutoGenerateColumns = false;
            dgvExtremos.ReadOnly = true;
            dgvExtremos.AllowUserToAddRows = false;
            dgvExtremos.AllowUserToDeleteRows = false;
            dgvExtremos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExtremos.MultiSelect = false;
            dgvExtremos.Columns.Add("col0", "Código carretera");
            dgvExtremos.Columns.Add("col1", "Carretera");
            dgvExtremos.Columns.Add("col2", "Extremo");
            dgvExtremos.Columns.Add("col3", "Tramo");
            dgvExtremos.Columns.Add("col4", "Comuna");
            dgvExtremos.Columns.Add("col5", "Km");
            dgvExtremos.Columns.Add("col6", "Finalización");
            dgvExtremos.Columns.Add("col7", "Destino");
            dgvExtremos.Columns.Add("col8", "Tramo destino");
            dgvExtremos.Columns.Add("col9", "Comuna destino");
            dgvExtremos.Columns.Add("col10", "Km destino");
            dgvExtremos.Columns.Add("col11", "Observación");
        }
        public void Listar() { Buscar(); }
        public void Buscar()
        {
            dgvExtremos.Rows.Clear();
            string texto = txtBuscar.Text.Trim().ToLower();
            string criterio = cboBuscarPor.Text;
            var datos = TListaExtremoCarretera.GetLista().Where(op => texto == "" ||
                    (criterio == "Carretera" && (op.NombreCarretera.ToLower().Contains(texto) || op.Carretera.Codigo.ToString() == texto)) ||
                    (criterio == "Tipo de extremo" && op.TipoExtremo.ToLower().Contains(texto)) ||
                    (criterio == "Finalización" && op.TipoFinalizacion.ToLower().Contains(texto)) ||
                    (criterio == "Destino" && op.NombreCarreteraDestino.ToLower().Contains(texto)));
            foreach (ExtremoCarretera op in datos)
            {
                int fila = dgvExtremos.Rows.Add(op.Carretera.Codigo, op.NombreCarretera, op.TipoExtremo, op.Tramo.Numero, op.NombreComuna, op.Kilometro, op.TipoFinalizacion, op.NombreCarreteraDestino, op.TramoDestino == null ? "" : op.TramoDestino.Numero.ToString(), op.ComunaDestino == null ? "" : op.ComunaDestino.Nombre, op.CarreteraDestino == null ? "" : op.KmDestino.ToString(), op.Observacion);
                dgvExtremos.Rows[fila].Tag = op;
            }
            lblTotal.Text = "Total de extremos: " + dgvExtremos.Rows.Count;
            dgvExtremos.ClearSelection();
        }
        public void Nuevo()
        {
            if (TListaTramo.GetLista().Count == 0 || TListaComuna.GetLista().Count == 0)
            {
                MessageBox.Show("Se necesitan tramos y comunas registrados.");
                return;
            }
            using (frmExtremo frm = new frmExtremo())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = TListaExtremoCarretera.Agregar(frm.CrearObjeto());
                    MessageBox.Show(resultado ? "Registro ingresado correctamente." : "No se pudo guardar; revise duplicados y relaciones.");
                    Listar();
                }
            }
        }
        public void Actualizar()
        {
            ExtremoCarretera op = Seleccionado();
            if (op == null) { MessageBox.Show("Seleccione una fila para modificar."); return; }
            using (frmExtremo frm = new frmExtremo())
            {
                frm.setDatos(op);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = TListaExtremoCarretera.Modificar(frm.CrearObjeto());
                    MessageBox.Show(resultado ? "Registro modificado correctamente." : "No se pudo modificar; revise las relaciones existentes.");
                    Listar();
                }
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e) { Nuevo(); }
        private void btnModificar_Click(object sender, EventArgs e) { Actualizar(); }
        private ExtremoCarretera Seleccionado()
        {
            if (dgvExtremos.SelectedRows.Count == 0) return null;
            return dgvExtremos.SelectedRows[0].Tag as ExtremoCarretera;
        }
        public void Eliminar()
        {
            ExtremoCarretera op = Seleccionado();
            if (op == null) { MessageBox.Show("Seleccione una fila para eliminar."); return; }
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool resultado = TListaExtremoCarretera.Eliminar(op.Carretera.Codigo, op.TipoExtremo);
                MessageBox.Show(resultado ? "Registro eliminado correctamente." : "No se puede eliminar: tiene relaciones con tramos o extremos.");
                Listar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) { Eliminar(); }
        private void Formulario_Load(object sender, EventArgs e) { CargarDatos(); Listar(); }
        private void Filtro_Cambiado(object sender, EventArgs e) { if (dgvExtremos.Columns.Count > 0) Buscar(); }
        private void btnMostrarTodas_Click(object sender, EventArgs e) { txtBuscar.Clear(); cboBuscarPor.SelectedIndex = 0; Listar(); }
        private void btnRegresar_Click(object sender, EventArgs e) { Close(); }
    }
}
