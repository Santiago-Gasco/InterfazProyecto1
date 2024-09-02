using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormMenu : Form
    {
        public Point mousePos;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_atleta;"; //esta variable de tipo string contiene todo lo necesario para poder conectar el programa con la base de datos
        bool menuExpandido = true; //esta variable de tipo bool determina el estado del menu, es decir si se muestra de forma parcial o de forma total
        bool dataGridViewExpandido; //esta variable de tipo bool determina el tamaño que debe de tener la cuadricula donde se listan los atletas ingresados en la base de datos

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ListarAtletas(); //ejecuta el metodo para listar los atletas
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido) //if en la que dependiendo del estado de la variable menuExpandido el grosor del panel 1 aumenta o disminuye
            {
                panelPrincipalOpciones.Width -= 10;

                if (panelPrincipalOpciones.Width == panelPrincipalOpciones.MinimumSize.Width)
                {
                    menuExpandido = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                panelPrincipalOpciones.Width += 10;

                if (panelPrincipalOpciones.Width == panelPrincipalOpciones.MaximumSize.Width)
                {
                    menuExpandido = true;
                    timerMenu.Stop();
                }
            }
        }

        private void timerDataGridView_Tick(object sender, EventArgs e)
        {
            if (dataGridViewExpandido) //if en el que dependiendo del estado de la variable dataGridViewExpandido se cambia la posición de la Ventana
            {
                int posX = panelListaAtletas.Location.X + 10;
                panelListaAtletas.Location = new Point(posX, 46);

                if (posX >= 195)
                {
                    dataGridViewExpandido = false;
                    timerDataGridView.Stop();
                }
            }
            else
            {
                int posX = panelListaAtletas.Location.X - 10;
                panelListaAtletas.Location = new Point(posX, 46);

                if (posX <= 69)
                {
                    dataGridViewExpandido = true;
                    timerDataGridView.Stop();
                }
            }
        }

        public void ListarAtletas() //Método encargado de listar los atletas
        {
            string query = "SELECT ID_atleta, Cedula, Nombre, Apellido, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Crear una tabla temporal y copiar los datos
                    string createTempTableQuery = @"
                        CREATE TEMPORARY TABLE tb_atleta_temp AS
                        SELECT Id_atleta, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela
                        FROM tb_atleta
                        ORDER BY Id_atleta;";
                    using (var createTempTableCommand = new MySqlCommand(createTempTableQuery, databaseConnection))
                    {
                        createTempTableCommand.ExecuteNonQuery();
                    }

                    // Agregar una columna de IDs secuenciales
                    string addTempIdColumnQuery = "ALTER TABLE tb_atleta_temp ADD COLUMN new_id INT AUTO_INCREMENT PRIMARY KEY;";
                    using (var addTempIdColumnCommand = new MySqlCommand(addTempIdColumnQuery, databaseConnection))
                    {
                        addTempIdColumnCommand.ExecuteNonQuery();
                    }

                    // Actualizar los IDs en la tabla original
                    string updateOriginalTableQuery = @"
                        UPDATE tb_atleta a
                        JOIN tb_atleta_temp t ON a.Id_atleta = t.Id_atleta
                        SET a.Id_atleta = t.new_id;";
                    using (var updateOriginalTableCommand = new MySqlCommand(updateOriginalTableQuery, databaseConnection))
                    {
                        updateOriginalTableCommand.ExecuteNonQuery();
                    }

                    // Restablecer AUTO_INCREMENT
                    string resetAutoIncrementQuery = "ALTER TABLE tb_atleta AUTO_INCREMENT = 1;";
                    using (var resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, databaseConnection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }

                    // Eliminar la tabla temporal
                    string dropTempTableQuery = "DROP TEMPORARY TABLE IF EXISTS tb_atleta_temp;";
                    using (var dropTempTableCommand = new MySqlCommand(dropTempTableQuery, databaseConnection))
                    {
                        dropTempTableCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                try
                {
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)) //instancia de la clase MySqlCommand llamada commandDatabase que se usara para ejecutar una consulta en la base de datos
                    {
                        commandDatabase.CommandTimeout = 60; //Crea un tiempo de espera antes de terminar el intento de ejecución de error

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase)) //instancia de la clase MySqlDataAdapter llamada adapter que se usara para llenar un conjunto de datos en memoria con los resultados de la consulta SQL
                        {
                            DataTable table = new DataTable(); //instancia de la clase DataTable llamada table que se usara para crear una tabla de datos

                            // Convertir la columna de fecha a string si es necesario
                            foreach (DataRow row in table.Rows) //recorre todas las filas de la tabla
                            {
                                row["Fecha_nacimiento"] = Convert.ToDateTime(row["Fecha_nacimiento"]).ToString("yyyy-MM-dd"); //convierte los datos de la Fecha de nacimiento en una variable tipo DateTime y después los convierte de nuevo en una variable de tipo string
                            }

                            dataGridViewAtletas.DataSource = table; //asigna la instancia table como la fuente de los datos para dataGridViewAtletas
                            adapter.Fill(table); //llena la instancia table con los datos de la base de datos
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message); //Muestra un cuadro de mensaje con el error
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            timerDataGridView.Start();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close(); //hace que se cierre la ventana
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimiza la ventana
        }

        private void btnAgregarAtleta_Click(object sender, EventArgs e)
        {
            FormAltaAtleta formAltaAtleta = new FormAltaAtleta(this); //crea una nueva instancia del formulario para el alta de los atletas
            formAltaAtleta.Show(); //muestra el formulario para el atla de los atletas
        }

        private void btnBorarAtleta_Click(object sender, EventArgs e)
        {
            FormBajaAtleta formBajaAtleta = new FormBajaAtleta(this); //crea una nueva instancia del formulario para la baja de los atletas
            formBajaAtleta.Show(); //muestra el formulario para la baja de atletas
        }

        private void btnEditarAtleta_Click(object sender, EventArgs e)
        {
            FormEdicionAtleta formEdicionAtleta = new FormEdicionAtleta(this); //crea una nueva instancia del formulario para la edición de los atletas
            formEdicionAtleta.Show(); //muestra el formulario para la edición de los atletas.
        }

        private void btnListarAtleta_Click(object sender, EventArgs e)
        {
            dataGridViewAtletas.Show(); //muestra la cuadricula de datos con los datos de los atletas
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ListarAtletas(); //ejecuta el metodo para listar los atletas
        }

        private void panelSuperiorVentana_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = new Point(-e.X, -e.Y);
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
