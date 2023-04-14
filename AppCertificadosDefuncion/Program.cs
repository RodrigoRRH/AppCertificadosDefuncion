using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.UIAutomation;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using LibFormularios;
using System.Diagnostics;


namespace AppCertificadosDefuncion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FrmInicio());
            //Application.Run(new Ribbon);
            //Application.Run(new rbfAplicacion());
            Application.Run(new FrmMenu());
            
        }
    }
}
