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
            return new string[] { "IdCertificado", "Imagen" };
        }
    }
}
