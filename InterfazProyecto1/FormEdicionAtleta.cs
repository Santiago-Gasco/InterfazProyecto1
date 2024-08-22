using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class FormEdicionAtleta : Form
    {
        FormMenu formMenu;

        public FormEdicionAtleta(FormMenu menu)
        {
            InitializeComponent();
            this.formMenu = menu;
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAltaAtleta_Load(object sender, EventArgs e)
        {

        }

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;";

        private void btnEditarAtleta_Click(object sender, EventArgs e)
        {
            string query;

            if (cbTipoBusqueda.SelectedIndex == 0)
            {
                query = "UPDATE tb_atleta SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Sexo = @Sexo, Fecha_nacimiento = @Fecha_nacimiento, Federado = @Federado, Escuela = @Escuela WHERE ID_atleta = " + tbValorBusqueda.Text;
            }
            else if (cbTipoBusqueda.SelectedIndex == 1)
            {
                query = "UPDATE tb_atleta SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Sexo = @Sexo, Fecha_nacimiento = @Fecha_nacimiento, Federado = @Federado, Escuela = @Escuela WHERE Cedula = " + tbValorBusqueda.Text;
            }
            else
            {
                query = "UPDATE tb_atleta SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Sexo = @Sexo, Fecha_nacimiento = @Fecha_nacimiento, Federado = @Federado, Escuela = @Escuela WHERE Federado = " + tbValorBusqueda.Text;
            }

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Reemplaza los valores de ejemplo con los datos deseados
                        commandDatabase.Parameters.AddWithValue("@Cedula", tbCedula.Text);
                        commandDatabase.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                        commandDatabase.Parameters.AddWithValue("@Apellido", tbApellido.Text);
                        commandDatabase.Parameters.AddWithValue("@Edad", Convert.ToInt32(numEdad.Value));
                        commandDatabase.Parameters.AddWithValue("@Sexo", cbGenero.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        commandDatabase.Parameters.AddWithValue("@Fecha_nacimiento", dateFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                        commandDatabase.Parameters.AddWithValue("@Federado", Convert.ToInt32(numFederado.Value));
                        commandDatabase.Parameters.AddWithValue("@Escuela", tbEscuela.Text);

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atleta actualizado exitosamente!");
                            tbCedula.Text = string.Empty;
                            tbNombre.Text = string.Empty;
                            tbApellido.Text = string.Empty;
                            numEdad.Value = 1;
                            cbGenero.SelectedIndex = -1;
                            dateFechaNacimiento.Value = DateTime.Now;
                            numFederado.Value = 0;
                            tbEscuela.Text = string.Empty;

                            if (formMenu != null)
                            {
                                formMenu.ListarAtletas();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el atleta. Inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }

        private void buscarAtleta()
        {
            if (tbValorBusqueda.Text != "")
            {
                string query;

                if (cbTipoBusqueda.SelectedIndex == 0)
                {
                    query = "SELECT Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta WHERE ID_atleta = " + tbValorBusqueda.Text;
                }
                else if (cbTipoBusqueda.SelectedIndex == 1)
                {
                    query = "SELECT Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta WHERE Cedula = " + tbValorBusqueda.Text;
                }
                else
                {
                    query = "SELECT Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta WHERE Federado = " + tbValorBusqueda.Text;
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
                                    // Asigna los valores obtenidos a los controles del formulario
                                    tbCedula.Text = reader["Cedula"].ToString();
                                    tbNombre.Text = reader["Nombre"].ToString();
                                    tbApellido.Text = reader["Apellido"].ToString();
                                    numEdad.Value = Convert.ToInt32(reader["Edad"]);
                                    cbGenero.SelectedItem = reader["Sexo"].ToString();
                                    dateFechaNacimiento.Value = Convert.ToDateTime(reader["Fecha_nacimiento"]);
                                    numFederado.Value = Convert.ToInt32(reader["Federado"]);
                                    tbEscuela.Text = reader["Escuela"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el atleta con valor proporcionado.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos del atleta: " + ex.Message);
                    }
                }
            }
        }

        private void tbValorBusqueda_Leave(object sender, EventArgs e)
        {
            buscarAtleta();
        }

        private void cbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarAtleta();
        }
    }
}