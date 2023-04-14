using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCertificadosDefuncion
{
    public partial class FrmInicio : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmInicio()
        {
            InitializeComponent();
            ColorFrm();
        }

        private void itemCargarDatos_Click(object sender, EventArgs e)
        {
            
        }
        //Bitmap bitmap = new Bitmap(16, 16);
        public void ColorFrm()
        {

           //menuControl.BackColor = Systems.Control.DefaultBackColor;
           //menuControl.ForeColor = Color.Green;
            menuControl.BackColor = SystemColors.ControlDark;
            menuControl.BackColor = Color.Coral;


        }

    }
}
