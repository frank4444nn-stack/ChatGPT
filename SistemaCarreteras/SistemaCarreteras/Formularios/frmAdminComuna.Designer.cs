namespace SistemaCarreteras.Formularios
{
    partial class frmAdminComuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.dgvComunas = new System.Windows.Forms.DataGridView();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComunas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 45);
            this.label1.TabIndex = 28;
            this.label1.Text = "ADMINISTRACIÓN DE COMUNAS";
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(717, 487);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarTodas.TabIndex = 47;
            this.btnMostrarTodas.Text = "Mostrar todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            // 
            // dgvComunas
            // 
            this.dgvComunas.AllowUserToAddRows = false;
            this.dgvComunas.AllowUserToDeleteRows = false;
            this.dgvComunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComunas.Location = new System.Drawing.Point(12, 138);
            this.dgvComunas.MultiSelect = false;
            this.dgvComunas.Name = "dgvComunas";
            this.dgvComunas.ReadOnly = true;
            this.dgvComunas.RowHeadersVisible = false;
            this.dgvComunas.RowHeadersWidth = 62;
            this.dgvComunas.RowTemplate.Height = 28;
            this.dgvComunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComunas.Size = new System.Drawing.Size(980, 330);
            this.dgvComunas.TabIndex = 44;
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Tipo",
            "Atracción"});
            this.cboBuscarPor.Location = new System.Drawing.Point(871, 89);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.cboBuscarPor.TabIndex = 43;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(98, 89);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 26);
            this.txtBuscar.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Buscar:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(882, 487);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 46;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 20);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "Total de carreteras: 0";
            // 
            // frmAdminComuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.dgvComunas);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminComuna";
            this.Text = "frmAdminComuna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.DataGridView dgvComunas;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
    }
}