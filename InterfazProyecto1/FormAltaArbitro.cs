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
    public partial class FormAltaArbitro : Form
    {

        FormMenu formMenu;
        public Point mousePos;

        public FormAltaArbitro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_qubeware;";

        string query = "SELECT ID_arbitro, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Rango, Categoría FROM tb_arbitro"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

        private void AltaArbitro()
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
                        commandDatabase.Parameters.AddWithValue("@Rango", cbRango.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        commandDatabase.Parameters.AddWithValue("@Categoria", cbCategoria.SelectedItem?.ToString() ?? (object)DBNull.Value);

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atleta creado exitosamente!");

                            // Cambia los valores de los TextBox, ComboBox, NumericUpDown y DateTimePicker a nulos o valor por defecto
                            numCedula.Value = 0;
                            tbNombre.Text = string.Empty;
                            tbApellido.Text = string.Empty;
                            numEdad.Value = 1;
                            cbGenero.SelectedIndex = -1;
                            dateFechaNacimiento.Value = DateTime.Now;
                            cbRango.SelectedIndex = -1;
                            cbCategoria.SelectedIndex = -1;

                            this.formMenu = formMenu;

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el atleta. Inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }

        }

        private void btnAltaArbitro_Click(object sender, EventArgs e)
        {
            // Si los valores cumple los requisitos se ejecuta el metodo AltaAtleta
            if (numCedula.Value > 9999999 && tbNombre.Text != "" && tbNombre.Text != string.Empty && tbApellido.Text != "" && tbApellido.Text != string.Empty && numEdad.Value >= 10 && cbGenero.SelectedIndex != -1 && dateFechaNacimiento.Value != DateTime.Now && cbGenero.SelectedIndex != -1 && cbCategoria.SelectedIndex != -1)
            {
                AltaArbitro();
            }
            else
            {
                MessageBox.Show("Faltan datos, porfavor verifique y ingrese los datos faltantes");
            }
        }
    }
}
