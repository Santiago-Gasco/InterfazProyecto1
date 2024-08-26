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

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;"; //esta variable de tipo string contiene todo lo necesario para poder conectar el programa con la base de datos

        public void Login()
        {
            string query = "SELECT * FROM tb_usuario WHERE Nombre=@nombre AND Contraseña=@contraseña"; //variable de tipo string que contiene el comando para selecionar todos los usuarios de la tabla tb_usuario donde las columnas Nombre y Contraseña coincidan con los parámetros @nombre y @contraseña

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //crea una conexión con la base de datos 
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión con la base de datos
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)) //instancia de la clase MySqlCommand llamada commandDatabase que se usara para realizar el comando que contiene la variable query en la base de datos
                    {
                        commandDatabase.CommandTimeout = 60; //establece un tiempo de espera de 60 antes de ejecutar commandDatabase
                        commandDatabase.Parameters.AddWithValue("@nombre", tbNombre.Text); //agrega un parametro al comando commandDatabase en base al contenido de tbNombre.Text
                        commandDatabase.Parameters.AddWithValue("@contraseña", tbContraseña.Text); //agrega un parametro al comando commandDatabase en base al contenido de tbContraseña.Text

                        using (MySqlDataReader reader = commandDatabase.ExecuteReader()) //instancia de la clase MySqlDataReader llamada reader que se usara para ejecutar el comando de la instancia commandDatabase y leer los resultados devueltos de su ejecución 
                        {
                            if (reader.HasRows) //Si la instancia reader encontro al menos una fila pasara lo siguiente
                            {
                                MessageBox.Show("Logeado exitosamente!"); //muestra una caja de mensaje informando que sea iniciado sesión correctamente
                                FormMenu formMenu = new FormMenu(); //se abre una nueva ventana del formMenu
                                formMenu.Show(); //se muestra el formMenu
                                this.Hide(); //se oculta esta ventana
                            }
                            else //Si la instancia reader no encontro ninguna fila pasara lo siguiente
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos"); //muestra una caja de mensaje informando que el usuario o la contraseña son incorrectos, es decir que no pudieron ser encontrados en la base de datos
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message); //muestra una caja de mensaje informando sobre un error
                }
            }
        }

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
            if (tbNombre.Text == "")
            {
                tbNombre.ForeColor = Color.Gray;
            }
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

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.ForeColor == Color.Gray)
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Black;
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                tbNombre.Text = "Nombre";
                tbNombre.ForeColor = Color.Gray;
            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.ForeColor == Color.Gray)
            {
                tbContraseña.Text = "";
                tbContraseña.ForeColor = Color.Black;
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "Contraseña";
                tbContraseña.ForeColor = Color.Gray;
            }
        }
    }
}
