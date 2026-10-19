namespace SistemaCarreteras.Formularios
{
    partial class frmAdminTramo
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
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.dgvTramos = new System.Windows.Forms.DataGridView();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(726, 490);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarTodas.TabIndex = 55;
            this.btnMostrarTodas.Text = "Mostrar todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            // 
            // dgvTramos
            // 
            this.dgvTramos.AllowUserToAddRows = false;
            this.dgvTramos.AllowUserToDeleteRows = false;
            this.dgvTramos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramos.Location = new System.Drawing.Point(21, 141);
            this.dgvTramos.MultiSelect = false;
            this.dgvTramos.Name = "dgvTramos";
            this.dgvTramos.ReadOnly = true;
            this.dgvTramos.RowHeadersVisible = false;
            this.dgvTramos.RowHeadersWidth = 62;
            this.dgvTramos.RowTemplate.Height = 28;
            this.dgvTramos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramos.Size = new System.Drawing.Size(980, 330);
            this.dgvTramos.TabIndex = 52;
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Items.AddRange(new object[] {
            "Carretera",
            "Número de tramo",
            "Kilómetro inicial",
            "Kilómetro final"});
            this.cboBuscarPor.Location = new System.Drawing.Point(880, 92);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.cboBuscarPor.TabIndex = 51;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(107, 92);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 26);
            this.txtBuscar.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Buscar:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(891, 490);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 54;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(38, 497);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 20);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "Total de carreteras: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 45);
            this.label1.TabIndex = 48;
            this.label1.Text = "ADMINISTRACIÓN DE TRAMOS";
            // 
            // frmAdminTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 552);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.dgvTramos);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminTramo";
            this.Text = "frmAdminTramo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.DataGridView dgvTramos;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}