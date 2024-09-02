using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormLogin : Form
    {
        public Point mousePos;

        public FormLogin()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_atleta;";

        public void Login()
        {
            string query = "SELECT * FROM tb_usuario WHERE Nombre=@nombre AND Contraseña=@contraseña";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;
                        commandDatabase.Parameters.AddWithValue("@nombre", tbNombre.Text);
                        commandDatabase.Parameters.AddWithValue("@contraseña", tbContraseña.Text);

                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Logeado exitosamente!");
                                FormMenu formMenu = new FormMenu();
                                formMenu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            FormEleccionLoginRegistro formEleccion = new FormEleccionLoginRegistro();
            formEleccion.Show();
            this.Hide();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.ForeColor == Color.Gray) // Si el color de el textbox es gris deja el texto nulo y el color en negro
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Black;
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e) // Si el textbox esta vacio iguala el texto a "Nombre" y deja el color en gris
        {
            if (tbNombre.Text == "")
            {
                tbNombre.Text = "Nombre";
                tbNombre.ForeColor = Color.Gray;
            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.ForeColor == Color.Gray) // Si el color de el textbox es gris deja el texto nulo y el color en negro
            {
                tbContraseña.Text = "";
                tbContraseña.ForeColor = Color.Black;
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "") // Si el textbox esta vacio iguala el texto a "Contraseña" y deja el color en gris
            {
                tbContraseña.Text = "Contraseña";
                tbContraseña.ForeColor = Color.Gray;
            }
        }

        private void panelSuperiorVentana_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = new Point(-e.X, -e.Y);
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
