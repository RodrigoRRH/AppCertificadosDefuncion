using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CMetodos: CEntidad
    {
        public CMetodos() : base("Metodos")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodCertificadoDefuncion", "Documento_Paciente", "Nombres", "Apellidos", "ImagenCertificado" };
        }

        // -- METODOS PARA LOS REPORTES --

        // -- ******* Acta Entrega ****** --

        // -- Reporte Lista de Actas de Entrega
        public DataTable ListaActasEntrega()
        {
            string Consulta = "select * from Acta_Entrega";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Reporte Certificados por Acta Entrega
        public DataTable CertificadosXActaEntrega(string CodActaEntrega)
        {
            string Consulta = "select A.CodActaEntrega, CD.CodCertificadoDefuncion, A_CD.Estado, CD.Documento_Paciente, CD.Nombres, CD.Apellidos from Acta_Entrega A " + 
                             "inner join ActaEntrega_CD A_CD on A.CodActaEntrega = A_CD.CodActaEntrega " +
                             "inner join CertificadoDefuncion CD on A_CD.CodCertificadoDefuncion = CD.CodCertificadoDefuncion " +
                             "where A.CodActaEntrega = '" + CodActaEntrega + "'";

            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }


        // -- ******* Acta Recepcion ******

        // -- Reporte Lista de Actas de Recepcion
        public DataTable ListaActasRecepcion()
        {
            string Consulta = "select * from Acta_Recepcion";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Reporte Certificados por Acta de Recepcion
        public DataTable CertificadosXActaRecepcion(string CodActaRecepcion)
        {
            string Consulta = "select A.CodActaRecepcion, CD.CodCertificadoDefuncion, A_CD.Estado, CD.Documento_Paciente, CD.Nombres, CD.Apellidos from Acta_Recepcion A " + 
                              "inner join ActaRecepcion_CD A_CD on A.CodActaRecepcion = A_CD.CodActaRecepcion " +
                              "inner join CertificadoDefuncion CD on A_CD.CodCertificadoDefuncion = CD.CodCertificadoDefuncion " +
                              "where A.CodActaRecepcion = '" + CodActaRecepcion + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }


        // -- ******* Certificado de Defuncion ******

        //-- Reporte Lista de Certificados de Defuncion
        public DataTable ListaCertificadosDefuncion()
        {
            string Consulta = "select C.CodCertificadoDefuncion, C.Documento_Paciente, C.Nombres, C.Apellidos, A.Estado from CertificadoDefuncion C inner join ActaEntrega_CD A on C.CodCertificadoDefuncion = A.CodCertificadoDefuncion";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        // -- Reporte Lista de Certificados de Defuncion en Proceso (No devueltos)
        public DataTable ListaCD_NoDevueltos()
        {
            string Consulta = "select CodCertificadoDefuncion, Estado, CodActaEntrega from ActaEntrega_CD where Estado = 'PROCESO, POR DEVOLVER'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        //-- Reporte Lista de Certificados de Defuncion Devueltos(FinalizaDos)
        public DataTable ListaCD_Devueltos()
        {
            string Consulta = "select C.CodCertificadoDefuncion, A_CD.Estado, C.Documento_Paciente, C.Nombres, C.Apellidos, A_CD.CodActaRecepcion, ACD.CodActaEntrega " +
                              "from ActaRecepcion_CD A_CD " + 
                              "inner join CertificadoDefuncion C on A_CD.CodCertificadoDefuncion = C.CodCertificadoDefuncion " + 
                              "inner join ActaEntrega_CD ACD on ACD.CodCertificadoDefuncion = C.CodCertificadoDefuncion " + 
                              "where A_CD.Estado = 'FINALIZADO, DEVUELTO'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
