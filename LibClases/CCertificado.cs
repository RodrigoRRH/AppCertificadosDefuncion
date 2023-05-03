using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CCertificado : CEntidad
    {
        //=============== ATRIBUTOS =======================
        //-- Todos heredados de CEntidad ----
        //================ METODOS ========================
        //-------------- Constructores --------------------
        public CCertificado() : base("Certificado_Defuncion")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodCertificadoDefuncion", "Documento_Paciente", "Nombres", "Apellidos", "ImagenCertificado" };
        }

        public bool ExisteCertificado(string CodCertificado)
        { 
            // verifica si un registro de Certificado de Defuncion existe
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            //-- Formar la consulta
            string CadenaConsulta = "select * from CertificadoDefuncion" +
                                    " where CodCertificadoDefuncion = '" + CodCertificado + "'";
            //-- Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
    }
}
