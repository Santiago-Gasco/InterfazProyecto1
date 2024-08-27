using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormAltaAtleta : Form
    {
        FormMenu formMenu;
        public Point mouseLocation;
        public FormAltaAtleta(FormMenu menu)
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

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_atleta;";

        private void btnAltaAtleta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tb_atleta (Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela) VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Sexo, @Fecha_nacimiento, @Federado, @Escuela)";

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
                            MessageBox.Show("Atleta creado exitosamente!");
                            tbCedula.Text = string.Empty;
                            tbNombre.Text = string.Empty;
                            tbApellido.Text = string.Empty;
                            numEdad.Value = 1;
                            cbGenero.SelectedIndex = -1;
                            dateFechaNacimiento.Value = DateTime.Now;
                            numFederado.Value = 0;
                            tbEscuela.Text = string.Empty;

                            this.formMenu = formMenu;

                            formMenu.ListarAtletas();
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