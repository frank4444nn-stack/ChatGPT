namespace SistemaCarreteras.Formularios
{
    partial class frmExtremo
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
            this.cboTramo = new System.Windows.Forms.ComboBox();
            this.cboTipoExtremo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCarretera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtKilometro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarreteraDestino = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKmDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboComuna = new System.Windows.Forms.ComboBox();
            this.cboTipoFinalizacion = new System.Windows.Forms.ComboBox();
            this.cboTramoDestino = new System.Windows.Forms.ComboBox();
            this.cboComunaDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboTramo
            // 
            this.cboTramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTramo.FormattingEnabled = true;
            this.cboTramo.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboTramo.Location = new System.Drawing.Point(184, 183);
            this.cboTramo.Name = "cboTramo";
            this.cboTramo.Size = new System.Drawing.Size(280, 28);
            this.cboTramo.TabIndex = 71;
            // 
            // cboTipoExtremo
            // 
            this.cboTipoExtremo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoExtremo.FormattingEnabled = true;
            this.cboTipoExtremo.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboTipoExtremo.Location = new System.Drawing.Point(182, 141);
            this.cboTipoExtremo.Name = "cboTipoExtremo";
            this.cboTipoExtremo.Size = new System.Drawing.Size(280, 28);
            this.cboTipoExtremo.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "Comuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Tipo de extremo:";
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
            this.cboCarretera.Location = new System.Drawing.Point(182, 97);
            this.cboCarretera.Name = "cboCarretera";
            this.cboCarretera.Size = new System.Drawing.Size(280, 28);
            this.cboCarretera.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tipo de finalización";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 622);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(85, 622);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtKilometro
            // 
            this.txtKilometro.Location = new System.Drawing.Point(182, 281);
            this.txtKilometro.Name = "txtKilometro";
            this.txtKilometro.Size = new System.Drawing.Size(280, 26);
            this.txtKilometro.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Kilómetro inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tramo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Carretera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 57;
            this.label1.Text = "REGISTRO DE TRAMOS";
            // 
            // cboCarreteraDestino
            // 
            this.cboCarreteraDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarreteraDestino.FormattingEnabled = true;
            this.cboCarreteraDestino.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboCarreteraDestino.Location = new System.Drawing.Point(182, 375);
            this.cboCarreteraDestino.Name = "cboCarreteraDestino";
            this.cboCarreteraDestino.Size = new System.Drawing.Size(280, 28);
            this.cboCarreteraDestino.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Comuna de confluencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tramo de destino";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(182, 563);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(280, 26);
            this.txtObservacion.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "Observación:";
            // 
            // txtKmDestino
            // 
            this.txtKmDestino.Location = new System.Drawing.Point(182, 515);
            this.txtKmDestino.Name = "txtKmDestino";
            this.txtKmDestino.Size = new System.Drawing.Size(280, 26);
            this.txtKmDestino.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 73;
            this.label11.Text = "Kilómetro de destino";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "Carretera de destino";
            // 
            // cboComuna
            // 
            this.cboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComuna.FormattingEnabled = true;
            this.cboComuna.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboComuna.Location = new System.Drawing.Point(182, 234);
            this.cboComuna.Name = "cboComuna";
            this.cboComuna.Size = new System.Drawing.Size(280, 28);
            this.cboComuna.TabIndex = 82;
            // 
            // cboTipoFinalizacion
            // 
            this.cboTipoFinalizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFinalizacion.FormattingEnabled = true;
            this.cboTipoFinalizacion.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboTipoFinalizacion.Location = new System.Drawing.Point(182, 324);
            this.cboTipoFinalizacion.Name = "cboTipoFinalizacion";
            this.cboTipoFinalizacion.Size = new System.Drawing.Size(280, 28);
            this.cboTipoFinalizacion.TabIndex = 83;
            // 
            // cboTramoDestino
            // 
            this.cboTramoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTramoDestino.FormattingEnabled = true;
            this.cboTramoDestino.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboTramoDestino.Location = new System.Drawing.Point(184, 422);
            this.cboTramoDestino.Name = "cboTramoDestino";
            this.cboTramoDestino.Size = new System.Drawing.Size(280, 28);
            this.cboTramoDestino.TabIndex = 84;
            // 
            // cboComunaDestino
            // 
            this.cboComunaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComunaDestino.FormattingEnabled = true;
            this.cboComunaDestino.Items.AddRange(new object[] {
            "Local",
            "Comercial",
            "Nacional",
            "Autovía"});
            this.cboComunaDestino.Location = new System.Drawing.Point(184, 465);
            this.cboComunaDestino.Name = "cboComunaDestino";
            this.cboComunaDestino.Size = new System.Drawing.Size(280, 28);
            this.cboComunaDestino.TabIndex = 85;
            // 
            // frmExtremo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 688);
            this.Controls.Add(this.cboComunaDestino);
            this.Controls.Add(this.cboTramoDestino);
            this.Controls.Add(this.cboTipoFinalizacion);
            this.Controls.Add(this.cboComuna);
            this.Controls.Add(this.cboCarreteraDestino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKmDestino);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTramo);
            this.Controls.Add(this.cboTipoExtremo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCarretera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtKilometro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExtremo";
            this.Text = "frmExtremo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTramo;
        private System.Windows.Forms.ComboBox cboTipoExtremo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCarretera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtKilometro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarreteraDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKmDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboComuna;
        private System.Windows.Forms.ComboBox cboTipoFinalizacion;
        private System.Windows.Forms.ComboBox cboTramoDestino;
        private System.Windows.Forms.ComboBox cboComunaDestino;
    }
}