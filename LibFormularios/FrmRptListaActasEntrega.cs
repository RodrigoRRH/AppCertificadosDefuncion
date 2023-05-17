using DevExpress.XtraEditors;
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
using LibClases;

namespace LibFormularios
{
    public partial class FrmRptListaActasEntrega : FrmActa
    {
        public FrmRptListaActasEntrega()
        {
            InitializeComponent();
        }

        private void FrmRptListaActasEntrega_Load(object sender, EventArgs e)
        {
            //-- Generamos la lista de Actas de Entrega
            CMetodos aMetodos = new CMetodos();
            DataTable Resultado = aMetodos.ListaActasEntrega();

            // -- Configurar el origen de datos del reporte
            ReportDataSource rds = new ReportDataSource
            {
                Name = "DsReportes_TListaActasEntrega",
                Value = Resultado
            };
            RvwReporte.LocalReport.DataSources.Clear();
            RvwReporte.LocalReport.DataSources.Add(rds);

            // --Establecer ruta del archivo RDLC
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppCertificadosDefuncion\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\ReportesRDLC\RptLista_ActasEntrega.rdlc";

            // --configurar el report viewer
            RvwReporte.LocalReport.ReportPath = RutaRDLC;
            this.RvwReporte.RefreshReport();
        }
    }
}