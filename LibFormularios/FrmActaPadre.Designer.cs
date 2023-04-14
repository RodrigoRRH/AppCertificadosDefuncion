namespace LibFormularios
{
    partial class FrmActaPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActaPadre));
            this.panTop = new System.Windows.Forms.Panel();
            this.panCenter = new System.Windows.Forms.Panel();
            this.panBot = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panTop.SuspendLayout();
            this.panBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblTitulo);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(724, 88);
            this.panTop.TabIndex = 0;
            // 
            // panCenter
            // 
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 88);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(724, 596);
            this.panCenter.TabIndex = 1;
            // 
            // panBot
            // 
            this.panBot.BackColor = System.Drawing.Color.SteelBlue;
            this.panBot.Controls.Add(this.btnGuardar);
            this.panBot.Controls.Add(this.btnNuevo);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 584);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(724, 100);
            this.panBot.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(724, 88);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TITULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.Location = new System.Drawing.Point(124, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 54);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(423, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 54);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            // 
            // FrmActa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 684);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTop);
            this.Name = "FrmActa";
            this.Text = "FrmActa";
            this.panTop.ResumeLayout(false);
            this.panBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panTop;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panCenter;
        protected System.Windows.Forms.Panel panBot;
        protected DevExpress.XtraEditors.SimpleButton btnGuardar;
        protected DevExpress.XtraEditors.SimpleButton btnNuevo;
    }
}