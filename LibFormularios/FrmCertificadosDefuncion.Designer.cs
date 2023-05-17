namespace LibFormularios
{
    partial class FrmCertificadosDefuncion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertificadosDefuncion));
            this.dgvListaCertificados = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCertificados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCertificados
            // 
            this.dgvListaCertificados.AllowUserToAddRows = false;
            this.dgvListaCertificados.AllowUserToDeleteRows = false;
            this.dgvListaCertificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCertificados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCertificados.Location = new System.Drawing.Point(63, 121);
            this.dgvListaCertificados.Name = "dgvListaCertificados";
            this.dgvListaCertificados.ReadOnly = true;
            this.dgvListaCertificados.Size = new System.Drawing.Size(736, 207);
            this.dgvListaCertificados.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.Location = new System.Drawing.Point(164, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(483, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "LISTA DE LOS CERTIFICADOS DE DEFUNCIÓN";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditar.ImageOptions.SvgImage")));
            this.btnEditar.Location = new System.Drawing.Point(389, 359);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 48);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = " Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmCertificadosDefuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 442);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvListaCertificados);
            this.Name = "FrmCertificadosDefuncion";
            this.Text = "CERTIFICADOS DE DEFUNCION";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCertificados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        public System.Windows.Forms.DataGridView dgvListaCertificados;
    }
}