namespace SistemaCarreteras.Formularios
{
    partial class frmConsultas
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.cboConsulta = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboCarretera = new System.Windows.Forms.ComboBox();
            this.cboTramo = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCarretera = new System.Windows.Forms.Label();
            this.lblTramo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            this.cboConsulta.SetBounds(130, 20, 470, 28);
            this.cboCategoria.SetBounds(130, 65, 200, 28);
            this.cboCarretera.SetBounds(130, 110, 470, 28);
            this.cboTramo.SetBounds(715, 110, 180, 28);
            this.cboConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarretera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsulta.SelectedIndexChanged += new System.EventHandler(this.cboConsulta_SelectedIndexChanged);
            this.cboCarretera.SelectedIndexChanged += new System.EventHandler(this.cboCarretera_SelectedIndexChanged);
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.Filtro_Cambiado);
            this.cboTramo.SelectedIndexChanged += new System.EventHandler(this.Filtro_Cambiado);
            this.lblConsulta.Text = "Consulta:";
            this.lblConsulta.SetBounds(20, 25, 105, 25);
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.SetBounds(20, 70, 105, 25);
            this.lblCarretera.Text = "Carretera:";
            this.lblCarretera.SetBounds(20, 115, 105, 25);
            this.lblTramo.Text = "Tramo:";
            this.lblTramo.SetBounds(630, 115, 80, 25);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.SetBounds(715, 20, 180, 35);
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.dgvConsulta.SetBounds(20, 165, 920, 340);
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.SetBounds(20, 525, 660, 30);
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.SetBounds(810, 520, 130, 35);
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 575);
            this.MinimumSize = new System.Drawing.Size(800, 580);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.cboConsulta, this.cboCategoria, this.cboCarretera,
                this.cboTramo, this.dgvConsulta, this.btnConsultar, this.btnRegresar, this.lblTotal,
                this.lblConsulta, this.lblCategoria, this.lblCarretera, this.lblTramo });
            this.Text = "Consultas LINQ de la red vial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.ComboBox cboConsulta;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboCarretera;
        private System.Windows.Forms.ComboBox cboTramo;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCarretera;
        private System.Windows.Forms.Label lblTramo;
    }
}
