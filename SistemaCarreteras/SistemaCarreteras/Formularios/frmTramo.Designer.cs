namespace SistemaCarreteras.Formularios
{
    partial class frmTramo
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
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarretera = new System.Windows.Forms.ComboBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(208, 243);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(280, 26);
            this.txtKmFinal.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kilómetro final:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(101, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.Location = new System.Drawing.Point(208, 195);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(280, 26);
            this.txtKmInicial.TabIndex = 26;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(208, 149);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(280, 26);
            this.txtNumero.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kilómetro inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Número de tramo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Carretera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRO DE TRAMOS";
            // 
            // cboCarretera
            // 
            this.cboCarretera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarretera.FormattingEnabled = true;
            this.cboCarretera.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboCarretera.Location = new System.Drawing.Point(208, 105);
            this.cboCarretera.Name = "cboCarretera";
            this.cboCarretera.Size = new System.Drawing.Size(280, 28);
            this.cboCarretera.TabIndex = 37;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(208, 295);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(280, 26);
            this.txtLongitud.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Longitud del tramo:";
            // 
            // frmTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 412);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCarretera);
            this.Controls.Add(this.txtKmFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtKmInicial);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTramo";
            this.Text = "frmTramo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarretera;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label6;
    }
}