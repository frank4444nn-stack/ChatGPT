using SistemaCarreteras.Controladores;
using SistemaCarreteras.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCarreteras.Formularios
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            TListaDatos.CargarDatos();
            cboConsulta.Items.AddRange(new object[] {
                "1. Carreteras por categoría", "2. Tramos de una carretera",
                "3. Comunas recorridas por tramo", "4. Extremos de una carretera", "5. Confluencias entre carreteras" });
            foreach (Categoria op in TListaCategoria.GetLista()) cboCategoria.Items.Add(op);
            foreach (Carretera op in TListaCarretera.GetLista()) cboCarretera.Items.Add(op);
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
            if (cboCarretera.Items.Count > 0) cboCarretera.SelectedIndex = 0;
            cboConsulta.SelectedIndex = 0;
        }
        public void CargarTramos()
        {
            cboTramo.Items.Clear();
            Carretera carretera = cboCarretera.SelectedItem as Carretera;
            if (carretera != null)
                foreach (Tramo op in TListaTramo.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo).OrderBy(x => x.Numero))
                    cboTramo.Items.Add(op);
            if (cboTramo.Items.Count > 0) cboTramo.SelectedIndex = 0;
        }
        public void HabilitarFiltros()
        {
            cboCategoria.Enabled = cboConsulta.SelectedIndex == 0;
            cboCarretera.Enabled = cboConsulta.SelectedIndex >= 1 && cboConsulta.SelectedIndex <= 3;
            cboTramo.Enabled = cboConsulta.SelectedIndex == 2;
            dgvConsulta.DataSource = null;
            lblTotal.Text = "Seleccione los filtros y pulse Consultar.";
        }
        public void Consultar()
        {
            Categoria categoria = cboCategoria.SelectedItem as Categoria;
            Carretera carretera = cboCarretera.SelectedItem as Carretera;
            Tramo tramo = cboTramo.SelectedItem as Tramo;
            dgvConsulta.DataSource = null;
            if ((cboConsulta.SelectedIndex == 0 && categoria == null) ||
                (cboConsulta.SelectedIndex >= 1 && cboConsulta.SelectedIndex <= 3 && carretera == null) ||
                (cboConsulta.SelectedIndex == 2 && tramo == null))
            {
                lblTotal.Text = "No hay datos para los filtros seleccionados.";
                return;
            }
            if (cboConsulta.SelectedIndex == 0)
            {
                var datos = TListaCarretera.GetLista().Where(x => x.Categoria.Codigo == categoria.Codigo)
                    .Select(x => new { x.Codigo, x.Nombre, Categoria = x.NombreCategoria,
                        LongitudTotal = TListaTramo.GetLista().Where(t => t.Carretera.Codigo == x.Codigo).Sum(t => t.Longitud) }).ToList();
                dgvConsulta.DataSource = datos;
            }
            else if (cboConsulta.SelectedIndex == 1)
            {
                var datos = TListaTramo.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo)
                    .OrderBy(x => x.Numero).Select(x => new { x.NombreCarretera, x.Numero, x.KmInicial, x.KmFinal, x.Longitud }).ToList();
                dgvConsulta.DataSource = datos;
            }
            else if (cboConsulta.SelectedIndex == 2)
            {
                var datos = TListaComunaRecorrida.GetLista().Where(x => x.Tramo.Carretera.Codigo == carretera.Codigo && x.Tramo.Numero == tramo.Numero)
                    .OrderBy(x => x.Orden).Select(x => new { x.NombreCarretera, x.NumeroTramo, x.NombreComuna, x.Orden, x.KmEntrada, x.KmSalida }).ToList();
                dgvConsulta.DataSource = datos;
            }
            else if (cboConsulta.SelectedIndex == 3)
            {
                var datos = TListaExtremoCarretera.GetLista().Where(x => x.Carretera.Codigo == carretera.Codigo)
                    .OrderByDescending(x => x.TipoExtremo).Select(x => new { x.NombreCarretera, x.TipoExtremo, x.NombreTramo,
                        x.NombreComuna, x.Kilometro, x.TipoFinalizacion, x.NombreCarreteraDestino }).ToList();
                dgvConsulta.DataSource = datos;
            }
            else if (cboConsulta.SelectedIndex == 4)
            {
                var datos = TListaExtremoCarretera.GetLista().Where(x => x.TipoFinalizacion == "Confluencia con otra carretera")
                    .Select(x => new { Origen = x.NombreCarretera, x.TipoExtremo, TramoOrigen = x.Tramo.Numero,
                        ComunaOrigen = x.NombreComuna, x.Kilometro, Destino = x.NombreCarreteraDestino,
                        TramoDestino = x.TramoDestino.Numero, ComunaDestino = x.ComunaDestino.Nombre, x.KmDestino, x.Observacion }).ToList();
                dgvConsulta.DataSource = datos;
            }
            lblTotal.Text = "Total de resultados: " + dgvConsulta.Rows.Count;
        }
        private void frmConsultas_Load(object sender, EventArgs e) { CargarDatos(); }
        private void cboConsulta_SelectedIndexChanged(object sender, EventArgs e) { HabilitarFiltros(); }
        private void cboCarretera_SelectedIndexChanged(object sender, EventArgs e) { CargarTramos(); HabilitarFiltros(); }
        private void Filtro_Cambiado(object sender, EventArgs e) { dgvConsulta.DataSource = null; lblTotal.Text = "Pulse Consultar para actualizar."; }
        private void btnConsultar_Click(object sender, EventArgs e) { Consultar(); }
        private void btnRegresar_Click(object sender, EventArgs e) { Close(); }
    }
}
