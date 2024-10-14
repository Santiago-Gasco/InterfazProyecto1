using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormFiltrarAtleta : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormFiltrarAtleta(FormMenu menu)
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

        private void btnFiltrarAtleta_Click(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.SelectedIndex == 0) //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_arbitro WHERE ID_atleta = " + tbValorBusqueda.Text; //Si el valor del combobox es 0 = Id_atleta
            }
            else if (cbTipoBusqueda.SelectedIndex == 1) //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_atleta WHERE Cedula = " + tbValorBusqueda.Text; //Si el valor del combobox es 1 = Cedula
            }
            else //Verifica la posicion del combobox
            {
                query = "DELETE FROM tb_atleta WHERE Federado = " + tbValorBusqueda.Text; //Si el valor del combobox es 2 = Federado
            }

            FiltrarAtleta();
        }

        private void FiltrarAtleta()
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
                            formMenu.ListarAtletas(); // Llama al metodo de formMenu que lista los atletas (actualiza)
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún atleta con el valor proporcionada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
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