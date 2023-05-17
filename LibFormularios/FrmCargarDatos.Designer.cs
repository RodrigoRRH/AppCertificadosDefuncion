namespace LibFormularios
{
    partial class FrmCargarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarDatos));
            this.gboPersonas = new System.Windows.Forms.GroupBox();
            this.rdbPaciente = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.gboArchivo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResumenPersonas = new System.Windows.Forms.DataGridView();
            this.bgWorker_CargaArchivo = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_Resumen = new System.ComponentModel.BackgroundWorker();
            this.btnLimpiarBaseDatos = new DevExpress.XtraEditors.SimpleButton();
            this.btnArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.btnResumen = new DevExpress.XtraEditors.SimpleButton();
            this.gboPersonas.SuspendLayout();
            this.gboArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboPersonas
            // 
            this.gboPersonas.Controls.Add(this.rdbPaciente);
            this.gboPersonas.Controls.Add(this.rdbPersonal);
            this.gboPersonas.Location = new System.Drawing.Point(114, 62);
            this.gboPersonas.Name = "gboPersonas";
            this.gboPersonas.Size = new System.Drawing.Size(135, 120);
            this.gboPersonas.TabIndex = 0;
            this.gboPersonas.TabStop = false;
            // 
            // rdbPaciente
            // 
            this.rdbPaciente.AutoSize = true;
            this.rdbPaciente.Location = new System.Drawing.Point(25, 74);
            this.rdbPaciente.Name = "rdbPaciente";
            this.rdbPaciente.Size = new System.Drawing.Size(66, 17);
            this.rdbPaciente.TabIndex = 1;
            this.rdbPaciente.TabStop = true;
            this.rdbPaciente.Text = "Paciente";
            this.rdbPaciente.UseVisualStyleBackColor = true;
            // 
            // rdbPersonal
            // 
            this.rdbPersonal.AutoSize = true;
            this.rdbPersonal.Location = new System.Drawing.Point(25, 39);
            this.rdbPersonal.Name = "rdbPersonal";
            this.rdbPersonal.Size = new System.Drawing.Size(66, 17);
            this.rdbPersonal.TabIndex = 0;
            this.rdbPersonal.TabStop = true;
            this.rdbPersonal.Text = "Personal";
            this.rdbPersonal.UseVisualStyleBackColor = true;
            // 
            // gboArchivo
            // 
            this.gboArchivo.Controls.Add(this.btnCargar);
            this.gboArchivo.Controls.Add(this.label2);
            this.gboArchivo.Controls.Add(this.btnArchivo);
            this.gboArchivo.Controls.Add(this.txtRutaArchivo);
            this.gboArchivo.Location = new System.Drawing.Point(38, 188);
            this.gboArchivo.Name = "gboArchivo";
            this.gboArchivo.Size = new System.Drawing.Size(437, 119);
            this.gboArchivo.TabIndex = 2;
            this.gboArchivo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RUTA: ";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(69, 78);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(336, 21);
            this.txtRutaArchivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "CARGAR DATOS";
            // 
            // dgvResumenPersonas
            // 
            this.dgvResumenPersonas.AllowUserToAddRows = false;
            this.dgvResumenPersonas.AllowUserToDeleteRows = false;
            this.dgvResumenPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPersonas.Location = new System.Drawing.Point(139, 324);
            this.dgvResumenPersonas.Name = "dgvResumenPersonas";
            this.dgvResumenPersonas.ReadOnly = true;
            this.dgvResumenPersonas.Size = new System.Drawing.Size(281, 110);
            this.dgvResumenPersonas.TabIndex = 4;
            // 
            // bgWorker_CargaArchivo
            // 
            this.bgWorker_CargaArchivo.WorkerReportsProgress = true;
            this.bgWorker_CargaArchivo.WorkerSupportsCancellation = true;
            this.bgWorker_CargaArchivo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_CargaArchivo_DoWork);
            this.bgWorker_CargaArchivo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_CargaArchivo_ProgressChanged);
            this.bgWorker_CargaArchivo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_CargaArchivo_RunWorkerCompleted);
            // 
            // bgWorker_Resumen
            // 
            this.bgWorker_Resumen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_Resumen_DoWork);
            this.bgWorker_Resumen.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_Resumen_RunWorkerCompleted);
            // 
            // btnLimpiarBaseDatos
            // 
            this.btnLimpiarBaseDatos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLimpiarBaseDatos.ImageOptions.SvgImage")));
            this.btnLimpiarBaseDatos.Location = new System.Drawing.Point(312, 65);
            this.btnLimpiarBaseDatos.Name = "btnLimpiarBaseDatos";
            this.btnLimpiarBaseDatos.Size = new System.Drawing.Size(163, 53);
            this.btnLimpiarBaseDatos.TabIndex = 6;
            this.btnLimpiarBaseDatos.Text = "Limpiar Tablas";
            this.btnLimpiarBaseDatos.Click += new System.EventHandler(this.btnLimpiarBaseDatos_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArchivo.ImageOptions.SvgImage")));
            this.btnArchivo.Location = new System.Drawing.Point(69, 24);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(152, 40);
            this.btnArchivo.TabIndex = 8;
            this.btnArchivo.Text = "Seleccionar Archivo";
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCargar.ImageOptions.SvgImage")));
            this.btnCargar.Location = new System.Drawing.Point(257, 15);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(148, 49);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar Archivo A\r\nLa Base de Datos";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnResumen.Location = new System.Drawing.Point(312, 136);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(163, 46);
            this.btnResumen.TabIndex = 7;
            this.btnResumen.Text = "Mostrar Resumen";
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // FrmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 502);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnLimpiarBaseDatos);
            this.Controls.Add(this.dgvResumenPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboArchivo);
            this.Controls.Add(this.gboPersonas);
            this.Name = "FrmCargarDatos";
            this.Text = "CARGAR DATOS";
            this.gboPersonas.ResumeLayout(false);
            this.gboPersonas.PerformLayout();
            this.gboArchivo.ResumeLayout(false);
            this.gboArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboPersonas;
        private System.Windows.Forms.RadioButton rdbPaciente;
        private System.Windows.Forms.RadioButton rdbPersonal;
        private System.Windows.Forms.GroupBox gboArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResumenPersonas;
        private System.ComponentModel.BackgroundWorker bgWorker_CargaArchivo;
        private System.ComponentModel.BackgroundWorker bgWorker_Resumen;
        private DevExpress.XtraEditors.SimpleButton btnLimpiarBaseDatos;
        private DevExpress.XtraEditors.SimpleButton btnArchivo;
        private DevExpress.XtraEditors.SimpleButton btnCargar;
        private DevExpress.XtraEditors.SimpleButton btnResumen;
    }
}