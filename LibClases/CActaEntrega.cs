using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void RegistrarActaEntrega(string CodActaEntrega, string Fecha, string Hora, string Documento_Encargado, string Documento_Personal, string MicroRed, string Establecimiento)
        {
            string Consulta = "insert into Acta_Entrega values('" + CodActaEntrega + "', '" + Fecha + "', '" + Hora + "','" + Documento_Encargado + "','" + Documento_Personal + "','" + MicroRed + "', '" + Establecimiento + "')";
            aConexion.EjecutarComando(Consulta);
        }
        public DataTable MostrarActasEntrega()
        {
            string Consulta = "select * from Acta_Entrega";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public void CambiarEstadoFinalizado(string CodCertificadoDefuncion)
        {
            string Consulta = "UPDATE ActaEntrega_CD SET Estado = 'FINALIZADO' WHERE CodExpediente='" + CodCertificadoDefuncion + "' ";
            aConexion.EjecutarComando(Consulta);
        }

        public DataTable MostrarPersonal()
        {
            string Consulta = "SELECT MAX(numero_documento) as Numero_Documento, Nombres_Personal as Nombres, Apellido_Paterno_Personal + ' ' + Apellido_Materno_Personal\r\nas Apellidos, MAX(p.Id_Profesion) as Id_Profesion, pr.Descripcion_Profesion as Profesion\r\nFROM MAESTRO_PERSONAL p inner join MAESTRO_HIS_PROFESION pr on p.Id_Profesion=pr.Id_Profesion\r\nGROUP BY Numero_Documento, Nombres_Personal, Apellido_Paterno_Personal, Apellido_Materno_Personal, pr.Descripcion_Profesion";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Funcion para generar un codigo autonumerico de la forma "AE-001-00001-2023"
        public string GenerarCodigoAutonumerico(int entero)
        {
            // Obtener el año actual
            int year = DateTime.Now.Year;

            // Obtener la serie y correlativo correspondientes al entero recibido
            int serie = (entero - 1) / 999 + 1;
            int correlativo = (entero - 1) % 999 + 1;

            // Generar el nuevo código autonumérico
            string nuevaSerie = serie.ToString("D3");
            string nuevoCorrelativo = correlativo.ToString("D3");
            string nuevoCodigo = $"AE-{nuevaSerie}-{nuevoCorrelativo}-{year}";

            return nuevoCodigo;
        }

        //------------------------------------------------------
        public string generarCodigo()
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

            // Guardar el nuevo código en la base de datos o en un archivo
            guardarCodigo(nuevoCodigo);

            return nuevoCodigo;
        }

        private string siguienteSerie(string serieActual)
        {
            int numeroSerie = int.Parse(serieActual);
            numeroSerie++;
            return numeroSerie.ToString("D3");
        }

        private string obtenerUltimoCodigo()
        {
            // Aquí puedes escribir el código para obtener el último código generado
            // Puedes utilizar una base de datos, un archivo de texto o cualquier otro medio de almacenamiento de datos para esto.
            // En este ejemplo, simplemente devolvemos un valor fijo.
            return "ACT-ENT-2023-002-001"; //ACT-ENT-2023-001-001
        }

        private void guardarCodigo(string nuevoCodigo)
        {
            // Aquí puedes escribir el código para guardar el nuevo código generado
            // Puedes utilizar una base de datos, un archivo de texto o cualquier otro medio de almacenamiento de datos para esto.
        }
    }
}
