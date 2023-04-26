using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibClases
{
    public class CActaEntrega : CEntidad
    {
        //=============== ATRIBUTOS =======================
        //-- Todos heredados de CEntidad ----
        //================ METODOS ========================
        //-------------- Constructores --------------------
        public CActaEntrega() : base("Acta_Entrega")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodActaEntrega", "Fecha", "Hora", "Documento_Encargado", "Documento_Personal", "MicroRed", "Establecimiento" };
        }

        // -- insertar(guardar) Acta Entrega en la BD
        public void RegistrarActaEntrega(string CodActaEntrega, DateTime Fecha, DateTime Hora, string Documento_Encargado, string Documento_Personal, string MicroRed, string Establecimiento)
        {
            string Consulta = "insert into Acta_Entrega values('" + CodActaEntrega + "', '" + Fecha + "', '" + Hora + "','" + Documento_Encargado + "','" + Documento_Personal + "','" + MicroRed + "', '" + Establecimiento + "')";
            aConexion.EjecutarComando(Consulta);
        }

        // -- insertar(guardar) las relaciones de Acta_Entrega con los Certificados de Defuncion en la BD, tabla ActaEntrega_CD
        public void RegistrarActaEntrega_CD(string CodActaEntrega, string CodCertificadoDefuncion, string Estado)
        {
            string Consulta = "insert into ActaEntrega_CD values('" + CodActaEntrega + "','" + CodCertificadoDefuncion + "', '" + Estado + "')";
            aConexion.EjecutarComando(Consulta);
        }

        // -- Mostrar los registros de Acta Entrega
        public DataTable MostrarActasEntrega()
        {
            string Consulta = "select * from Acta_Entrega";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Cambiar estado si un Certificado de Defuncion fue devuelto, en la tabla ActaEntrega_CD( donde se tienen las relaciones de Acta_Entrega con los Certificados de Defuncion en la BD)
        public void CambiarEstadoFinalizado(string CodCertificadoDefuncion)
        {
            string Consulta = "UPDATE ActaEntrega_CD SET Estado = 'FINALIZADO' WHERE CodCertificadoDefuncion='" + CodCertificadoDefuncion + "' ";
            aConexion.EjecutarComando(Consulta);
        }

        // -- Mostrar los registros de Personal
        public DataTable MostrarPersonal()
        {
            string Consulta = "SELECT MAX(numero_documento) as Numero_Documento, Nombres_Personal as Nombres, Apellido_Paterno_Personal + ' ' + Apellido_Materno_Personal\r\nas Apellidos, MAX(p.Id_Profesion) as Id_Profesion, pr.Descripcion_Profesion as Profesion\r\nFROM MAESTRO_PERSONAL p inner join MAESTRO_HIS_PROFESION pr on p.Id_Profesion=pr.Id_Profesion\r\nGROUP BY Numero_Documento, Nombres_Personal, Apellido_Paterno_Personal, Apellido_Materno_Personal, pr.Descripcion_Profesion";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Funcion para generar un codigo autonumerico de la forma "ACT-ENT-2023-001-001"
        //------------------------------------------------------
        public string GenerarCodigoAutonumerico()
        {
            // Obtener el último código generado
            string ultimoCodigo = obtenerUltimoCodigo();

            // Extraer los valores de serie, correlativo y año del último código generado
            string[] partes = ultimoCodigo.Split('-');
            int anio = int.Parse(partes[2]);
            string serie = partes[3];
            int correlativo = int.Parse(partes[4]);
            

            // Verificar si el año actual es diferente al año del último código generado
            if (anio != DateTime.Now.Year)
            {
                serie = "001";
                correlativo = 1;
                anio = DateTime.Now.Year;
            }
            else
            {
                correlativo++;
                if (correlativo > 999)
                {
                    serie = siguienteSerie(serie);
                    correlativo = 1;
                }
            }

            // Concatenar los valores de serie, correlativo y año en el formato deseado
            string nuevoCodigo = string.Format("ACT-ENT-{0}-{1}-{2:D3}",anio, serie, correlativo);

            return nuevoCodigo;
        }

        private string siguienteSerie(string serieActual)
        {
            int numeroSerie = int.Parse(serieActual);
            numeroSerie++;
            return numeroSerie.ToString("D3");
        }

        public string obtenerUltimoCodigo()
        {
            // Recuperamos el ultimo codigo de la tabla "Acta_Entrega" de la base de datos
            // Para ello hacemos uso del store procedure

            string UltimoCodigo = aConexion.SP_Recuperar_MaxCodActa("sp_Recuperar_UltimaActa", 1);

            if(UltimoCodigo == "")
            {
                //En caso de que nuestra tabla este vacía pasamos por defecto "ACT-ENT-Año.Actual-001-000"
                string nuevoCodigo = string.Format("ACT-ENT-{0}-001-000", DateTime.Now.Year); 
                return nuevoCodigo;
            }
            else
            {
                return  UltimoCodigo;
            }          
        }
        
        //Generar codigos consecutivos dado un rango, ejemplo:  rango(0011010;0011015) resultado: 0011010, 0011011, 0011012, 0011013, 0011014 y 0011015; otro ejemplo: rango(2011001;2011003) resultado: 2011001, 2011002 y 2011003; en C# windows forms

    }
}
