namespace LibFormularios
{
    partial class FrmConfirmartTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigosCD = new System.Windows.Forms.TextBox();
            this.txtMicroRed = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtPersonalSalud = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 302);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n\r\nSe entrega certificados de defunción manual con números: \r\n\r\n\r\nPara la Micror" +
    "ed:\r\n\r\n\r\nPara el Establecimiento de Salud:\r\n\r\n\r\nFecha:\r\n\r\n\r\nHora:\r\n\r\n\r\nEncargado" +
    ":\r\n\r\n\r\nPersonal Salud:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(287, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ACTA DE ENTREGA";
            // 
            // txtCodigosCD
            // 
            this.txtCodigosCD.Location = new System.Drawing.Point(340, 140);
            this.txtCodigosCD.Name = "txtCodigosCD";
            this.txtCodigosCD.Size = new System.Drawing.Size(218, 21);
            this.txtCodigosCD.TabIndex = 2;
            // 
            // txtMicroRed
            // 
            this.txtMicroRed.Location = new System.Drawing.Point(340, 182);
            this.txtMicroRed.Name = "txtMicroRed";
            this.txtMicroRed.Size = new System.Drawing.Size(218, 21);
            this.txtMicroRed.TabIndex = 3;
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(340, 221);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(218, 21);
            this.txtEstablecimiento.TabIndex = 4;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(340, 340);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(218, 21);
            this.txtEncargado.TabIndex = 5;
            // 
            // txtPersonalSalud
            // 
            this.txtPersonalSalud.Location = new System.Drawing.Point(340, 379);
            this.txtPersonalSalud.Name = "txtPersonalSalud";
            this.txtPersonalSalud.Size = new System.Drawing.Size(218, 21);
            this.txtPersonalSalud.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(340, 260);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 21);
            this.dtpFecha.TabIndex = 7;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(340, 301);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 21);
            this.dtpHora.TabIndex = 8;
            // 
            // FrmConfirmartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 514);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPersonalSalud);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtEstablecimiento);
            this.Controls.Add(this.txtMicroRed);
            this.Controls.Add(this.txtCodigosCD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmConfirmartTest";
            this.Text = "FrmConfirmartTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.TextBox txtCodigosCD;
        public System.Windows.Forms.TextBox txtMicroRed;
        public System.Windows.Forms.TextBox txtEstablecimiento;
        public System.Windows.Forms.TextBox txtEncargado;
        public System.Windows.Forms.TextBox txtPersonalSalud;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.DateTimePicker dtpHora;
    }
}