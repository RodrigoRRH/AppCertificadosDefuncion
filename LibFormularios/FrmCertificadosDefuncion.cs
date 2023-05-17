using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Text;
using LibClases;
using LibFormularios.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LibFormularios
{
    public partial class FrmCertificadosDefuncion : DevExpress.XtraEditors.XtraForm
    {
        CConexion aConexion = new CConexion();
        //private FrmCertificado FrmCertificado;
        public FrmCertificadosDefuncion()
        {
            InitializeComponent();
            Cargar_ListaCD();
        }

        public void Cargar_ListaCD()
        {
            dgvListaCertificados.DataSource = aConexion.ListaCD();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCertificado certificado = new FrmCertificado();

            certificado.txtCodigoCD.Text = dgvListaCertificados[0, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString();
            certificado.txtDocumento.Text = dgvListaCertificados[1, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString();
            certificado.txtNombres.Text = dgvListaCertificados[2, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString();
            certificado.txtApellidos.Text = dgvListaCertificados[3, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString();

            string CadenaConexion = "Data Source=localhost; Initial Catalog = DBCertificadosDefuncion; Integrated Security = SSPI; ";
            string sqlQuery = "SELECT ImagenCertificado from CertificadoDefuncion WHERE CodCertificadoDefuncion = @Id";
            byte[] imageBytes;

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", dgvListaCertificados[0, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString());
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["ImagenCertificado"] == null || reader["ImagenCertificado"]==DBNull.Value)
                            {
                                //certificado.pboImagen.Image = Properties.Resources.nulo;
                                byte[] imgBytesNulo;
                                Image img = Properties.Resources.nulo;
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    ms.SetLength(0); // Reiniciar el MemoryStream

                                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    imgBytesNulo = ms.ToArray();
                                }

                                string mensaje = aConexion.SP_EditarCD("sp_EditarCD", dgvListaCertificados[0, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString(),
                                                                        dgvListaCertificados[1, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString(), dgvListaCertificados[2, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString(), dgvListaCertificados[3, dgvListaCertificados.CurrentCell.RowIndex].Value.ToString(), imgBytesNulo);

                                certificado.pboImagen.Image = Properties.Resources.nulo;
                            }
                            else
                            {
                                imageBytes = (byte[])reader["ImagenCertificado"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    certificado.pboImagen.Image = Image.FromStream(ms);
                                }
                            }
                            
                        }
                    }

                    //connection.Close();
                }
            }

            certificado.ShowDialog();

            if (certificado.RegistroModificado)
            {
                Cargar_ListaCD();
            }

        }
    }
}