namespace LibFormularios
{
    partial class FrmRptListaCD_Devueltos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptListaCD_Devueltos));
            this.RvwReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panTop.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.panRight.SuspendLayout();
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
            this.panTop.Size = new System.Drawing.Size(898, 70);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(898, 70);
            this.lblTitulo.Text = "ÁREA DE REPORTES";
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.RvwReporte);
            this.panCenter.Size = new System.Drawing.Size(898, 507);
            // 
            // panRight
            // 
            this.panRight.Location = new System.Drawing.Point(768, 70);
            this.panRight.Size = new System.Drawing.Size(130, 507);
            this.panRight.Visible = false;
            // 
            // RvwReporte
            // 
            this.RvwReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvwReporte.Location = new System.Drawing.Point(0, 0);
            this.RvwReporte.Name = "RvwReporte";
            this.RvwReporte.ServerReport.BearerToken = null;
            this.RvwReporte.Size = new System.Drawing.Size(898, 507);
            this.RvwReporte.TabIndex = 0;
            // 
            // FrmRptListaCD_Devueltos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Name = "FrmRptListaCD_Devueltos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.FrmRptListaCD_Devueltos_Load);
            this.panTop.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvwReporte;
    }
}