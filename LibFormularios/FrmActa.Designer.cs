namespace LibFormularios
{
    partial class FrmActa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActa));
            this.panTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panCenter = new System.Windows.Forms.Panel();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panRight = new System.Windows.Forms.Panel();
            this.panTop.SuspendLayout();
            this.panRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblTitulo);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(973, 70);
            this.panTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(973, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TITULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCenter
            // 
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 70);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(973, 590);
            this.panCenter.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.Location = new System.Drawing.Point(0, 47);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 71);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(0, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 70);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.SteelBlue;
            this.panRight.Controls.Add(this.btnGuardar);
            this.panRight.Controls.Add(this.btnNuevo);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(843, 70);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(130, 590);
            this.panRight.TabIndex = 0;
            // 
            // FrmActa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(973, 660);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTop);
            this.Name = "FrmActa";
            this.Text = "FrmActa";
            this.panTop.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton btnGuardar;
        protected DevExpress.XtraEditors.SimpleButton btnNuevo;
        protected System.Windows.Forms.Panel panTop;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panCenter;
        protected System.Windows.Forms.Panel panRight;
    }
}