namespace LibFormularios
{
    partial class FrmRptCertificadosXActaRecepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptCertificadosXActaRecepcion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoRecepcion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.RvwReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panTop.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.panRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.panel1);
            this.panTop.Size = new System.Drawing.Size(844, 119);
            this.panTop.Controls.SetChildIndex(this.lblTitulo, 0);
            this.panTop.Controls.SetChildIndex(this.panel1, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(844, 119);
            this.lblTitulo.Text = "ÁREA DE REPORTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.RvwReporte);
            this.panCenter.Location = new System.Drawing.Point(0, 119);
            this.panCenter.Size = new System.Drawing.Size(844, 453);
            // 
            // panRight
            // 
            this.panRight.Location = new System.Drawing.Point(714, 119);
            this.panRight.Size = new System.Drawing.Size(130, 453);
            this.panRight.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtCodigoRecepcion);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 70);
            this.panel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(167, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 29);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Código de Acta:";
            // 
            // txtCodigoRecepcion
            // 
            this.txtCodigoRecepcion.Location = new System.Drawing.Point(310, 22);
            this.txtCodigoRecepcion.Name = "txtCodigoRecepcion";
            this.txtCodigoRecepcion.Size = new System.Drawing.Size(217, 21);
            this.txtCodigoRecepcion.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscar.ImageOptions.SvgImage")));
            this.btnBuscar.Location = new System.Drawing.Point(568, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 39);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RvwReporte
            // 
            this.RvwReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvwReporte.Location = new System.Drawing.Point(0, 0);
            this.RvwReporte.Name = "RvwReporte";
            this.RvwReporte.ServerReport.BearerToken = null;
            this.RvwReporte.Size = new System.Drawing.Size(844, 453);
            this.RvwReporte.TabIndex = 0;
            // 
            // FrmRptCertificadosXActaRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 572);
            this.Name = "FrmRptCertificadosXActaRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.FrmRptCertificadosXActaRecepcion_Load);
            this.panTop.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtCodigoRecepcion;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer RvwReporte;
    }
}