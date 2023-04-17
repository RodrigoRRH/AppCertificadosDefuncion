using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public abstract class CEntidad
    {
        // ============================ Atributos ==============================
        protected CConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null; //-- nombres de los campos de la tabla
        string[] aValores = null; //-- valores de los campos de la tabla
        private bool aNuevo;
        // =========================== Metodos ==================================
        // ---------------------- Constructores ---------------------------------
        public CEntidad(string pNombreTabla)
        { // inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new CConexion();
            aNombres = NombresAtributos();
            aValores = null;
        }
        // ---------------------- Propiedades -------------------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }
        //-------------- Metodos de soporte de BD ---------------------------------
        // -------------------------------------------------------------------------
        // -- Metodo abstracto encargado de establecer los nombres de los campos
        // -- (atributos) de la tabla. Se deben implementar necesariamente
        // -- en los herederos como arreglos de cadenas.
        // -- Estos atributos deben concidir con los existentes en la Base de Datos
        // --------------------------------------------------------------------------
        public abstract string[] NombresAtributos();
        // -------------------------------------------------------------------
        // --- Metodos para el mantenimiento de la tabla
        // ---------------------------------------------------------------------
        // --------------- Insercion de nuevos registros -----------------------
        public virtual void Insertar(params string[] Atributos)
        { 
            //-- Permite insertar informacion de un registro en la tabla
            //-- Recuperar los valores de los atributos
            aValores = Atributos;
            //-- Formar la cadena de insercion
            string CadenaInsertar = "insert into " + aNombreTabla + " values ('";
            for (int k = 0; k < aValores.Length; k++)
            { //-- incluir los atributos en la consulta
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                    //-- se concatenó el ultimo atributo. Terminar la consulta.
                    CadenaInsertar += "')";
                else //-- dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "', '";
            }
            // Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;

        }
        // --------------- Actualizacion de registros --------------------------
        public void Actualizar(params string[] Atributos)
        { 
            //-- Permite actualizar la informacion de un registro de la tabla
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;
            //-- Formar la cadena de actualizacion.
            //-- Se asume que la clave principal es el primer atributo (Posicion CERO)
            string CadenaActualizar = "update " + aNombreTabla + " set ";
            for (int k = 1; k < aValores.Length; k++)
            { //-- incluir los atributos en la consulta
                CadenaActualizar += aNombres[k] + "= '" + aValores[k];
                if (k == aValores.Length - 1)
                    //-- se concatenó el ultimo atributo. Terminar asignacion de valores
                    CadenaActualizar += "'";
                else //-- dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "', ";
            }
            //-- Agregar a la consulta la clausula WHERE
            CadenaActualizar += " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //-- Ejecutar la consulta para actualizar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }
        // --------------------- Eliminación de un registro ------------------------
        public void Eliminar(params string[] Atributos)
        { 
            //-- Permite eliminar un registro
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;
            //-- Formar la cadena de eliminacion
            string CadenaEliminar = "delete from " + aNombreTabla +
            " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarComando(CadenaEliminar);
        }
        // -------------------------------------------------------------------
        public bool ExisteClavePrimaria(params string[] Atributos)
        { 
            // verifica si un registro especifico existe
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;
            //-- Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla +

            " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        // -------------------------------------------------------------------
        public DataTable Registro(params string[] Atributos)
        { 
            //-- Recupera la informacion de un registro

            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;
            //-- Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta y devolver el resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        // ---------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        { 
            //-- Recupera el valor de un atributo del dataset
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        //----------------------------------------------------------------------
        public DataTable ListaGeneral()
        { 
            //-- retorna una tabla con la lista completa de libros
            string Consulta = "select * from " + aNombreTabla;
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
