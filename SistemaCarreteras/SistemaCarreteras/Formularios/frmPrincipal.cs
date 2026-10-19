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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            carreterasToolStripMenuItem.Click += carreterasToolStripMenuItem_Click;
        }


        public void AbrirFormulario(Form formulario)
        {
            using (formulario) formulario.ShowDialog();
            lblEstado.Text = "Sistema listo";
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            SistemaCarreteras.Controladores.TListaDatos.CargarDatos();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Administración de categorías";
            frmadminCategoria frm = new frmadminCategoria();
            AbrirFormulario(frm);
        }

        private void comunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Administración de comunas";
            frmAdminComuna frm = new frmAdminComuna();
            AbrirFormulario(frm);
        }

        private void tramosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Administración de tramos";
            frmAdminTramo frm = new frmAdminTramo();
            AbrirFormulario(frm);
        }

        private void comunasRecorridasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Administración de comunas recorridas";
            frmAdminComunaRecorrida frm = new frmAdminComunaRecorrida();
            AbrirFormulario(frm);
        }

        private void extremosDeCarreteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Administración de extremos";
            frmAdminExtremo frm = new frmAdminExtremo();
            AbrirFormulario(frm);

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Consultas LINQ";
            AbrirFormulario(new frmConsultas());
        }
        private void carreterasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Consulta de carreteras";
            AbrirFormulario(new frmAdminCarretera());
        }
    }
}
