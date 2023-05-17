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
    public partial class FrmRptListaActasRecepcion : FrmActa
    {
        public FrmRptListaActasRecepcion()
        {
            InitializeComponent();
        }

        private void FrmRptListaActasRecepcion_Load(object sender, EventArgs e)
        {
            //-- Generamos la lista de Actas de Recepcion
            CMetodos aMetodos = new CMetodos();
            DataTable Resultado = aMetodos.ListaActasRecepcion();

            // -- Configurar el origen de datos del reporte
            ReportDataSource rds = new ReportDataSource
            {
                Name = "DsReportes_TListaActasRecepcion",
                Value = Resultado
            };
            RvwReporte.LocalReport.DataSources.Clear();
            RvwReporte.LocalReport.DataSources.Add(rds);

            // --Establecer ruta del archivo RDLC
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppCertificadosDefuncion\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\ReportesRDLC\RptLista_ActasRecepcion.rdlc";

            // --configurar el report viewer
            RvwReporte.LocalReport.ReportPath = RutaRDLC;
            this.RvwReporte.RefreshReport();
        }
    }
}