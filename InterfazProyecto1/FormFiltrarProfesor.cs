using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace InterfazProyecto1
{
    public partial class FormFiltrarProfesor : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormFiltrarProfesor(FormMenu menu)
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

        private void btnFiltroAtleta_Click(object sender, EventArgs e)
        {
            switch (cbTipoBusqueda.SelectedIndex)
            {
                case 0:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE ID_profesor = '" + num.Text + "'";
                    break;
                case 1:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Cedula = '" + num.Text + "'";
                    break;
                case 2:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Nombre = '" + tbValorBusqueda.Text + "'";
                    break;
                case 3:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Apellido = '" + tbValorBusqueda.Text + "'";
                    break;
                case 4:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Edad = '" + num.Text + "'";
                    break;
                case 5:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Sexo = '" + cbValor.SelectedItem?.ToString() ?? (object)DBNull.Value + "'";
                    break;
                case 6:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Fecha_nacimiento = '" + dateFechaNacimiento.Value.ToString("yyyy-MM-dd") + "'";
                    break;
                case 7:
                    query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor WHERE Escuela = '" + tbValorBusqueda.Text + "'";
                    break;
            }

            FiltrarProfesor();
        }

        private void FiltrarProfesor()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abrir la conexión

                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase))
                        {
                            DataTable table = new DataTable();

                            // Asignar la tabla como la fuente de datos para dataGridViewAtletas en formMenu
                            formMenu.dataGridViewAtletas.DataSource = table;

                            // Llenar la tabla con los datos obtenidos de la base de datos
                            adapter.Fill(table);
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

        private void cbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipoBusqueda.SelectedIndex)
            {
                case 0:
                    // ID_arbitro
                    tbValorBusqueda.Visible = false;
                    num.Visible = true;
                    num.Maximum = 99999999;
                    cbValor.Visible = false;
                    dateFechaNacimiento.Visible = false;

                    break;
                case 1:
                    // Cedula

                    tbValorBusqueda.Visible = false;
                    num.Visible = true;
                    num.Maximum = 99999999;
                    cbValor.Visible = false;
                    dateFechaNacimiento.Visible = false;

                    break;
                case 4:
                    // Edad

                    tbValorBusqueda.Visible = false;
                    num.Visible = true;
                    num.Maximum = 100;
                    cbValor.Visible = false;
                    dateFechaNacimiento.Visible = false;

                    break;
                case 5:
                    // Sexo

                    tbValorBusqueda.Visible = false;
                    num.Visible = false;
                    cbValor.Visible = true;
                    dateFechaNacimiento.Visible = false;

                    break;
                case 6:
                    // Fecha_nacimiento

                    tbValorBusqueda.Visible = false;
                    num.Visible = false;
                    cbValor.Visible = false;
                    dateFechaNacimiento.Visible = true;

                    break;
                default:
                    tbValorBusqueda.Visible = true;
                    num.Visible = false;
                    cbValor.Visible = false;
                    dateFechaNacimiento.Visible = false;

                    break;
            }
        }
    }
}