namespace SistemaCarreteras.Formularios
{
    partial class frmComunaRecorrida
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
            this.label6 = new System.Windows.Forms.Label();
            this.cboCarretera = new System.Windows.Forms.ComboBox();
            this.txtKmSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtKmEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTramo = new System.Windows.Forms.ComboBox();
            this.cboComuna = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Comuna:";
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
            this.cboCarretera.Location = new System.Drawing.Point(195, 99);
            this.cboCarretera.Name = "cboCarretera";
            this.cboCarretera.Size = new System.Drawing.Size(280, 28);
            this.cboCarretera.TabIndex = 50;
            // 
            // txtKmSalida
            // 
            this.txtKmSalida.Location = new System.Drawing.Point(195, 331);
            this.txtKmSalida.Name = "txtKmSalida";
            this.txtKmSalida.Size = new System.Drawing.Size(280, 26);
            this.txtKmSalida.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Kilómetro final:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtKmEntrada
            // 
            this.txtKmEntrada.Location = new System.Drawing.Point(195, 283);
            this.txtKmEntrada.Name = "txtKmEntrada";
            this.txtKmEntrada.Size = new System.Drawing.Size(280, 26);
            this.txtKmEntrada.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kilómetro inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tramo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Carretera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 40;
            this.label1.Text = "REGISTRO DE TRAMOS";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(195, 233);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(280, 26);
            this.txtOrden.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Orden del recorrido:";
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
            this.cboTramo.Location = new System.Drawing.Point(195, 143);
            this.cboTramo.Name = "cboTramo";
            this.cboTramo.Size = new System.Drawing.Size(280, 28);
            this.cboTramo.TabIndex = 55;
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
            this.cboComuna.Location = new System.Drawing.Point(197, 185);
            this.cboComuna.Name = "cboComuna";
            this.cboComuna.Size = new System.Drawing.Size(280, 28);
            this.cboComuna.TabIndex = 56;
            // 
            // frmComunaRecorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 427);
            this.Controls.Add(this.cboComuna);
            this.Controls.Add(this.cboTramo);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCarretera);
            this.Controls.Add(this.txtKmSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtKmEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComunaRecorrida";
            this.Text = "frmComunaRecorrida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCarretera;
        private System.Windows.Forms.TextBox txtKmSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtKmEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTramo;
        private System.Windows.Forms.ComboBox cboComuna;
    }
}