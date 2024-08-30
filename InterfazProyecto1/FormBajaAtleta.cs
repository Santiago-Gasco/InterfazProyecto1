using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormBajaAtleta : Form
    {
        FormMenu formMenu;
        public Point mouseLocation;
        string query;
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

        private string connectionString = "datasource=127.0.0.1;port=3305;username=root;password=;database=db_atleta;";

        private void btnBajaAtleta_Click(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.SelectedIndex == 0) //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_atleta WHERE ID_atleta = " + tbValorBusqueda.Text; //Si el valor del combobox es 0 = Id_atleta
            }
            else if (cbTipoBusqueda.SelectedIndex == 1) //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_atleta WHERE Cedula = " + tbValorBusqueda.Text; //Si el valor del combobox es 1 = Cedula
            }
            else //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_atleta WHERE Federado = " + tbValorBusqueda.Text; //Si el valor del combobox es 2 = Federado
            }

            BajaAtleta();
        }

        private void BajaAtleta()
        {
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

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si se presiono el click izquierdo
            {
                Point mousePose = Control.MousePosition; // Obtiene la posición actual del mouse en la pantalla
                mousePose.Offset(mouseLocation.X, mouseLocation.Y); // Ajusta la posición del mouse sumando las coordenadas de `mouseLocation`.
                Location = mousePose; // Iguala la posicion del panel a la del mouse
            }
        }
    }
}