namespace SistemaCarreteras.Formularios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreterasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tramosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunasRecorridasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extremosDeCarreteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 25);
            this.lblEstado.Text = "Sistema listo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(276, 317);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(569, 32);
            this.lblSubtitulo.TabIndex = 7;
            this.lblSubtitulo.Text = "Administración de carreteras, tramos y comunas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(223, 231);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(692, 70);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "SISTEMA DE GESTIÓN VIAL";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasToolStripMenuItem,
            this.carreterasToolStripMenuItem,
            this.comunasToolStripMenuItem,
            this.tramosToolStripMenuItem,
            this.comunasRecorridasToolStripMenuItem,
            this.extremosDeCarreteraToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // carreterasToolStripMenuItem
            // 
            this.carreterasToolStripMenuItem.Name = "carreterasToolStripMenuItem";
            this.carreterasToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.carreterasToolStripMenuItem.Text = "Carreteras";
            // 
            // comunasToolStripMenuItem
            // 
            this.comunasToolStripMenuItem.Name = "comunasToolStripMenuItem";
            this.comunasToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.comunasToolStripMenuItem.Text = "Comunas";
            this.comunasToolStripMenuItem.Click += new System.EventHandler(this.comunasToolStripMenuItem_Click);
            // 
            // tramosToolStripMenuItem
            // 
            this.tramosToolStripMenuItem.Name = "tramosToolStripMenuItem";
            this.tramosToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.tramosToolStripMenuItem.Text = "Tramos";
            this.tramosToolStripMenuItem.Click += new System.EventHandler(this.tramosToolStripMenuItem_Click);
            // 
            // comunasRecorridasToolStripMenuItem
            // 
            this.comunasRecorridasToolStripMenuItem.Name = "comunasRecorridasToolStripMenuItem";
            this.comunasRecorridasToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.comunasRecorridasToolStripMenuItem.Text = "Comunas recorridas";
            this.comunasRecorridasToolStripMenuItem.Click += new System.EventHandler(this.comunasRecorridasToolStripMenuItem_Click);
            // 
            // extremosDeCarreteraToolStripMenuItem
            // 
            this.extremosDeCarreteraToolStripMenuItem.Name = "extremosDeCarreteraToolStripMenuItem";
            this.extremosDeCarreteraToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.extremosDeCarreteraToolStripMenuItem.Text = "Extremos de carretera";
            this.extremosDeCarreteraToolStripMenuItem.Click += new System.EventHandler(this.extremosDeCarreteraToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Carreteras";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreterasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunasRecorridasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extremosDeCarreteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}