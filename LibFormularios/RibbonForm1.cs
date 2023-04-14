using DevExpress.XtraBars;
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
    public partial class rbfAplicacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public rbfAplicacion()
        {
            InitializeComponent();
        }


        private void btnCargarPersonal_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FrmCargarPaciente Paciente = new FrmCargarPaciente();
            //Paciente.Show();
        }

        private void btnCargarPaciente_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCargarPaciente paciente = new FrmCargarPaciente();
            //paciente.Show();
            paciente.TopLevel = false;
            pnlCargaDatos.Controls.Add(paciente);
            paciente.Show();
        }

        private void pagCargarDatos_Load(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btnResumen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}