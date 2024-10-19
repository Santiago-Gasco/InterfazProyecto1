using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace InterfazProyecto1
{
    public partial class FormTerminarRanking : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormTerminarRanking(FormMenu menu)
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

        private void btnTerminarRanking_Click(object sender, EventArgs e)
        {
            TerminarRanking();
        }

        private void TerminarRanking()
        {
            string query = "UPDATE tb_atleta SET Puntos = 0"; // Variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)) // Instancia de la clase MySqlCommand llamada commandDatabase que se usara para ejecutar una consulta en la base de datos
                    {
                        commandDatabase.CommandTimeout = 60; // Crea un tiempo de espera antes de terminar el intento de ejecución de error

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase)) // Instancia de la clase MySqlDataAdapter llamada adapter que se usara para llenar un conjunto de datos en memoria con los resultados de la consulta SQL
                        {
                            DataTable table = new DataTable(); // Instancia de la clase DataTable llamada table que se usara para crear una tabla de datos

                            adapter.Fill(table); // Llena la instancia table con los datos de la base de datos

                            // Lo llama 2 veces para asegurarse de que el ranking este bien ordenado
                            formMenu.ListarAtletasPorRanking();
                            formMenu.ListarAtletasPorRanking();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message); // Muestra un cuadro de mensaje con el error
                }
            }
        }
    }
}