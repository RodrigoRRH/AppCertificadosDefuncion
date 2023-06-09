﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace LibClases
{
    public class CConexion
    {
        //============== ATRIBUTOS =============================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        //============== METODOS ===============================
        //------------ Constructor -----------------------------
        public CConexion()
        { //-- iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            // realizar la conexion
            string CadenaConexion = "Data Source=localhost; Initial Catalog = DBCertificadosDefuncion; Integrated Security = SSPI; ";
        
            aConexion = new SqlConnection(CadenaConexion);
        }
        //----------- Propiedades ----------------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        //----------------------------------------------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        //----------------------------------------------------
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //------------- Servicios ------------------------------
        // --- Metodos para ejecutar comandos sql server
        // --- Devuelve el resultado en la tabla cero del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        { // metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // -------------------------------------------------------------------
        // --- Metodo para ejecutar instrucciones DML. No retorna resultado.
        // -------------------------------------------------------------------
        public virtual void EjecutarComando(string pComando)
        { // metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        // -- Metodo para mostrar un mensaje de aceptacion
        public void MostrarMensajeOK(string mensaje, string titulo)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult resultado;
            resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Information);

        }

        // -- Metodo para cargar paciente.csv y personal.csv
        public string SP_CargarPersonas(string sp, string ruta)
        {
            string resultado;
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aAdaptador.SelectCommand.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = ruta;

            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        // -- Metodo para borrar las tablas de la Base de Datos
        public string SP_Mensaje(string sp)
        {
            string resultado;
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        // -- Metodo para recuperar el valor del Max(CodActa) de la base de datos
        // -- Opcion: 1 si es Acta_Entrega y 2 si es Acta_Recepcion
        public string SP_Recuperar_MaxCodActa(string sp, int opcion)
        {
            string resultado;

            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aAdaptador.SelectCommand.Parameters.Add("@Opcion", SqlDbType.Int).Value = opcion;

            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        // -- Metodo para cargar las MicroRedes a nuestro combobox
        public DataSet CargarMicrored()
        {
            string CadenaConsulta = "select distinct Codigo_MicroRed, MicroRed from MAESTRO_HIS_ESTABLECIMIENTO where Red = 'CUSCO NORTE'";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        // -- Metodo para cargar los establecimientos a nuestro combobox, depende de la microred
        public DataSet CargarEstablecimiento(string MicroRed)
        {
            string CadenaConsulta = "select Id_Establecimiento, Nombre_Establecimiento as Establecimiento, Codigo_MicroRed from MAESTRO_HIS_ESTABLECIMIENTO where Red = 'CUSCO NORTE' and Codigo_MicroRed = '" + MicroRed + "' order by MicroRed";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            //aAdaptador.SelectCommand.Parameters.AddWithValue("MicroRed", SqlDbType.VarChar).Value = MicroRed;
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        // -- Metodo para actualizar un certificado de defuncion
        public string SP_EditarCD(string sp, string CodCD, string DocumentoPac, string Nombres, string Apellidos, byte[] imagen)
        {
            string resultado;
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 1000
            };
            aAdaptador.SelectCommand.Parameters.Add("@CodCD", SqlDbType.VarChar).Value = CodCD;
            aAdaptador.SelectCommand.Parameters.Add("@DocumentoPac", SqlDbType.VarChar).Value = DocumentoPac;
            aAdaptador.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = Nombres;
            aAdaptador.SelectCommand.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = Apellidos;
            aAdaptador.SelectCommand.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imagen;

            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;

        }

        // -- Metodo para actualizar un certificado de defuncion pero no la imagen
        public string SP_EditarCD_SinImagen(string sp, string CodCD, string DocumentoPac, string Nombres, string Apellidos)
        {
            string resultado;
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 1000
            };
            aAdaptador.SelectCommand.Parameters.Add("@CodCD", SqlDbType.VarChar).Value = CodCD;
            aAdaptador.SelectCommand.Parameters.Add("@DocumentoPac", SqlDbType.VarChar).Value = DocumentoPac;
            aAdaptador.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = Nombres;
            aAdaptador.SelectCommand.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = Apellidos;

            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;

        }


        // -- Metodo para listar los certificados de defuncion
        public DataTable ListaCD()
        {
            string Consulta = "select CodCertificadoDefuncion as 'Código Certificado', Documento_Paciente as 'Documento', Nombres, Apellidos from CertificadoDefuncion";
            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }

        public byte[] recuperarImagen(string Codigo)
        {
            byte[] resultado = new byte[] { };
            string sqlQuery = "SELECT ImagenCertificado from CertificadoDefuncion WHERE CodCertificadoDefuncion = @CodCD";

            aAdaptador.SelectCommand = new SqlCommand(sqlQuery, aConexion);
            aAdaptador.SelectCommand.Parameters.AddWithValue("@CodCD", Codigo);
            aAdaptador.SelectCommand.CommandTimeout = 1000;

            aConexion.Open();
            SqlDataReader reader = aAdaptador.SelectCommand.ExecuteReader();

            if (reader.Read())
            {
                resultado = (byte[])reader["ImagenCertificado"];
                return resultado;
            }
  
            aConexion.Close();

            return resultado;
        }

    }
}
