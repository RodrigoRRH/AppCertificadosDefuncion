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
            this.gboPersonas = new System.Windows.Forms.GroupBox();
            this.rdbPaciente = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.btnLimpiarBD = new System.Windows.Forms.Button();
            this.gboArchivo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarArchivoBD = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResumenPersonas = new System.Windows.Forms.DataGridView();
            this.bgWorker_CargaArchivo = new System.ComponentModel.BackgroundWorker();
            this.btnMostrarResumen = new System.Windows.Forms.Button();
            this.bgWorker_Resumen = new System.ComponentModel.BackgroundWorker();
            this.gboPersonas.SuspendLayout();
            this.gboArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboPersonas
            // 
            this.gboPersonas.Controls.Add(this.rdbPaciente);
            this.gboPersonas.Controls.Add(this.rdbPersonal);
            this.gboPersonas.Location = new System.Drawing.Point(92, 39);
            this.gboPersonas.Name = "gboPersonas";
            this.gboPersonas.Size = new System.Drawing.Size(126, 120);
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
            // btnLimpiarBD
            // 
            this.btnLimpiarBD.Location = new System.Drawing.Point(282, 54);
            this.btnLimpiarBD.Name = "btnLimpiarBD";
            this.btnLimpiarBD.Size = new System.Drawing.Size(98, 41);
            this.btnLimpiarBD.TabIndex = 1;
            this.btnLimpiarBD.Text = "Limpiar BD";
            this.btnLimpiarBD.UseVisualStyleBackColor = true;
            this.btnLimpiarBD.Click += new System.EventHandler(this.btnLimpiarBD_Click);
            // 
            // gboArchivo
            // 
            this.gboArchivo.Controls.Add(this.label2);
            this.gboArchivo.Controls.Add(this.btnCargarArchivoBD);
            this.gboArchivo.Controls.Add(this.btnAbrirArchivo);
            this.gboArchivo.Controls.Add(this.txtRutaArchivo);
            this.gboArchivo.Location = new System.Drawing.Point(38, 165);
            this.gboArchivo.Name = "gboArchivo";
            this.gboArchivo.Size = new System.Drawing.Size(392, 100);
            this.gboArchivo.TabIndex = 2;
            this.gboArchivo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RUTA: ";
            // 
            // btnCargarArchivoBD
            // 
            this.btnCargarArchivoBD.Location = new System.Drawing.Point(206, 20);
            this.btnCargarArchivoBD.Name = "btnCargarArchivoBD";
            this.btnCargarArchivoBD.Size = new System.Drawing.Size(151, 38);
            this.btnCargarArchivoBD.TabIndex = 3;
            this.btnCargarArchivoBD.Text = "Cargar Archivo a la \r\nBase de Datos";
            this.btnCargarArchivoBD.UseVisualStyleBackColor = true;
            this.btnCargarArchivoBD.Click += new System.EventHandler(this.btnCargarArchivoBD_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(69, 20);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(120, 38);
            this.btnAbrirArchivo.TabIndex = 2;
            this.btnAbrirArchivo.Text = "Seleccionar Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(69, 64);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(288, 21);
            this.txtRutaArchivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CARGAR DATOS";
            // 
            // dgvResumenPersonas
            // 
            this.dgvResumenPersonas.AllowUserToAddRows = false;
            this.dgvResumenPersonas.AllowUserToDeleteRows = false;
            this.dgvResumenPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPersonas.Location = new System.Drawing.Point(38, 280);
            this.dgvResumenPersonas.Name = "dgvResumenPersonas";
            this.dgvResumenPersonas.ReadOnly = true;
            this.dgvResumenPersonas.Size = new System.Drawing.Size(392, 150);
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
            // btnMostrarResumen
            // 
            this.btnMostrarResumen.Location = new System.Drawing.Point(282, 113);
            this.btnMostrarResumen.Name = "btnMostrarResumen";
            this.btnMostrarResumen.Size = new System.Drawing.Size(98, 41);
            this.btnMostrarResumen.TabIndex = 5;
            this.btnMostrarResumen.Text = "Mostrar Resumen";
            this.btnMostrarResumen.UseVisualStyleBackColor = true;
            this.btnMostrarResumen.Click += new System.EventHandler(this.btnMostrarResumen_Click);
            // 
            // bgWorker_Resumen
            // 
            this.bgWorker_Resumen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_Resumen_DoWork);
            this.bgWorker_Resumen.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_Resumen_RunWorkerCompleted);
            // 
            // FrmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 461);
            this.Controls.Add(this.btnMostrarResumen);
            this.Controls.Add(this.dgvResumenPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboArchivo);
            this.Controls.Add(this.btnLimpiarBD);
            this.Controls.Add(this.gboPersonas);
            this.Name = "FrmCargarDatos";
            this.Text = "FrmCargarDatos";
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
        private System.Windows.Forms.Button btnLimpiarBD;
        private System.Windows.Forms.GroupBox gboArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarArchivoBD;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResumenPersonas;
        private System.ComponentModel.BackgroundWorker bgWorker_CargaArchivo;
        private System.Windows.Forms.Button btnMostrarResumen;
        private System.ComponentModel.BackgroundWorker bgWorker_Resumen;
    }
}