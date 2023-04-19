﻿namespace LibFormularios
{
    partial class FrmActaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActaEntrega));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoActa = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.gboEncargado = new System.Windows.Forms.GroupBox();
            this.btnBuscarEncargado = new DevExpress.XtraEditors.SimpleButton();
            this.txtApellidosEncargado = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombresEncargado = new System.Windows.Forms.TextBox();
            this.txtDocumentoEncargado = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPersonal = new DevExpress.XtraEditors.SimpleButton();
            this.txtApellidosPersonal = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombresPersonal = new System.Windows.Forms.TextBox();
            this.txtDocumentoPersonal = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cboMicroRed = new System.Windows.Forms.ComboBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.panTop.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.panRight.SuspendLayout();
            this.gboEncargado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panTop
            // 
            this.panTop.Size = new System.Drawing.Size(924, 70);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(924, 70);
            this.lblTitulo.Text = "ACTA DE ENTREGA";
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.cboEstablecimiento);
            this.panCenter.Controls.Add(this.cboMicroRed);
            this.panCenter.Controls.Add(this.groupBox1);
            this.panCenter.Controls.Add(this.gboEncargado);
            this.panCenter.Controls.Add(this.dtpHora);
            this.panCenter.Controls.Add(this.labelControl3);
            this.panCenter.Controls.Add(this.dtpFecha);
            this.panCenter.Controls.Add(this.labelControl2);
            this.panCenter.Controls.Add(this.txtCodigoActa);
            this.panCenter.Controls.Add(this.labelControl1);
            this.panCenter.Size = new System.Drawing.Size(924, 576);
            // 
            // panRight
            // 
            this.panRight.Controls.Add(this.btnTest);
            this.panRight.Location = new System.Drawing.Point(794, 70);
            this.panRight.Size = new System.Drawing.Size(130, 576);
            this.panRight.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panRight.Controls.SetChildIndex(this.btnTest, 0);
            this.panRight.Controls.SetChildIndex(this.btnGuardar, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código: ";
            // 
            // txtCodigoActa
            // 
            this.txtCodigoActa.Location = new System.Drawing.Point(104, 41);
            this.txtCodigoActa.Name = "txtCodigoActa";
            this.txtCodigoActa.Size = new System.Drawing.Size(133, 21);
            this.txtCodigoActa.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(251, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(314, 41);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(559, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hora: ";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(618, 41);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(87, 21);
            this.dtpHora.TabIndex = 5;
            // 
            // gboEncargado
            // 
            this.gboEncargado.Controls.Add(this.btnBuscarEncargado);
            this.gboEncargado.Controls.Add(this.txtApellidosEncargado);
            this.gboEncargado.Controls.Add(this.labelControl6);
            this.gboEncargado.Controls.Add(this.txtNombresEncargado);
            this.gboEncargado.Controls.Add(this.txtDocumentoEncargado);
            this.gboEncargado.Controls.Add(this.labelControl5);
            this.gboEncargado.Controls.Add(this.labelControl4);
            this.gboEncargado.Location = new System.Drawing.Point(31, 113);
            this.gboEncargado.Name = "gboEncargado";
            this.gboEncargado.Size = new System.Drawing.Size(332, 140);
            this.gboEncargado.TabIndex = 6;
            this.gboEncargado.TabStop = false;
            this.gboEncargado.Text = "Datos Encargado";
            // 
            // btnBuscarEncargado
            // 
            this.btnBuscarEncargado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscarEncargado.ImageOptions.SvgImage")));
            this.btnBuscarEncargado.Location = new System.Drawing.Point(267, 10);
            this.btnBuscarEncargado.Name = "btnBuscarEncargado";
            this.btnBuscarEncargado.Size = new System.Drawing.Size(40, 41);
            this.btnBuscarEncargado.TabIndex = 9;
            this.btnBuscarEncargado.Click += new System.EventHandler(this.btnBuscarEncargado_Click);
            // 
            // txtApellidosEncargado
            // 
            this.txtApellidosEncargado.Location = new System.Drawing.Point(73, 89);
            this.txtApellidosEncargado.Name = "txtApellidosEncargado";
            this.txtApellidosEncargado.Size = new System.Drawing.Size(234, 21);
            this.txtApellidosEncargado.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Apellidos: ";
            // 
            // txtNombresEncargado
            // 
            this.txtNombresEncargado.Location = new System.Drawing.Point(73, 57);
            this.txtNombresEncargado.Name = "txtNombresEncargado";
            this.txtNombresEncargado.Size = new System.Drawing.Size(234, 21);
            this.txtNombresEncargado.TabIndex = 11;
            // 
            // txtDocumentoEncargado
            // 
            this.txtDocumentoEncargado.Location = new System.Drawing.Point(73, 27);
            this.txtDocumentoEncargado.Name = "txtDocumentoEncargado";
            this.txtDocumentoEncargado.Size = new System.Drawing.Size(183, 21);
            this.txtDocumentoEncargado.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nombres: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Documento: ";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(31, 354);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPersonal);
            this.groupBox1.Controls.Add(this.txtApellidosPersonal);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtNombresPersonal);
            this.groupBox1.Controls.Add(this.txtDocumentoPersonal);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Location = new System.Drawing.Point(410, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personal Salud";
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscarPersonal.ImageOptions.SvgImage")));
            this.btnBuscarPersonal.Location = new System.Drawing.Point(267, 10);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(40, 41);
            this.btnBuscarPersonal.TabIndex = 9;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // txtApellidosPersonal
            // 
            this.txtApellidosPersonal.Location = new System.Drawing.Point(73, 89);
            this.txtApellidosPersonal.Name = "txtApellidosPersonal";
            this.txtApellidosPersonal.Size = new System.Drawing.Size(234, 21);
            this.txtApellidosPersonal.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 92);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Apellidos: ";
            // 
            // txtNombresPersonal
            // 
            this.txtNombresPersonal.Location = new System.Drawing.Point(73, 57);
            this.txtNombresPersonal.Name = "txtNombresPersonal";
            this.txtNombresPersonal.Size = new System.Drawing.Size(234, 21);
            this.txtNombresPersonal.TabIndex = 11;
            // 
            // txtDocumentoPersonal
            // 
            this.txtDocumentoPersonal.Location = new System.Drawing.Point(73, 27);
            this.txtDocumentoPersonal.Name = "txtDocumentoPersonal";
            this.txtDocumentoPersonal.Size = new System.Drawing.Size(183, 21);
            this.txtDocumentoPersonal.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Nombres: ";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 13);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Documento: ";
            // 
            // cboMicroRed
            // 
            this.cboMicroRed.FormattingEnabled = true;
            this.cboMicroRed.Location = new System.Drawing.Point(104, 280);
            this.cboMicroRed.Name = "cboMicroRed";
            this.cboMicroRed.Size = new System.Drawing.Size(121, 21);
            this.cboMicroRed.TabIndex = 10;
            this.cboMicroRed.SelectedIndexChanged += new System.EventHandler(this.cboMicroRed_SelectedIndexChanged);
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(548, 280);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(121, 21);
            this.cboEstablecimiento.TabIndex = 11;
            // 
            // FrmActaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 646);
            this.Name = "FrmActaEntrega";
            this.Text = "FrmActaEntrega";
            this.panTop.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.panCenter.PerformLayout();
            this.panRight.ResumeLayout(false);
            this.gboEncargado.ResumeLayout(false);
            this.gboEncargado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTest;
        private System.Windows.Forms.GroupBox gboEncargado;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtCodigoActa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnBuscarPersonal;
        private System.Windows.Forms.TextBox txtApellidosPersonal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtNombresPersonal;
        private System.Windows.Forms.TextBox txtDocumentoPersonal;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnBuscarEncargado;
        private System.Windows.Forms.TextBox txtApellidosEncargado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtNombresEncargado;
        private System.Windows.Forms.TextBox txtDocumentoEncargado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.ComboBox cboMicroRed;
    }
}