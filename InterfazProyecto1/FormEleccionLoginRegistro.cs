using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormEleccionLoginRegistro : Form
    {
        public Point mousePos;

        public FormEleccionLoginRegistro()
        {
            InitializeComponent();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Iguala el estado de la ventana actual a minimizado
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Crea el formulario login, lo muestra y esconde el formulario actual
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Crea el formulario registro, lo muestra y esconde el formulario actual
            FormRegistro registro = new FormRegistro();
            registro.Show();
            this.Hide();
        }

        private void panelSuperiorVentana_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = new Point(-e.X, -e.Y); // Iguala la variable mousePos a un nuevo punto en la pantalla con las coordenadas x e y del MouseEvent del panel superior de la ventana
        }

        private void panelSuperiorVentana_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si se presiono el click izquierdo
            {
                Point mousePose = Control.MousePosition; // Obtiene la posición actual del mouse en la pantalla
                mousePose.Offset(mousePos.X, mousePos.Y); // Ajusta la posición del mouse sumando las coordenadas de `mouseLocation`.
                Location = mousePose; // Iguala la posicion del panel a la del mouse
            }
        }
    }
}
