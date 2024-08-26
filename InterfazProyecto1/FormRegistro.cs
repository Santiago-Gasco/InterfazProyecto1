using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormRegistro : Form
    {
        public Point mouseLocation;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;";

        public void CrearUsuario()
        {
            if (tbNombreRegistro.Text != "" && tbContraseñaRegistro.Text != "" && tbNombreRegistro.Text != "Nombre" && tbContraseñaRegistro.Text != "Contraseña")
            {
                string checkQuery = "SELECT COUNT(*) FROM tb_usuario WHERE Nombre = @nombre AND Contraseña = @contraseña";

                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        databaseConnection.Open();
                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, databaseConnection))
                        {
                            checkCommand.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text);
                            checkCommand.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text);

                            int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (userExists > 0)
                            {
                                MessageBox.Show("El usuario ya existe, ingrese otros valores");
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO tb_usuario (Nombre, Contraseña, Rol) VALUES (@nombre, @contraseña, @rol)";
                                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, databaseConnection))
                                {
                                    insertCommand.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text);
                                    insertCommand.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text);
                                    insertCommand.Parameters.AddWithValue("@rol", "Super Admin");

                                    int rowsAffected = insertCommand.ExecuteNonQuery();

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
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        private void tbNombreRegistro_TextChanged(object sender, EventArgs e)
        {
            if (tbNombreRegistro.Text == "")
            {
                tbNombreRegistro.ForeColor = Color.Gray;
            }
        }

        private void tbNombreRegistro_Enter(object sender, EventArgs e)
        {
            if (tbNombreRegistro.ForeColor == Color.Gray)
            {
                tbNombreRegistro.Text = "";
                tbNombreRegistro.ForeColor = Color.Black;
            }
        }

        private void tbNombreRegistro_Leave(object sender, EventArgs e)
        {
            if (tbNombreRegistro.Text == "")
            {
                tbNombreRegistro.Text = "Nombre";
                tbNombreRegistro.ForeColor = Color.Gray;
            }
        }

        private void tbContraseñaRegistro_Enter(object sender, EventArgs e)
        {
            if (tbContraseñaRegistro.ForeColor == Color.Gray)
            {
                tbContraseñaRegistro.Text = "";
                tbContraseñaRegistro.ForeColor = Color.Black;
            }
        }

        private void tbContraseñaRegistro_Leave(object sender, EventArgs e)
        {
            if (tbContraseñaRegistro.Text == "")
            {
                tbContraseñaRegistro.Text = "Nombre";
                tbContraseñaRegistro.ForeColor = Color.Gray;
            }
        }

        private void tbContraseñaRegistro_TextChanged(object sender, EventArgs e)
        {
            if (tbContraseñaRegistro.Text == "")
            {
                tbContraseñaRegistro.ForeColor = Color.Gray;
            }
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
