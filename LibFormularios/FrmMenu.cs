using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmMenu()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized; //frmMaximizado
        }

        private void itmCargarDatos_Click(object sender, EventArgs e)
        {
            //FrmCargarDatos frmCargarDatos = new FrmCargarDatos
            //{
            //    TopLevel = false
            //};
            ////frmCargarDatos.cona
            //cntInicio.Controls.Add(frmCargarDatos);
            //frmCargarDatos.Dock = DockStyle.Fill;
            //frmCargarDatos.Show();

            //FrmCargarDatos frm = new FrmCargarDatos();
            //AbrirSubForm(frm);
            AbrirFormulario(new FrmCargarDatos());
        }

        // Método para abrir el formulario una sola vez.
        private bool AbrirSubForm(Form form)
        {
            // Verificar si el form ya está abierto.
            foreach (Form f in Application.OpenForms)
            {
                // Si está abierto devuelvo False (no se puede abrir).
                if (f.Name == form.Name)
                    return false;
            }

            // Si se llega a este punto es porque no está abierto.
            // Abro el formulario.
            form.TopLevel = false;
            //frmCargarDatos.cona
            cntInicio.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            //form.Show();


            // Indico apertura exitosa.
            return true;
        }

        public void AbrirFormulario(Form formulario)
        {
            // Verifica si ya hay un formulario abierto
            if (cntInicio.Controls.Count > 0)
            {
                Form formularioAnterior = cntInicio.Controls[0] as Form;
                formularioAnterior.Close();
            }

            // Agregar el nuevo formulario al panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            cntInicio.Controls.Add(formulario);
            formulario.Show();
        }

        private void itmActaEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmActaEntrega());

            //FrmActaEntrega frm = new FrmActaEntrega();
            //AbrirSubForm(frm);// como colocar un label en cualquier posicion dentro de un flowlayoutpanel c# windows forms

            //AbrirFormulario(new FrmActaEntrega());
        }

        private void cntInicio_Paint(object sender, PaintEventArgs e)
        {
            //// Carga la imagen de la marca de agua
            //Image img = pboMarcaAgua.Image;

            //// Establece la opacidad de la imagen (aquí la he establecido en 50%)
            //float opacity = 0.5f;

            //// Crea un pincel para dibujar la imagen
            //Brush brush = new SolidBrush(Color.FromArgb((int)(opacity * 255), Color.White));

            //// Dibuja la imagen en el fondo del formulario
            //e.Graphics.DrawImage(img, new Point(0, 0));

            //// Dibuja el pincel encima de la imagen para establecer la opacidad
            //e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void FrmMenu_Paint(object sender, PaintEventArgs e)
        {
            //// Carga la imagen de la marca de agua
            //Image img = pboMarcaAgua.Image;

            //// Establece la opacidad de la imagen (aquí la he establecido en 50%)
            //float opacity = 0.5f;

            //// Crea un pincel para dibujar la imagen
            //Brush brush = new SolidBrush(Color.FromArgb((int)(opacity * 255), Color.White));

            //// Dibuja la imagen en el fondo del formulario
            //e.Graphics.DrawImage(img, new Point(0, 0));

            //// Dibuja el pincel encima de la imagen para establecer la opacidad
            //e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void itmActaRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmActaRecepcion());
        }

        private void itmActaEntrega2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmActaEntrega());
        }
    }
}
