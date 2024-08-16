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
    public partial class FormMenu : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;";
        bool menuExpandido = true;
        bool dataGridViewExpandido;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ListarAtletas();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                flowLayoutPanel1.Width -= 10;

                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    menuExpandido = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;

                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)
                {
                    menuExpandido = true;
                    timerMenu.Stop();
                }
            }
        }

        private void timerDataGridView_Tick(object sender, EventArgs e)
        {
            if (dataGridViewExpandido)
            {
                int posX = Ventana.Location.X + 10;
                Ventana.Location = new Point(posX, 46);

                if (posX >= 195)
                {
                    dataGridViewExpandido = false;
                    timerDataGridView.Stop();
                }
            }
            else
            {
                int posX = Ventana.Location.X - 10;
                Ventana.Location = new Point(posX, 46);

                if (posX <= 69)
                {
                    dataGridViewExpandido = true;
                    timerDataGridView.Stop();
                }
            }
        }

        private void ListarAtletas()
        {
            string query = "SELECT ID_atleta, Cedula, Nombre, Apellido, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open();
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase))
                        {
                            DataTable table = new DataTable();

                            // Convertir la columna de fecha a string si es necesario
                            foreach (DataRow row in table.Rows)
                            {
                                row["Fecha_nacimiento"] = Convert.ToDateTime(row["Fecha_nacimiento"]).ToString("yyyy-MM-dd");
                            }

                            dataGridViewAtletas.DataSource = table;
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            timerDataGridView.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void dataGridViewAtletas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarAtleta_Click(object sender, EventArgs e)
        {

        }

        private void btnBorarAtleta_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarAtleta_Click(object sender, EventArgs e)
        {

        }

        private void btnListarAtleta_Click(object sender, EventArgs e)
        {
            dataGridViewAtletas.Show();
        }
    }
}
