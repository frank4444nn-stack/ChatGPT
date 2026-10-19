namespace SistemaCarreteras.Formularios
{
    partial class frmCarretera
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(207, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(207, 109);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 26);
            this.txtCodigo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de carretera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código de carretera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "DATOS DE CARRETERA";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(207, 207);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(280, 28);
            this.cboNombre.TabIndex = 37;
            // 
            // frmCarretera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 354);
            this.Controls.Add(this.cboNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCarretera";
            this.Text = "frmCarretera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNombre;
    }
}