using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormEleccionLoginRegistro : Form
    {
        public Point mouseLocation;

        public FormEleccionLoginRegistro()
        {
            InitializeComponent();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.Show();
            this.Hide();
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
