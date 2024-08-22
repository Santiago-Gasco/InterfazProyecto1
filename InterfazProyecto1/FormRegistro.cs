using System;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_atleta;";

        public void CrearUsuario()
        {
            string query = "INSERT INTO tb_usuario (Nombre, Contraseña, Rol) VALUES (@nombre, @contraseña, @rol)";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Reemplaza los valores de ejemplo con los datos deseados
                        commandDatabase.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text);
                        commandDatabase.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text);
                        commandDatabase.Parameters.AddWithValue("@rol", "Super Admin"); // Asegúrate de tener un campo para Rol en tu formulario

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario creado exitosamente!");
                            FormLogin formLogin = new FormLogin();
                            formLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el usuario. Inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
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
    }
}
