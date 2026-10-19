namespace SistemaCarreteras.Formularios
{
    partial class frmCategoria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(112, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(206, 97);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 26);
            this.txtCodigo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código de categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "REGISTRAR CATEGORÍA";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboNombre.Location = new System.Drawing.Point(206, 138);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(280, 28);
            this.cboNombre.TabIndex = 36;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 254);
            this.Controls.Add(this.cboNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNombre;
    }
}