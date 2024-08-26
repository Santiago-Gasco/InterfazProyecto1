using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;"; //esta variable de tipo string contiene todo lo necesario para poder conectar el programa con la base de datos

        public void CrearUsuario()
        {
            if (tbNombreRegistro.Text != "" && tbContraseñaRegistro.Text != "" && tbNombreRegistro.Text != "Nombre" && tbContraseñaRegistro.Text != "Contraseña") //if que comprueba que todos los campos no esten vacios ni sean "Nombre" y "Contraseña"
            {
                string checkQuery = "SELECT COUNT(*) FROM tb_usuario WHERE Nombre = @nombre AND Contraseña = @contraseña"; //variable de tipo string que contiene el comando para contar los usuarios existentes en la base de datos donde los campos de Nombre y Contraseña sean iguales a los de los parametros @nombre y @contraseña

                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //crea una conexión con la base de datos
                {
                    try
                    {
                        databaseConnection.Open(); //abre la conexión de la base de datos
                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, databaseConnection)) //instancia de la clase MySqlCommand llamada checkCommand que se usara para contar los usuarios exientes en la base de datos
                        {
                            checkCommand.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text); //agrega un parametro al comando checkCommand en base al contenido de tbNombreRegistro.Text
                            checkCommand.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text); //agrega un parametro al comando checkCommand en base al contenido de tbContraseñaRegistro.Text

                            int userExists = Convert.ToInt32(checkCommand.ExecuteScalar()); //variable de tipo int que expresa de forma numerica si existe un usuario que cumpla con las condiciones de checkCommand

                            if (userExists > 0) //Si la variable userExists es mayor a cero pasa lo siguiente
                            {
                                MessageBox.Show("El usuario ya existe, ingrese otros valores"); //Muestra una caja de mensaje que indica que ya existe un usuario con esos valores y pida que se ingresen valores distintos
                            }
                            else //Si la condición no es cumplida, es decir userExists es igual o menor a cero pasa lo siguiente
                            {
                                string insertQuery = "INSERT INTO tb_usuario (Nombre, Contraseña, Rol) VALUES (@nombre, @contraseña, @rol)"; //variable de tipo string que contiene el comando para ingresar un nuevo usuario en la base de datos
                                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, databaseConnection)) //instancia de la clase MySqlCommand llamada insertCommand que se usara para insertar un nuevo usuario en la tabla de datos
                                {
                                    insertCommand.Parameters.AddWithValue("@nombre", tbNombreRegistro.Text); //agrega un parametro al comando insertCommand en base al contenido de tbNombreRegistro.Text
                                    insertCommand.Parameters.AddWithValue("@contraseña", tbContraseñaRegistro.Text); //agrega un parametro al comando insertCommand en base al contenido de tbNombreRegistro.Text
                                    insertCommand.Parameters.AddWithValue("@rol", "Super Admin"); //agrega un parametro al comando insertCommand predeterminado, en este caso el rol de "Super Admin"

                                    int rowsAffected = insertCommand.ExecuteNonQuery(); //variable de tipo int que cuenta la cantidad de filas afectadas 

                                    if (rowsAffected > 0) //Si la variable rowsAffected es mayor a cero pasa lo siguiente
                                    {
                                        MessageBox.Show("Usuario creado exitosamente!"); //se muestra una caja de mensaje informando la creación exitosa del usuario.
                                        FormEleccionLoginRegistro formEleccionLoginRegistro = new FormEleccionLoginRegistro(); 
                                        formEleccionLoginRegistro.Show();
                                        this.Hide();
                                    }
                                    else //si la condicion no es cumplida, es decir rowsAffected es menor o igual a cero pasa lo siguiente
                                    {
                                        MessageBox.Show("No se pudo crear el usuario. Inténtelo de nuevo."); //se muestra una caja de mensaje que informa que falló la creación del usuario y que se intente de nuevo
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inesperado: " + ex.Message); //Muestra un mensaje de error
                    }
                }
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos"); //Muestra una caja de mensaje que avisa que el nombre o la contraseña no cumplen alguna de las condiciones
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
    }
}
