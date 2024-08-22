using System;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormBajaAtleta : Form
    {
        FormMenu formMenu;

        public FormBajaAtleta(FormMenu menu)
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

        private void btnBajaAtleta_Click(object sender, EventArgs e)
        {
            string query;

            if (cbTipoBusqueda.SelectedIndex == 0)
            {
                query = "DELETE FROM tb_atleta WHERE ID_atleta = " + tbValorBusqueda.Text;
            }
            else if (cbTipoBusqueda.SelectedIndex == 1)
            {
                query = "DELETE FROM tb_atleta WHERE Cedula = " + tbValorBusqueda.Text;
            }
            else
            {
                query = "DELETE FROM tb_atleta WHERE Federado = " + tbValorBusqueda.Text;
            }

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atleta eliminado exitosamente!");
                            formMenu?.ListarAtletas();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún atleta el valor proporcionada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }
    }
}