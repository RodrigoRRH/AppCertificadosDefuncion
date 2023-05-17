namespace LibFormularios
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.cntInicio = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.itmCargarDatos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmActaEntrega2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmActaRecepcion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmCertificadoDefuncion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmReportes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmActaEntrega = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cntInicio
            // 
            this.cntInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntInicio.Location = new System.Drawing.Point(282, 31);
            this.cntInicio.Name = "cntInicio";
            this.cntInicio.Size = new System.Drawing.Size(928, 621);
            this.cntInicio.TabIndex = 0;
            this.cntInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.cntInicio_Paint);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itmCargarDatos,
            this.itmActaEntrega2,
            this.itmActaRecepcion,
            this.itmCertificadoDefuncion,
            this.itmReportes});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(282, 621);
            this.accordionControl1.TabIndex = 1;
            // 
            // itmCargarDatos
            // 
            this.itmCargarDatos.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmCargarDatos.Appearance.Default.Options.UseFont = true;
            this.itmCargarDatos.Appearance.Default.Options.UseTextOptions = true;
            this.itmCargarDatos.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.itmCargarDatos.Appearance.Default.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide;
            this.itmCargarDatos.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.itmCargarDatos.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.itmCargarDatos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itmCargarDatos.ImageOptions.SvgImage")));
            this.itmCargarDatos.Name = "itmCargarDatos";
            this.itmCargarDatos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmCargarDatos.Text = "Cargar Datos";
            this.itmCargarDatos.Click += new System.EventHandler(this.itmCargarDatos_Click);
            // 
            // itmActaEntrega2
            // 
            this.itmActaEntrega2.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmActaEntrega2.Appearance.Default.Options.UseFont = true;
            this.itmActaEntrega2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itmActaEntrega2.ImageOptions.SvgImage")));
            this.itmActaEntrega2.Name = "itmActaEntrega2";
            this.itmActaEntrega2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmActaEntrega2.Text = "Acta Entrega";
            this.itmActaEntrega2.Click += new System.EventHandler(this.itmActaEntrega2_Click);
            // 
            // itmActaRecepcion
            // 
            this.itmActaRecepcion.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmActaRecepcion.Appearance.Default.Options.UseFont = true;
            this.itmActaRecepcion.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.itmActaRecepcion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itmActaRecepcion.ImageOptions.SvgImage")));
            this.itmActaRecepcion.Name = "itmActaRecepcion";
            this.itmActaRecepcion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmActaRecepcion.Text = "Acta Recepción";
            this.itmActaRecepcion.Click += new System.EventHandler(this.itmActaRecepcion_Click);
            // 
            // itmCertificadoDefuncion
            // 
            this.itmCertificadoDefuncion.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmCertificadoDefuncion.Appearance.Default.Options.UseFont = true;
            this.itmCertificadoDefuncion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itmCertificadoDefuncion.ImageOptions.SvgImage")));
            this.itmCertificadoDefuncion.Name = "itmCertificadoDefuncion";
            this.itmCertificadoDefuncion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmCertificadoDefuncion.Text = "Certificado Defunción";
            this.itmCertificadoDefuncion.Click += new System.EventHandler(this.itmCertificadoDefuncion_Click);
            // 
            // itmReportes
            // 
            this.itmReportes.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmReportes.Appearance.Default.Options.UseFont = true;
            this.itmReportes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itmReportes.ImageOptions.SvgImage")));
            this.itmReportes.Name = "itmReportes";
            this.itmReportes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmReportes.Text = "Reportes";
            this.itmReportes.Click += new System.EventHandler(this.itmReportes_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1210, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Cargar Datos";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Cargar Datos";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Cargar Datos";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Cargar Datos";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Cargar Datos";
            // 
            // itmActaEntrega
            // 
            this.itmActaEntrega.Appearance.Default.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmActaEntrega.Appearance.Default.Options.UseFont = true;
            this.itmActaEntrega.Name = "itmActaEntrega";
            this.itmActaEntrega.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmActaEntrega.Text = "Acta de Entrega";
            this.itmActaEntrega.Click += new System.EventHandler(this.itmActaEntrega_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 652);
            this.ControlContainer = this.cntInicio;
            this.Controls.Add(this.cntInicio);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMenu_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer cntInicio;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmCargarDatos;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmActaEntrega;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmActaRecepcion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmActaEntrega2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmCertificadoDefuncion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmReportes;
    }
}