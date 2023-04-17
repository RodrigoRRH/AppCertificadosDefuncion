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
    public partial class FrmActaEntrega : FrmActa
    {
        CConexion aConexion = new CConexion();

        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public FrmActaEntrega()
        {
            InitializeComponent();
            CargarCboMicro();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de informe

            //FrmConfirmartTest ConfirmartTest = new FrmConfirmartTest();
            MostrarInforme();

            // Establece los valores de los controles de texto en el formulario de informe
            //informeForm.
            //informeForm.ApellidoLabel.Text = apellidoTextBox.Text;
            //informeForm.EdadLabel.Text = edadTextBox.Text;
            //// Agrega cualquier otro dato que desees mostrar en el informe

            //// Muestra el formulario de informe
            //informeForm.ShowDialog();
        }

        private void MostrarInforme()
        {
            // --- validar que todos los datos esten completos acá o el btnTest_click(Guardar)
            // --- preguntar si los datos estan correctos y aceptar 
            // --- si se acepta limpiar los datos(poner en blanco todos los textbox, combobox, // o que se inicie otra vez el form acta de entrega

            // Crea una nueva instancia del formulario de informe
            FrmConfirmartTest frmConfirmartTest = new FrmConfirmartTest();

            frmConfirmartTest.txtCodigosCD.Text = txtCodigoActa.Text;
            frmConfirmartTest.txtMicroRed.Text = cboMicroRed.Text;
            frmConfirmartTest.txtEstablecimiento.Text = cboEstablecimiento.Text;
            frmConfirmartTest.dtpFecha.Value = dtpFecha.Value;
            frmConfirmartTest.dtpHora.Value = dtpHora.Value;
            frmConfirmartTest.txtEncargado.Text = txtDocumentoEncargado.Text;
            frmConfirmartTest.txtPersonalSalud.Text = txtDocumentoPersonal.Text;


            // Muestra el formulario de informe
            frmConfirmartTest.ShowDialog();
        }

        public void CargarCboMicro()
        {
            dt = aConexion.CargarMicrored().Tables[0];
            DataRow fila = dt.NewRow();
            fila["MicroRed"] = "MicroRed";
            dt.Rows.InsertAt(fila, 0);

            cboMicroRed.ValueMember = "Codigo_MicroRed";
            cboMicroRed.DisplayMember = "MicroRed";
            cboMicroRed.DataSource = dt;
        }

        public void CargarCboEstablecimiento(string MicroRed)
        {
            dt1 = aConexion.CargarEstablecimiento(MicroRed).Tables[0];
            DataRow fila1 = dt1.NewRow();
            fila1["Establecimiento"] = "Establecimiento";
            dt1.Rows.InsertAt(fila1, 0);

            cboEstablecimiento.ValueMember = "Id_Establecimiento";
            cboEstablecimiento.DisplayMember = "Establecimiento";
            cboEstablecimiento.DataSource = dt1;

        }

        private void cboMicroRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMicroRed.SelectedValue.ToString() != null | cboMicroRed.SelectedValue.ToString() != "")
            {
                string microred = cboMicroRed.SelectedValue.ToString();
                CargarCboEstablecimiento(microred);
            }
        }
    }
}
