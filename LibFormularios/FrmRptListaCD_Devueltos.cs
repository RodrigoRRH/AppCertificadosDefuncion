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
    public partial class FrmRptListaCD_Devueltos : FrmActa
    {
        public FrmRptListaCD_Devueltos()
        {
            InitializeComponent();
        }

        private void FrmRptListaCD_Devueltos_Load(object sender, EventArgs e)
        {
            //-- Generamos la lista de Certificados de Defuncion Devueltas
            CMetodos aMetodos = new CMetodos();
            DataTable Resultado = aMetodos.ListaCD_Devueltos();

            // -- Configurar el origen de datos del reporte
            ReportDataSource rds = new ReportDataSource
            {
                Name = "DsReportes_TLista_CDDevueltos",
                Value = Resultado
            };
            RvwReporte.LocalReport.DataSources.Clear();
            RvwReporte.LocalReport.DataSources.Add(rds);

            // --Establecer ruta del archivo RDLC
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppCertificadosDefuncion\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\ReportesRDLC\RptLista_CDDevueltos.rdlc";

            // --configurar el report viewer
            RvwReporte.LocalReport.ReportPath = RutaRDLC;
            this.RvwReporte.RefreshReport();
        }
    }
}