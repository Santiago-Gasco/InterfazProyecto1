using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormEleccionLoginRegistro : Form
    {
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

        private void btnIniciarSesion_Click(object sender, EventArgs e) //este botón abre la ventana para iniciar sesión
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e) //este botón abre la ventana para registrarte
        {
            FormRegistro registro = new FormRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
