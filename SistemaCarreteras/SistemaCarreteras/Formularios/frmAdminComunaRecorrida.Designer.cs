namespace SistemaCarreteras.Formularios
{
    partial class frmAdminComunaRecorrida
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
            this.dgvRecorridos = new System.Windows.Forms.DataGridView();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorridos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(737, 471);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarTodas.TabIndex = 55;
            this.btnMostrarTodas.Text = "Mostrar todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            // 
            // dgvRecorridos
            // 
            this.dgvRecorridos.AllowUserToAddRows = false;
            this.dgvRecorridos.AllowUserToDeleteRows = false;
            this.dgvRecorridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecorridos.Location = new System.Drawing.Point(12, 122);
            this.dgvRecorridos.MultiSelect = false;
            this.dgvRecorridos.Name = "dgvRecorridos";
            this.dgvRecorridos.ReadOnly = true;
            this.dgvRecorridos.RowHeadersVisible = false;
            this.dgvRecorridos.RowHeadersWidth = 62;
            this.dgvRecorridos.RowTemplate.Height = 28;
            this.dgvRecorridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecorridos.Size = new System.Drawing.Size(980, 330);
            this.dgvRecorridos.TabIndex = 52;
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
            this.cboBuscarPor.Location = new System.Drawing.Point(871, 73);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.cboBuscarPor.TabIndex = 51;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(98, 73);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 26);
            this.txtBuscar.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Buscar:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(882, 471);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 54;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 478);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 20);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "Total de carreteras: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 45);
            this.label1.TabIndex = 48;
            this.label1.Text = "ADMINISTRACIÓN DE COMUNAS RECORRIDAS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(607, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 35);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(480, 471);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 35);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(351, 471);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 35);
            this.btnInsertar.TabIndex = 56;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // frmAdminComunaRecorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 526);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.dgvRecorridos);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminComunaRecorrida";
            this.Text = "frmAdminComunaRecorrida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.DataGridView dgvRecorridos;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
    }
}