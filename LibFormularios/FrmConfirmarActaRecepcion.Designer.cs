namespace LibFormularios
{
    partial class FrmConfirmarActaRecepcion
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
            this.txtCodigoActa = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPersonalSalud = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.txtMicroRed = new System.Windows.Forms.TextBox();
            this.txtCodigosCD = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigoActa
            // 
            this.txtCodigoActa.Location = new System.Drawing.Point(200, 71);
            this.txtCodigoActa.Name = "txtCodigoActa";
            this.txtCodigoActa.ReadOnly = true;
            this.txtCodigoActa.Size = new System.Drawing.Size(278, 21);
            this.txtCodigoActa.TabIndex = 21;
            this.txtCodigoActa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpHora
            // 
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(316, 330);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(95, 21);
            this.dtpHora.TabIndex = 20;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(316, 294);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(278, 21);
            this.dtpFecha.TabIndex = 19;
            // 
            // txtPersonalSalud
            // 
            this.txtPersonalSalud.Location = new System.Drawing.Point(316, 407);
            this.txtPersonalSalud.Name = "txtPersonalSalud";
            this.txtPersonalSalud.ReadOnly = true;
            this.txtPersonalSalud.Size = new System.Drawing.Size(278, 21);
            this.txtPersonalSalud.TabIndex = 18;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(316, 369);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.ReadOnly = true;
            this.txtEncargado.Size = new System.Drawing.Size(278, 21);
            this.txtEncargado.TabIndex = 17;
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(316, 252);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.ReadOnly = true;
            this.txtEstablecimiento.Size = new System.Drawing.Size(278, 21);
            this.txtEstablecimiento.TabIndex = 16;
            // 
            // txtMicroRed
            // 
            this.txtMicroRed.Location = new System.Drawing.Point(316, 211);
            this.txtMicroRed.Name = "txtMicroRed";
            this.txtMicroRed.ReadOnly = true;
            this.txtMicroRed.Size = new System.Drawing.Size(278, 21);
            this.txtMicroRed.TabIndex = 15;
            // 
            // txtCodigosCD
            // 
            this.txtCodigosCD.Location = new System.Drawing.Point(316, 144);
            this.txtCodigosCD.Multiline = true;
            this.txtCodigosCD.Name = "txtCodigosCD";
            this.txtCodigosCD.ReadOnly = true;
            this.txtCodigosCD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigosCD.Size = new System.Drawing.Size(278, 52);
            this.txtCodigosCD.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(236, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 37);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "ACTA DE RECEPCION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 323);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "\r\n\r\nSe entrega certificados de defunción manual con números: \r\n\r\n\r\n\r\n\r\nPara la Mi" +
    "crored:\r\n\r\n\r\nPara el Establecimiento de Salud:\r\n\r\n\r\nFecha:\r\n\r\n\r\nHora:\r\n\r\n\r\nEncar" +
    "gado:\r\n\r\n\r\nPersonal Salud:";
            // 
            // FrmConfirmarActaRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 497);
            this.Controls.Add(this.txtCodigoActa);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPersonalSalud);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtEstablecimiento);
            this.Controls.Add(this.txtMicroRed);
            this.Controls.Add(this.txtCodigosCD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmConfirmarActaRecepcion";
            this.Text = "FrmConfirmarActaRecepcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodigoActa;
        public System.Windows.Forms.DateTimePicker dtpHora;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtPersonalSalud;
        public System.Windows.Forms.TextBox txtEncargado;
        public System.Windows.Forms.TextBox txtEstablecimiento;
        public System.Windows.Forms.TextBox txtMicroRed;
        public System.Windows.Forms.TextBox txtCodigosCD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}