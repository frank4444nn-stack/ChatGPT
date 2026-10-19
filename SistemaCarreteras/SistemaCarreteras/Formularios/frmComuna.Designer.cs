namespace SistemaCarreteras.Formularios
{
    partial class frmComuna
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
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(94, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(120, 190);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(280, 26);
            this.txtCanton.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 97);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 26);
            this.txtCodigo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantón:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "DATOS DEL COMUNA";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(120, 238);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(280, 26);
            this.txtProvincia.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Provincia:";
            // 
            // frmComuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 383);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComuna";
            this.Text = "frmComuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label5;
    }
}