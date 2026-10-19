namespace SistemaCarreteras.Formularios
{
    partial class frmAdminCarretera
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
            this.dgvCarreteras = new System.Windows.Forms.DataGridView();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreteras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreteras
            // 
            this.dgvCarreteras.AllowUserToAddRows = false;
            this.dgvCarreteras.AllowUserToDeleteRows = false;
            this.dgvCarreteras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarreteras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreteras.Location = new System.Drawing.Point(48, 157);
            this.dgvCarreteras.MultiSelect = false;
            this.dgvCarreteras.Name = "dgvCarreteras";
            this.dgvCarreteras.ReadOnly = true;
            this.dgvCarreteras.RowHeadersVisible = false;
            this.dgvCarreteras.RowHeadersWidth = 62;
            this.dgvCarreteras.RowTemplate.Height = 28;
            this.dgvCarreteras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarreteras.Size = new System.Drawing.Size(980, 330);
            this.dgvCarreteras.TabIndex = 37;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Tipo",
            "Atracción"});
            this.cboCategoria.Location = new System.Drawing.Point(907, 108);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 28);
            this.cboCategoria.TabIndex = 36;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(134, 108);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 26);
            this.txtBuscar.TabIndex = 35;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "ADMINISTRACIÓN DE CARRETERAS";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(918, 506);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 39;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(65, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 20);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total de carreteras: 0";
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(753, 506);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarTodas.TabIndex = 40;
            this.btnMostrarTodas.Text = "Mostrar todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // frmAdminCarretera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 560);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.dgvCarreteras);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Name = "frmAdminCarretera";
            this.Text = "frmAdminCarretera";
            this.Load += new System.EventHandler(this.frmAdminCarretera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreteras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreteras;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMostrarTodas;
    }
}