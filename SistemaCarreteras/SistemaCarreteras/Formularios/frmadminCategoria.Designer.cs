namespace SistemaCarreteras.Formularios
{
    partial class frmadminCategoria
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 84);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(980, 376);
            this.dgvCategorias.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "ADMINISTRACIÓN DE CATEGORÍAS";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(882, 479);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(742, 479);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 35);
            this.btnInsertar.TabIndex = 24;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(161, 20);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total de categorías: 0";
            // 
            // frmadminCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmadminCategoria";
            this.Text = "frmadminCategoria";
            this.Load += new System.EventHandler(this.frmadminCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblTotal;
    }
}