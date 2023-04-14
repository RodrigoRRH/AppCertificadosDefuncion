using DevExpress.XtraEditors;
using LibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmCargarDatos : DevExpress.XtraEditors.XtraForm
    {
        CConexion aConexion = new CConexion();
        DataTable dt = new DataTable();
        public FrmCargarDatos()
        {
            InitializeComponent();
            //bgWorker_Resumen.RunWorkerAsync();
            //CargarResumen();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            string RutaArchivo = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RutaArchivo = ofd.FileName;
            }

            txtRutaArchivo.Text = RutaArchivo;
        }

        private void btnCargarArchivoBD_Click(object sender, EventArgs e)
        {
            if (txtRutaArchivo.Text is null)
            {
                aConexion.MostrarMensajeOK("No hay ruta, escoga una", "RED NORTE - ESTADISTICA");
            }
            else
            {
                if (!bgWorker_CargaArchivo.IsBusy)
                {
                    bgWorker_CargaArchivo.RunWorkerAsync();
                }
                else
                {
                    aConexion.MostrarMensajeOK("Se está cargando el archivo... ", "ALERTA!");
                }
            }
            
        }

        private void btnLimpiarBD_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "Seguro que quiere borrar las tablas de la BD!";
                string titulo = "¡ALERTA!";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado;

                resultado = MessageBox.Show(this, mensaje, titulo, botones, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    string msgBorrado = aConexion.SP_Mensaje("sp_limpiar_datos");
                    aConexion.MostrarMensajeOK(msgBorrado, "RED NORTE - ESTADISTICA");
                    CargarResumen();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarResumen()
        {
            dgvResumenPersonas.DataSource = aConexion.EjecutarSelect("sp_ResumenPersonas").Tables[0];
        }

        // -- Hilo para la carga de archivos
        string ruta, mensaje;

        private void bgWorker_CargaArchivo_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgWorker_CargaArchivo.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    if (rdbPersonal.Checked)
                    {
                        //ruta = "";
                        ruta = txtRutaArchivo.Text;
                        mensaje = aConexion.SP_CargarPersonas("sp_personal_csv", ruta);
                        //aConexion.MostrarMensajeOK(mensaje, "RED NORTE - ESTADISTICA");
                        //CargarResumen();
                    }
                    if (rdbPaciente.Checked)
                    {
                        ruta = txtRutaArchivo.Text;
                        mensaje = aConexion.SP_CargarPersonas("sp_paciente_csv", ruta);
                        //aConexion.MostrarMensajeOK(mensaje, "RED NORTE - ESTADISTICA");
                        //CargarResumen();
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void bgWorker_CargaArchivo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MessageBox.Show("Procesando...espere porfavor", "Mensaje");
        }
        private void bgWorker_CargaArchivo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                bgWorker_CargaArchivo.CancelAsync();
            }
            else
            {
                aConexion.MostrarMensajeOK(mensaje, "RED NORTE - ESTADISTICA");
                CargarResumen();
            }
        }
        // ---------------------------------------------------------------------------------

        // -- Evento de click al boton mostrar resumen
        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {
            if (!bgWorker_Resumen.IsBusy)
            {
                bgWorker_Resumen.RunWorkerAsync();
            }
            else
            {
                aConexion.MostrarMensajeOK("Se está cargando la tabla de resumen... ", "ALERTA!");
            }
            //CargarResumen();
        }

        

        // -- Hilo para mostrar el resumen
        private void bgWorker_Resumen_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = aConexion.EjecutarSelect("sp_ResumenPersonas").Tables[0];
        }

        private void bgWorker_Resumen_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvResumenPersonas.DataSource = dt;
        }

    }
}