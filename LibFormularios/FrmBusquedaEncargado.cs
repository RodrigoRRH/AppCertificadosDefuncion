using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmBusquedaEncargado : DevExpress.XtraEditors.XtraForm
    {
        private DataView aDatos;
        public FrmBusquedaEncargado(DataTable Datos)
        {
            InitializeComponent();
            aDatos = new DataView(Datos);
            dgvEncargado.DataSource = aDatos;

            FiltrarDatos();
        }

        #region VISUAL


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //--------------------------------------------------------------
        private void pnlTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        //----------------- PROPIEDADES ------------------------
        public string Numero_Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        //----------------- METODO PARA EL BUSCADOR ------------------------
        private void FiltrarDatos()
        {
            //-- crear filtro adecuado
            string Filtro = "";
            if (cboBusqueda.Text == "NUMERO DOCUMENTO")
                Filtro = "Numero_Documento like '%" + txtFiltro.Text.Trim() + "%'";
            if (cboBusqueda.Text == "NOMBRE")
                Filtro = "Nombres like '%" + txtFiltro.Text.Trim() + "%'";
            if (cboBusqueda.Text == "APELLIDOS")
                Filtro = "Apellidos like '%" + txtFiltro.Text.Trim() + "%'";
            if (cboBusqueda.Text == "PROFESION")
                Filtro = "Profesion like '%" + txtFiltro.Text.Trim() + "%'";
            aDatos.RowFilter = Filtro;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void cboBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {//-- No permitir escribir en Buscar Por:
            e.Handled = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Numero_Documento = dgvEncargado[0, dgvEncargado.CurrentCell.RowIndex].Value.ToString();
                Nombres = dgvEncargado[1, dgvEncargado.CurrentCell.RowIndex].Value.ToString();
                Apellidos = dgvEncargado[2, dgvEncargado.CurrentCell.RowIndex].Value.ToString();

            }
            catch (Exception)
            {
                Numero_Documento = "";
                Nombres = "";
                Apellidos = "";
            }
            //-- Cerrar formulario
            Close();
        }
    }
}