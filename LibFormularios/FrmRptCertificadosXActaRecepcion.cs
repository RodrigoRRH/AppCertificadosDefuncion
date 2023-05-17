using DevExpress.XtraEditors;
using LibClases;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmRptCertificadosXActaRecepcion : FrmActa
    {
        public FrmRptCertificadosXActaRecepcion()
        {
            InitializeComponent();
        }

        private void FrmRptCertificadosXActaRecepcion_Load(object sender, EventArgs e)
        {

            this.RvwReporte.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string CodigoActaRecepcion = txtCodigoRecepcion.Text;
            //-- Generamos la lista de Actas de Entrega
            CMetodos aMetodos = new CMetodos();
            DataTable Resultado = aMetodos.CertificadosXActaRecepcion(CodigoActaRecepcion);

            // -- Configurar el origen de datos del reporte
            ReportDataSource rds = new ReportDataSource
            {
                Name = "DsReportes_TCD_XActaRecepcion",
                Value = Resultado
            };
            RvwReporte.LocalReport.DataSources.Clear();
            RvwReporte.LocalReport.DataSources.Add(rds);

            // --Establecer ruta del archivo RDLC
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppCertificadosDefuncion\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\ReportesRDLC\RptCD_XActaRecepcion.rdlc";

            // --configurar el report viewer
            RvwReporte.LocalReport.ReportPath = RutaRDLC;
            this.RvwReporte.RefreshReport();
        }
    }
}