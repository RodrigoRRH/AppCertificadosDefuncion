using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using LibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace LibFormularios
{
    public partial class FrmCertificado : DevExpress.XtraEditors.XtraForm
    {
        CConexion aConexion = new CConexion();
        CCertificado aCertificado = new CCertificado();
        public bool RegistroModificado { get; private set; }
        public FrmCertificado()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog subirImagen = new OpenFileDialog();
            DialogResult result = subirImagen.ShowDialog();
            if (result == DialogResult.OK)
            {
                pboImagen.Image = Image.FromFile(subirImagen.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pboImagen.Image == null)
            {
                //MessageBox.Show("Colocar una imagen", "RED NORTE");
                byte[] imageData1;

                // Convierte la imagen en un arreglo de bytes
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.SetLength(0); // Reiniciar el MemoryStream

                    Image img = Properties.Resources.nulo;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData1 = ms.ToArray();

                    // Inserta la imagen en la base de datos

                    string mensaje = aConexion.SP_EditarCD("sp_EditarCD", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text, imageData1);
                    MessageBox.Show(mensaje, "RED NORTE");

                    RegistroModificado = true;

                    this.Close();

                }

                
            }
            else
            {
                try
                {
                    byte[] imageBytes = new byte[0];
                    //byte[] imageBytesSQL = new byte[0];

                    //using (MemoryStream ms = new MemoryStream())
                    //{
                    //    imageBytes = ImagenABytes(pboImagen.Image);
                    //}

                    imageBytes = ImageToByteArray(pboImagen.Image);
                    //imageBytes = ImagenABytes(pboImagen.Image);

                    //imageBytesSQL = aConexion.recuperarImagen(txtCodigoCD.Text);

                    //if (CompararImagenes(imageBytesSQL, imageBytes) == true)
                    //{
                    //    string mensaje1 = aConexion.SP_EditarCD_SinImagen("sp_EditarCD_SinImagen", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text);
                    //    MessageBox.Show(mensaje1, "RED NORTE");
                    //    this.Close();
                    //}
                    //else
                    //{
                    //    string mensaje1 = aConexion.SP_EditarCD("sp_EditarCD", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text, imageBytes);
                    //    MessageBox.Show(mensaje1, "RED NORTE");
                    //    this.Close();
                    //}

                    string mensaje = aConexion.SP_EditarCD("sp_EditarCD", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text, imageBytes);
                    MessageBox.Show(mensaje, "RED NORTE");

                    RegistroModificado = true;
                    this.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR: Cambie la imagen o cargue la misma imagen nuevamente", "RED NORTE");
                }

                //string CadenaConexion = "Data Source=localhost; Initial Catalog = DBCertificadosDefuncion; Integrated Security = SSPI; ";
                //string sqlQuery = "SELECT ImagenCertificado from CertificadoDefuncion WHERE CodCertificadoDefuncion = @Id";
                ////byte[] imageBytesSQL;

                //using (SqlConnection connection = new SqlConnection(CadenaConexion))
                //{
                //    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                //    {
                //        command.Parameters.AddWithValue("@Id", txtCodigoCD.Text);
                //        connection.Open();

                //        using (SqlDataReader reader = command.ExecuteReader())
                //        {
                //            if (reader.Read())
                //            {
                //                byte[]  imageBytesSQL = (byte[])reader["ImagenCertificado"];
                //                byte[] imageBytesPictureBox = new byte[0];

                //                Image img = pboImagen.Image;
                //                using (MemoryStream ms = new MemoryStream())
                //                {
                //                    ms.SetLength(0); // Reiniciar el MemoryStream

                //                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //                    imageBytesPictureBox = ms.ToArray();
                //                }

                //                if (CompararImagenes(imageBytesSQL, imageBytesPictureBox))
                //                {
                //                    string mensaje = aConexion.SP_EditarCD_SinImagen("sp_EditarCD_SinImagen", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text);
                //                    MessageBox.Show(mensaje, "RED NORTE");
                //                }
                //                else
                //                {
                //                    string mensaje = aConexion.SP_EditarCD("sp_EditarCD", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text, imageBytesPictureBox);
                //                    MessageBox.Show(mensaje, "RED NORTE");
                //                }

                //            }
                //        }

                //        connection.Close();
                //    }
                //}

                //-----------------------------------------------------------------------------

                //try
                //{
                //    byte[] imageData2;

                //    // Convierte la imagen en un arreglo de bytes
                //    using (MemoryStream ms = new MemoryStream())
                //    {
                //        ms.SetLength(0); // Reiniciar el MemoryStream

                //        pboImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //        imageData2 = ms.ToArray();

                //        // Inserta la imagen en la base de datos

                //        string mensaje = aConexion.SP_EditarCD("sp_EditarCD", txtCodigoCD.Text, txtDocumento.Text, txtNombres.Text, txtApellidos.Text, imageData2);
                //        MessageBox.Show(mensaje, "RED NORTE");
                //    }
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Error");
                //}


            } 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // -- ***************************************************************************** --
        // -- Metodo para comparar 2 imagenes en formato byte[]
        public bool CompararImagenes(byte[] imagenBytes1, byte[] imagenBytes2)
        {
            // Comparar las imágenes
            bool sonIguales = CompararImagenesBytes(imagenBytes1, imagenBytes2);
            return sonIguales;
        }
        static bool CompararImagenesBytes(byte[] imagenBytes1, byte[] imagenBytes2)
        {
            // Calcular los hashes de las imágenes
            byte[] hash1 = CalcularHashSHA256(imagenBytes1);
            byte[] hash2 = CalcularHashSHA256(imagenBytes2);

            // Comparar los hashes de las imágenes
            return CompararBytes(hash1, hash2);
        }

        static byte[] CalcularHashSHA256(byte[] data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(data);
            }
        }

        static bool CompararBytes(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    return false;
                }
            }

            return true;
        }
        // -- ***************************************************************************** --
        // Metodos para convertir Imagen a Byte[] y vicecersa 1
        static byte[] ImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //imagen.Save(ms, imagen.RawFormat);
                imagen.Save(ms, imagen.RawFormat);
                //imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.GetBuffer();
                //return ms.ToArray();
            }
        }

        static Image BytesAImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        // Metodos para convertir Imagen a Byte[] y vicecersa 2
        // Convertir una imagen a byte[]
        public byte[] ImageToByteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        
        // Convertir byte[] a una imagen
        public Image ByteArrayToImage(byte[] byteArray)
        {
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertFrom(byteArray);
        }
    }
}