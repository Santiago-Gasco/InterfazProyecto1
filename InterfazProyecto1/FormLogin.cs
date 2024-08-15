using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;";

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

        /*
        public void ListarUsuarios()
        {
            string query = "SELECT * FROM tb_usuario";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open();
                    MessageBox.Show("Connected to the database successfully!");

                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                StringBuilder sb = new StringBuilder();
                                while (reader.Read())
                                {
                                    try
                                    {
                                        // Verifica si las columnas existen antes de leer
                                        var id = reader["ID_Usuario"].ToString();
                                        var nombre = reader["Nombre"].ToString();
                                        var contraseña = reader["Contraseña"].ToString();

                                        sb.AppendLine($"ID_Usuario: {id}, Nombre: {nombre}, Contraseña: {contraseña}");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error al leer datos: " + ex.Message + "\n" + ex.StackTrace);
                                    }
                                }
                                MessageBox.Show(sb.ToString(), "Lista de Usuarios");
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron usuarios.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de MySQL: " + ex.Message + "\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
        */


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
