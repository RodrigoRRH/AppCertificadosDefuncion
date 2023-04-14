using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmActaPadre : DevExpress.XtraEditors.XtraForm
    {
        public FrmActaPadre()
        {
            InitializeComponent();
            //como generar codigos consecutivos autonumericos dado un rango en c#, ejemplo: de 00100 a 00105 y el resultado sería 00101, 00102, 00103, 00104 y 00105; otro ejemplo de 00010 a 00012 y el resultado sería 00010, 00011 y 00012
        }
    }
}