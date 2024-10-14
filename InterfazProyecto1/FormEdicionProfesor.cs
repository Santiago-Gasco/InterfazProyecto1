using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormEdicionProfesor : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormEdicionProfesor(FormMenu menu)
        {
            InitializeComponent();
            this.formMenu = menu; // Iguala la variable formMenu a la variable menu que le paso el FormMenu al ser llamado
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Iguala el estado de la ventana actual a minimizado
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_qubeware;";

        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.SelectedIndex == 0) //Verifica la posicion del combobox
            {
                query = "UPDATE tb_profesor SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Sexo = @Sexo, Fecha_nacimiento = @Fecha_nacimiento, Escuela = @Escuela WHERE ID_profesor = " + tbValorBusqueda.Text; //Si el valor del combobox es 0 = Id_atleta
            }
            else
            {
                query = "UPDATE tb_profesor SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Sexo = @Sexo, Fecha_nacimiento = @Fecha_nacimiento, Escuela = @Escuela WHERE Cedula = " + tbValorBusqueda.Text; //Si el valor del combobox es 1 = Cedula
            }

            EditarProfesor();
        }

        private void EditarProfesor()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Cambia los valores del atleta a los valores de TextBox, ComboBox, NumericUpDown y DateTimePicker
                        commandDatabase.Parameters.AddWithValue("@Cedula", Convert.ToInt32(numCedula.Value));
                        commandDatabase.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                        commandDatabase.Parameters.AddWithValue("@Apellido", tbApellido.Text);
                        commandDatabase.Parameters.AddWithValue("@Edad", Convert.ToInt32(numEdad.Value));
                        commandDatabase.Parameters.AddWithValue("@Sexo", cbGenero.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        commandDatabase.Parameters.AddWithValue("@Fecha_nacimiento", dateFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                        commandDatabase.Parameters.AddWithValue("@Escuela", tbEscuela.Text);

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profesor actualizado exitosamente!");
                            // Cambia los valores de los TextBox, ComboBox, NumericUpDown y DateTimePicker a nulos o valor por defecto
                            numCedula.Value = 1;
                            tbNombre.Text = string.Empty;
                            tbApellido.Text = string.Empty;
                            numEdad.Value = 1;
                            cbGenero.SelectedIndex = -1;
                            dateFechaNacimiento.Value = DateTime.Now;
                            tbEscuela.Text = string.Empty;

                            formMenu.ListarProfesores();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el profesor. Inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }

        private void BuscarProfesor() //Busca el atleta y lo agrega a los editores de texto
        {
            if (tbValorBusqueda.Text != "")
            {
                string query;

                if (cbTipoBusqueda.SelectedIndex == 0) //Verifica la posicion del combobox
                {
                    query = "SELECT Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE ID_profesor = " + tbValorBusqueda.Text; //Si el valor del combobox es 0 = Id_atleta
                }
                else
                {
                    query = "SELECT Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Cedula = " + tbValorBusqueda.Text; //Si el valor del combobox es 1 = Cedula
                }

                using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        databaseConnection.Open(); // Abre la conexión
                        using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                        {
                            using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Cambia los valores de los TextBox, ComboBox, NumericUpDown y DateTimePicker a los valores del profesor
                                    numCedula.Value = Convert.ToInt32(reader["Cedula"]);
                                    tbNombre.Text = reader["Nombre"].ToString();
                                    tbApellido.Text = reader["Apellido"].ToString();
                                    numEdad.Value = Convert.ToInt32(reader["Edad"]);
                                    cbGenero.SelectedItem = reader["Sexo"].ToString();
                                    dateFechaNacimiento.Value = Convert.ToDateTime(reader["Fecha_nacimiento"]);
                                    tbEscuela.Text = reader["Escuela"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el profesor con valor proporcionado.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos del profesor: " + ex.Message);
                    }
                }
            }
        }

        private void tbValorBusqueda_Leave(object sender, EventArgs e)
        {
            BuscarProfesor();
        }

        private void cbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarProfesor();
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