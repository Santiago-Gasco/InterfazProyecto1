using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormCargarFixture : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormCargarFixture(FormMenu menu)
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

        private void btnBajaAtleta_Click(object sender, EventArgs e)
        {
            formMenu.CargarFixture(cbTipoBusqueda.SelectedItem.ToString());
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

        private void cbTipoBusqueda_DropDown(object sender, EventArgs e)
        {
            query = "SELECT Nombre FROM tb_eventos";

            AlmacenarEventosExistentes();
        }

        private void AlmacenarEventosExistentes()
        {
            cbTipoBusqueda.Items.Clear();

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string evento = reader["Nombre"].ToString();

                                cbTipoBusqueda.Items.Add(evento);
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
    }
}