using DevExpress.XtraEditors;
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
    public partial class FrmReportes : DevExpress.XtraEditors.XtraForm
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        // -- Reportes Acta de Entrega --
        private void btnListaActasEntrega_Click(object sender, EventArgs e)
        {
            FrmRptListaActasEntrega rptListaActasEntrega = new FrmRptListaActasEntrega();
            rptListaActasEntrega.ShowDialog();
        }

        private void btnCertificadosXActaEntrega_Click(object sender, EventArgs e)
        {
            FrmRptCertificadosXActaEntrega rptCertificadosXActaEntrega = new FrmRptCertificadosXActaEntrega();
            rptCertificadosXActaEntrega.ShowDialog();
        }

        // -- Reportes Acta de Recepcion --
        private void btnListaActaRecepcion_Click(object sender, EventArgs e)
        {
            FrmRptListaActasRecepcion rptListaActasRecepcion = new FrmRptListaActasRecepcion();
            rptListaActasRecepcion.ShowDialog();
        }

        private void btnCertificadosXActaRecepcion_Click(object sender, EventArgs e)
        {
            FrmRptCertificadosXActaRecepcion rptCertificadosXActaRecepcion = new FrmRptCertificadosXActaRecepcion();
            rptCertificadosXActaRecepcion.ShowDialog();
        }

        // -- Reportes Certificados de Defuncion --
        private void btnListaCertificados_Click(object sender, EventArgs e)
        {
            FrmRptListaCertificadosDefuncion rptListaCertificadosDefuncion = new FrmRptListaCertificadosDefuncion();
            rptListaCertificadosDefuncion.ShowDialog();
        }

        private void btnCertificadosProceso_Click(object sender, EventArgs e)
        {
            FrmRptListaCD_NoDevueltos rptListaCD_NoDevueltos = new FrmRptListaCD_NoDevueltos();
            rptListaCD_NoDevueltos.ShowDialog();
        }

        private void btnCertificadosDevueltos_Click(object sender, EventArgs e)
        {
            FrmRptListaCD_Devueltos rptListaCD_Devueltos = new FrmRptListaCD_Devueltos();
            rptListaCD_Devueltos.ShowDialog();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}