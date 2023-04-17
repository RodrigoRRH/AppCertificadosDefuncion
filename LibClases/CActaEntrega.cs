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

        public DataTable MostrarJurado(string aCodTesis)
        {
            string Consulta = "SELECT A.CodDocente,C.Nombres,C.Apellidos,A.Rol " +
                "FROM TExpedienteAsig_DocenteJurado A INNER JOIN TResolucionJurado B ON A.CodResolucionJurado=B.CodResolucionJurado " +
                "inner join TDocente C on A.CodDocente=C.CodDocente " +
                "inner join TExpediente D on B.CodExpediente=D.CodExpediente " +
                "where D.CodTesis='" + aCodTesis + "' AND D.CodTipoTramite='TR000003' " +
                "ORDER BY A.Rol";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable MostrarAsignaciones()
        {
            string Consulta = "EXEC spuListarAsignaciones";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public bool ExisteExpedienteConAsignacion(string codExpediente)
        { // verifica si un registro especifico existe
          //-- Recuperar los nombres y valores de los atributos de la tabla.
          //-- Formar la consulta
            string CadenaConsulta = "select * from TExpedienteAsignacion" +
                                    " where CodExpediente = '" + codExpediente + "'";
            //-- Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public void CambiarEstadoFinalizado(string CodExpediente)
        {
            string Consulta = "UPDATE TExpediente SET Estado = 'FINALIZADO' WHERE CodExpediente='" + CodExpediente + "' ";
            aConexion.EjecutarComando(Consulta);
        }
    }
}
