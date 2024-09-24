using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormRegistro : Form
    {
        public Point mousePos;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_qubeware;";

        public void AltaUsuario()
        {
            if (tbNombreRegistro.Text != "" && tbContraseñaRegistro.Text != "" && tbNombreRegistro.Text != "Nombre" && tbContraseñaRegistro.Text != "Contraseña") // Si los textbox no son vacios y no tienen el valor por defecto se ejecuta el void
            {
                string query = "SELECT COUNT(*) FROM tb_usuario WHERE Nombre = @nombre AND Contraseña = @contraseña";

                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        databaseConnection.Open();
                        using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                        {
                            // Añade los parametros nombre y contraseña al comando
                            commandDatabase.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text);
                            commandDatabase.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text);

                            int userExists = Convert.ToInt32(commandDatabase.ExecuteScalar());

                            if (userExists > 0)
                            {
                                MessageBox.Show("El usuario ya existe, ingrese otros valores");
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO tb_usuario (Nombre, Contraseña, Rol) VALUES (@nombre, @contraseña, @rol)";

                                using (MySqlCommand commandDatabase2 = new MySqlCommand(insertQuery, databaseConnection))
                                {
                                    // Añade los parametros nombre y contraseña a el comando a ejecutar
                                    commandDatabase2.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text);
                                    commandDatabase2.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text);
                                    commandDatabase2.Parameters.AddWithValue("@rol", "Super Admin");

                                    int rowsAffected = commandDatabase2.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Usuario creado exitosamente!");
                                        FormEleccionLoginRegistro formEleccionLoginRegistro = new FormEleccionLoginRegistro();
                                        formEleccionLoginRegistro.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo crear el usuario. Inténtelo de nuevo.");
                                    }
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
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos");
            }
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Iguala el estado de la ventana actual a minimizado
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            //
            FormEleccionLoginRegistro formEleccion = new FormEleccionLoginRegistro();
            formEleccion.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            AltaUsuario();
        }

        private void tbNombreRegistro_Enter(object sender, EventArgs e)
        {
            if (tbNombreRegistro.ForeColor == Color.Gray) // Si el color de el textbox es gris deja el texto nulo y el color en negro
            {
                tbNombreRegistro.Text = "";
                tbNombreRegistro.ForeColor = Color.Black;
            }
        }

        private void tbNombreRegistro_Leave(object sender, EventArgs e)
        {
            if (tbNombreRegistro.Text == "") // Si el textbox esta vacio iguala el texto a "Nombre" y deja el color en gris
            {
                tbNombreRegistro.Text = "Nombre";
                tbNombreRegistro.ForeColor = Color.Gray;
            }
        }

        private void tbContraseñaRegistro_Enter(object sender, EventArgs e)
        {
            if (tbContraseñaRegistro.ForeColor == Color.Gray) // Si el color de el textbox es gris deja el texto nulo y el color en negro
            {
                tbContraseñaRegistro.Text = "";
                tbContraseñaRegistro.ForeColor = Color.Black;
            }
        }

        private void tbContraseñaRegistro_Leave(object sender, EventArgs e)
        {
            if (tbContraseñaRegistro.Text == "") // Si el textbox esta vacio iguala el texto a "Contraseña" y deja el color en gris
            {
                tbContraseñaRegistro.Text = "Nombre";
                tbContraseñaRegistro.ForeColor = Color.Gray;
            }
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
