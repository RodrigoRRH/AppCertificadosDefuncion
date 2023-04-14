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
    public partial class FrmCargarPersonal : DevExpress.XtraEditors.XtraForm
    {
        CConexion aConexion = new CConexion();
        public FrmCargarPersonal()
        {
            InitializeComponent();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            string RutaArchivo = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RutaArchivo = ofd.FileName;
            }

            txtRutaArchivo.Text = RutaArchivo;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRutaArchivo.Text is null)
                {
                    MessageBox.Show("No hay ruta", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string ruta = txtRutaArchivo.Text;
                    string mensaje = aConexion.SP_CargarPersonas("sp_personal_csv", ruta);
                    aConexion.MostrarMensajeOK(mensaje, "RED NORTE - ESTADISTICA");
                    //aNominal.MostrarMensajeOK(mensaje, "RED NORTE");
                    //CargarResumenes();
                    this.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}