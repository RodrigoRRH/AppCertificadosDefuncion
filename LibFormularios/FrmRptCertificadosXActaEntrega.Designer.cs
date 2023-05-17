namespace LibFormularios
{
    partial class FrmRptCertificadosXActaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptCertificadosXActaEntrega));
            this.RvwReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoActaEntrega = new System.Windows.Forms.TextBox();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panTop.Size = new System.Drawing.Size(841, 110);
            this.panTop.Controls.SetChildIndex(this.lblTitulo, 0);
            this.panTop.Controls.SetChildIndex(this.panel1, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(841, 110);
            this.lblTitulo.Text = "ÁREA DE REPORTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.RvwReporte);
            this.panCenter.Location = new System.Drawing.Point(0, 110);
            this.panCenter.Size = new System.Drawing.Size(841, 413);
            // 
            // panRight
            // 
            this.panRight.Location = new System.Drawing.Point(711, 110);
            this.panRight.Size = new System.Drawing.Size(130, 413);
            this.panRight.Visible = false;
            // 
            // RvwReporte
            // 
            this.RvwReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvwReporte.Location = new System.Drawing.Point(0, 0);
            this.RvwReporte.Name = "RvwReporte";
            this.RvwReporte.ServerReport.BearerToken = null;
            this.RvwReporte.Size = new System.Drawing.Size(841, 413);
            this.RvwReporte.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(126, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código de Acta:";
            // 
            // txtCodigoActaEntrega
            // 
            this.txtCodigoActaEntrega.Location = new System.Drawing.Point(284, 19);
            this.txtCodigoActaEntrega.Name = "txtCodigoActaEntrega";
            this.txtCodigoActaEntrega.Size = new System.Drawing.Size(217, 21);
            this.txtCodigoActaEntrega.TabIndex = 2;
            this.txtCodigoActaEntrega.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscar.ImageOptions.SvgImage")));
            this.btnBuscar.Location = new System.Drawing.Point(536, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 39);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtCodigoActaEntrega);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 73);
            this.panel1.TabIndex = 1;
            // 
            // FrmRptCertificadosXActaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 523);
            this.Name = "FrmRptCertificadosXActaEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.FrmRptCertificadosXActaEntrega_Load);
            this.panTop.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvwReporte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtCodigoActaEntrega;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}