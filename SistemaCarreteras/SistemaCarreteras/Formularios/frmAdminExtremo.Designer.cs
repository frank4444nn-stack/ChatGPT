namespace SistemaCarreteras.Formularios
{
    partial class frmAdminExtremo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.dgvExtremos = new System.Windows.Forms.DataGridView();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtremos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(607, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 35);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(480, 491);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 35);
            this.btnModificar.TabIndex = 68;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(351, 491);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 35);
            this.btnInsertar.TabIndex = 67;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(737, 491);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarTodas.TabIndex = 66;
            this.btnMostrarTodas.Text = "Mostrar todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            // 
            // dgvExtremos
            // 
            this.dgvExtremos.AllowUserToAddRows = false;
            this.dgvExtremos.AllowUserToDeleteRows = false;
            this.dgvExtremos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExtremos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtremos.Location = new System.Drawing.Point(12, 142);
            this.dgvExtremos.MultiSelect = false;
            this.dgvExtremos.Name = "dgvExtremos";
            this.dgvExtremos.ReadOnly = true;
            this.dgvExtremos.RowHeadersVisible = false;
            this.dgvExtremos.RowHeadersWidth = 62;
            this.dgvExtremos.RowTemplate.Height = 28;
            this.dgvExtremos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtremos.Size = new System.Drawing.Size(980, 330);
            this.dgvExtremos.TabIndex = 63;
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
            this.cboBuscarPor.Location = new System.Drawing.Point(871, 93);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.cboBuscarPor.TabIndex = 62;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(98, 93);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 26);
            this.txtBuscar.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Buscar:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(882, 491);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 65;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 498);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 20);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "Total de carreteras: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 45);
            this.label1.TabIndex = 59;
            this.label1.Text = "ADMINISTRACIÓN DE EXTREMOS";
            // 
            // frmAdminExtremo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 549);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.dgvExtremos);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminExtremo";
            this.Text = "frmAdminExtremo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtremos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.DataGridView dgvExtremos;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}