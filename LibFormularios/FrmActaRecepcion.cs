﻿using DevExpress.XtraDashboardLayout;
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
    public partial class FrmActaRecepcion : FrmActa
    {
        CConexion aConexion = new CConexion();
        CActaRecepcion aActaRecepcion = new CActaRecepcion();
        CCertificado aCertificado = new CCertificado();
        FrmMenu aMenu = new FrmMenu();

        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public FrmActaRecepcion()
        {
            InitializeComponent();
            CargarCboMicro();
            txtCodigoActa.Text = aActaRecepcion.GenerarCodigoActaRecepcion();
        }

        public override bool EsRegistroValido()
        {
            if (txtCodigoActa.Text.Trim() != "" && txtDocumentoEncargado.Text.Trim() != "" && txtDocumentoPersonal.Text.Trim() != "" && cboMicroRed.Text.Trim() != "")
            {
                if (rbtManual.Checked)
                {
                    if (txtCodigosCD.Text.Trim() != "")
                        return true;
                    else
                        return false;
                }
                else if (rbtRango.Checked)
                {
                    if (lboCodigosCD.Items.Count != 0)
                        return true;
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MostrarInforme();
        }

        private void MostrarInforme()
        {
            // --- validar que todos los datos esten completos acá o el btnTest_click(Guardar)
            // --- preguntar si los datos estan correctos y aceptar 
            // --- si se acepta limpiar los datos(poner en blanco todos los textbox, combobox, // o que se inicie otra vez el form acta de entrega

            // Crea una nueva instancia del formulario de informe
            FrmConfirmartTest frmConfirmartTest = new FrmConfirmartTest();

            if (rbtManual.Checked)
            {
                string codigos = "";
                List<string> codigosCD = new List<string>(txtCodigosCD.Text.Split(','));

                for (int i = 0; i < codigosCD.Count; i++)
                {
                    // [10,11,12,13,14]
                    // [ 0, 1, 2, 3, 4]
                    // 5
                    // 1.- if i=0<4     : 10, 
                    // 2.- if i=1<4     : 10, 11, 
                    // 3.- if i=2<4     : 10, 11, 12, 
                    // 4.- if i=3<4     : 10, 11, 12, 13, 
                    // 5.- else i=4<4   : 10, 11, 12, 13, 14

                    if (i < codigosCD.Count - 1)
                    {
                        codigos += codigosCD[i].Trim() + ", ";
                    }
                    else
                    {
                        codigos += codigosCD[i].Trim();
                    }
                }
                frmConfirmartTest.txtCodigosCD.Text = codigos;

            }
            else if (rbtRango.Checked)
            {
                string codigosRango = "";

                foreach (string item in lboCodigosCD.Items)
                {
                    if (lboCodigosCD.Items[lboCodigosCD.Items.Count - 1].ToString() != item)
                    {
                        codigosRango += item + ", ";
                    }
                    else
                    {
                        codigosRango += item;
                    }

                }
                frmConfirmartTest.txtCodigosCD.Text = codigosRango;
            }

            frmConfirmartTest.txtCodigoActa.Text = txtCodigoActa.Text;
            frmConfirmartTest.txtMicroRed.Text = cboMicroRed.Text;
            frmConfirmartTest.txtEstablecimiento.Text = cboEstablecimiento.Text;
            frmConfirmartTest.dtpFecha.Value = dtpFecha.Value;
            frmConfirmartTest.dtpHora.Value = dtpHora.Value;
            frmConfirmartTest.txtEncargado.Text = txtNombresEncargado.Text + ' ' + txtApellidosEncargado.Text;
            frmConfirmartTest.txtPersonalSalud.Text = txtNombresPersonal.Text + ' ' + txtApellidosPersonal.Text;

            //frmConfirmartTest.txtFecha.Text = dtpFecha.Value.ToString("dd-MM-yyyy");
            //frmConfirmartTest.txtHora.Text = dtpHora.Text;

            // Muestra el formulario de informe
            frmConfirmartTest.ShowDialog();
        }

        // -- Cargar las MicroRedes a un comboBox
        public void CargarCboMicro()
        {
            dt = aConexion.CargarMicrored().Tables[0];
            DataRow fila = dt.NewRow();
            fila["MicroRed"] = "";
            dt.Rows.InsertAt(fila, 0);

            cboMicroRed.ValueMember = "Codigo_MicroRed";
            cboMicroRed.DisplayMember = "MicroRed";
            cboMicroRed.DataSource = dt;
        }

        // -- Cargar los Establecimientos a un comboBox según la MicroRed elegida
        public void CargarCboEstablecimiento(string MicroRed)
        {
            dt1 = aConexion.CargarEstablecimiento(MicroRed).Tables[0];
            DataRow fila1 = dt1.NewRow();
            fila1["Establecimiento"] = "";
            dt1.Rows.InsertAt(fila1, 0);

            cboEstablecimiento.ValueMember = "Id_Establecimiento";
            cboEstablecimiento.DisplayMember = "Establecimiento";
            cboEstablecimiento.DataSource = dt1;

        }

        // -- Evento para mostrar los Establecimientos según la MicroRed
        private void cboMicroRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMicroRed.SelectedValue.ToString() != null | cboMicroRed.SelectedValue.ToString() != "")
            {
                string microred = cboMicroRed.SelectedValue.ToString();
                CargarCboEstablecimiento(microred);
            }
        }

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            FrmBusquedaEncargado busquedaEncargado = new FrmBusquedaEncargado(aActaRecepcion.MostrarPersonal());
            busquedaEncargado.ShowDialog();

            //-- Consulta valor devuelto
            if (busquedaEncargado.Numero_Documento != "")
            {
                txtDocumentoEncargado.Text = busquedaEncargado.Numero_Documento;
                txtNombresEncargado.Text = busquedaEncargado.Nombres;
                txtApellidosEncargado.Text = busquedaEncargado.Apellidos;
            }
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            FrmBusquedaPersonal busquedaPersonal = new FrmBusquedaPersonal(aActaRecepcion.MostrarPersonal());
            busquedaPersonal.ShowDialog();

            //-- Consulta valor devuelto
            if (busquedaPersonal.Numero_Documento != "")
            {
                txtDocumentoPersonal.Text = busquedaPersonal.Numero_Documento;
                txtNombresPersonal.Text = busquedaPersonal.Nombres;
                txtApellidosPersonal.Text = busquedaPersonal.Apellidos;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoActa.Text = aActaRecepcion.GenerarCodigoActaRecepcion();
        }

        public void GenerarCodigosCD()
        {
            // radiobutton opcion: insertar codigos manualmente o por rangos() sin comas 
            // bloquear el listbox si es por rango; Habilitar el listbox si es manualmente
            // un mensaje(label) si es manual, sin comas 

            try
            {
                if (txtDesde.Text != "" & txtHasta.Text != "")
                {

                    string rangoInicio = txtDesde.Text;//"1011010";
                    string rangoFin = txtHasta.Text;//"1011011";
                    List<string> codigos = new List<string>();

                    int longitudCadena = rangoInicio.Length;

                    int inicio = int.Parse(rangoInicio);
                    int fin = int.Parse(rangoFin);

                    if (inicio <= fin)
                    {
                        for (int i = inicio; i <= fin; i++)
                        {
                            codigos.Add(i.ToString("D" + longitudCadena));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Desde debe ser menor que Hasta", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    // En el ejemplo anterior, "D7" indica que se deben utilizar 7 dígitos para el número, 
                    // rellenando con ceros a la izquierda en caso de que el número tenga menos de 7 dígitos.

                    // Para mostrar los códigos generados, puedes utilizar un control ListBox de Windows Forms:
                    lboCodigosCD.DataSource = codigos;
                    //txtCodigoActa.Text = longitudCadena.ToString();
                    //txtCodigoActa.Text = codigos[0];
                }
                else
                {
                    MessageBox.Show("Llenar los campos Desde y Hasta", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Error", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGenerarCodigosCD_Click(object sender, EventArgs e)
        {
            GenerarCodigosCD();
        }

        private void rbtManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtManual.Checked)
            {
                txtCodigosCD.Enabled = true;
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
                btnGenerarCodigosCD.Enabled = false;
                lboCodigosCD.Enabled = true;
            }
        }

        private void rbtRango_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRango.Checked)
            {
                //txtCodigosCD.Text = "";
                txtCodigosCD.Enabled = false;
                txtDesde.Enabled = true;
                txtHasta.Enabled = true;
                btnGenerarCodigosCD.Enabled = true;
                lboCodigosCD.Enabled = true;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EsRegistroValido())
            {
                //MostrarInforme();
                DialogResult resultado = MessageBox.Show("Seguro de guardar los datos", "RED NORTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (resultado == DialogResult.OK)
                {
                    Grabar();
                }
                //Grabar();
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public override void Grabar()
        {

            string estado = "FINALIZADO, DEVUELTO";
            try
            {
                // Control de numero de inserciones; en caso que ningún codigo pasado de Certificado de Defuncion no exista en la BD, no se creará el acta. Basta que uno o más codigos existan, para que se cree el acta 
                int cantidad = 0;

                if (rbtManual.Checked)
                {
                    
                    // pasar el texbox(string, separado por comas) a una lista de strings, y guardar uno por uno en la base de datos
                    List<string> listaCodigosCD = new List<string>(txtCodigosCD.Text.Split(','));

                    foreach (string item in listaCodigosCD)
                    {
                        // Verificar si el Certificado de Defuncion existe en la BD
                        if (aCertificado.ExisteCertificado(item.Trim()))
                        {
                            // Si existe se actualiza su estado a "FINALIZADO, DEVUELTO" en la tabla ActaEntrega_CD
                            // Además se guarda las relaciones de cada Certificado de Defuncion con la Acta de Recepcion, y estado "FINALIZADO, DEVUELTO"
                            aActaRecepcion.RegistrarActaRecepcion_CD(txtCodigoActa.Text, item.Trim(), estado);
                            aActaRecepcion.CambiarEstadoFinalizado(item.Trim());
                            cantidad++;

                        }
                        else
                        {
                            //Si el certificado no existe, muesta mensaje, 
                            MessageBox.Show("EL CERTIFICADO " + item.Trim() + " NO EXISTE, NO SE AGREGARÁ AL ACTA; LOS QUE EXISTAN SE AGREGARÁN AL ACTA Y SU ESTADO SE ACTUALIZARÁ A \"FINALIZADO, DEVUELTO\"", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (cantidad == 0)
                    {
                        MessageBox.Show("LOS CODIGOS NO EXISTEN, NO SE ACTUALIZARÁN SUS ESTADOS NI SE CREARÁ EL ACTA", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //this.Close();

                    }
                    else 
                    {
                        aActaRecepcion.RegistrarActaRecepcion(txtCodigoActa.Text, dtpFecha.Value.ToString("dd-MM-yyyy"), dtpHora.Text, txtDocumentoEncargado.Text, txtNombresEncargado.Text, txtApellidosEncargado.Text, txtDocumentoPersonal.Text, txtNombresPersonal.Text, txtApellidosPersonal.Text, cboMicroRed.Text, cboEstablecimiento.Text);
                        MessageBox.Show("REGISTRO EXITOSO, SE CREÓ EL ACTA: " + txtCodigoActa.Text, "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                if (rbtRango.Checked)
                {
                    // pasar el listbox a una lista de string separados por comas, y guardar uno por uno en la base de datos


                    // Crea una lista y en ella almacena los datos de un ListBox, además de mostrar el contenido de dicha lista en el textbox txtCodigosCD
                    // Crear una lista para almacenar los elementos del ListBox


                    ////// Recorrer los elementos del ListBox y agregarlos a la lista
                    foreach (string item in lboCodigosCD.Items)
                    {
                        // Verificar si el Certificado de Defuncion existe en la BD
                        if (aCertificado.ExisteCertificado(item.Trim()))
                        {
                            // Si existe se actualiza su estado a "FINALIZADO, DEVUELTO" en la tabla ActaEntrega_CD
                            // Además se guarda las relaciones de cada Certificado de Defuncion con la Acta de Recepcion, y estado "FINALIZADO, DEVUELTO"
                            aActaRecepcion.RegistrarActaRecepcion_CD(txtCodigoActa.Text, item.Trim(), estado);
                            aActaRecepcion.CambiarEstadoFinalizado(item.Trim());
                            cantidad++;
                        }
                        else
                        {
                            //Si el certificado no existe, muesta mensaje, 
                            MessageBox.Show("EL CERTIFICADO " + item.Trim() + " NO EXISTE, NO SE AGREGARÁ AL ACTA; LOS QUE EXISTAN SE AGREGARÁN AL ACTA Y SU ESTADO SE ACTUALIZARÁ A \"FINALIZADO, DEVUELTO\"", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    if (cantidad == 0)
                    {
                        MessageBox.Show("LOS CODIGOS NO EXISTEN, NO SE ACTUALIZARÁN SUS ESTADOS NI SE CREARÁ EL ACTA", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //this.Close();
                    }
                    else
                    {
                        aActaRecepcion.RegistrarActaRecepcion(txtCodigoActa.Text, dtpFecha.Value.ToString("dd-MM-yyyy"), dtpHora.Text, txtDocumentoEncargado.Text, txtNombresEncargado.Text, txtApellidosEncargado.Text, txtDocumentoPersonal.Text, txtNombresPersonal.Text, txtApellidosPersonal.Text, cboMicroRed.Text, cboEstablecimiento.Text);
                        MessageBox.Show("REGISTRO EXITOSO, SE CREÓ EL ACTA: " + txtCodigoActa.Text, "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL REALIZAR LA OPERACION", "RED NORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void aea(DateTime dt)
        {
            dt = dtpFecha.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
