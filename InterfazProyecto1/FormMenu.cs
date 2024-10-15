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
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_qubeware;"; //esta variable de tipo string contiene todo lo necesario para poder conectar el programa con la base de datos
        bool menuExpandido = true; //esta variable de tipo bool determina el estado del menu, es decir si se muestra de forma parcial o de forma total
        bool dataGridViewExpandido; //esta variable de tipo bool determina el tamaño que debe de tener la cuadricula donde se listan los atletas ingresados en la base de datos
        int panelAbierto = 0;

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
                // Resta 10 al tamaño del panel cada vez que el timer se ejecuta
                panelPrincipalOpciones.Width -= 10;

                //Cambia el tamaño de los botones a el tamaño minimo
                btnMenu.Size = btnMenu.MinimumSize;
                btnListarAtleta.Size = btnListarAtleta.MinimumSize;
                btnListarArbitro.Size = btnListarArbitro.MinimumSize;
                btnListarProfesor.Size = btnListarProfesor.MinimumSize;
                btnConfiguracion.Size = btnConfiguracion.MinimumSize;

                // Si el tamaño del panel es igual a el tamaño maximo cambia el valor de la variable menuExpandido y termina el timer
                if (panelPrincipalOpciones.Width == panelPrincipalOpciones.MinimumSize.Width)
                {
                    menuExpandido = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                // Suma 10 al tamaño del panel cada vez que el timer se ejecuta
                panelPrincipalOpciones.Width += 10;

                //Cambia el tamaño de los botones a el tamaño maximo
                btnMenu.Size = btnMenu.MaximumSize;
                btnListarAtleta.Size = btnListarAtleta.MaximumSize;
                btnListarArbitro.Size = btnListarArbitro.MaximumSize;
                btnListarProfesor.Size = btnListarProfesor.MaximumSize;
                btnConfiguracion.Size = btnConfiguracion.MaximumSize;

                // Si el tamaño del panel es igual a el tamaño maximo cambia el valor de la variable menuExpandido y termina el timer
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
                // Suma 10 a la posicion x del panel cada vez que el timer se ejecuta
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
                // Resta 10 a la posicion x del panel cada vez que el timer se ejecuta
                int posX = panelListaAtletas.Location.X - 10;
                panelListaAtletas.Location = new Point(posX, 46);

                if (posX <= 69)
                {
                    dataGridViewExpandido = true;
                    timerDataGridView.Stop();
                }
            }
        }

        public void ListarAtletas()
        {
            string query = "SELECT ID_atleta, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Crea una tabla temporal y copia los datos de la tabla original
                    string createTempTableQuery = @"
                        CREATE TEMPORARY TABLE tb_atleta_temp AS
                        SELECT Id_atleta, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela
                        FROM tb_atleta
                        ORDER BY Id_atleta;"; // Crea una tabla temporal, la iguala a la tabla atleta y la pone en orden
                    using (var createTempTableCommand = new MySqlCommand(createTempTableQuery, databaseConnection))
                    {
                        createTempTableCommand.ExecuteNonQuery();
                    }

                    // Agrega la columna id a la tabla temporal y los ordena
                    string addTempIdColumnQuery = "ALTER TABLE tb_atleta_temp ADD COLUMN new_id INT AUTO_INCREMENT PRIMARY KEY;";
                    using (var addTempIdColumnCommand = new MySqlCommand(addTempIdColumnQuery, databaseConnection))
                    {
                        addTempIdColumnCommand.ExecuteNonQuery();
                    }

                    // Actualiza los id a la tabla original
                    string updateOriginalTableQuery = @"
                        UPDATE tb_atleta a
                        JOIN tb_atleta_temp t ON a.Id_atleta = t.Id_atleta
                        SET a.Id_atleta = t.new_id;";
                    using (var updateOriginalTableCommand = new MySqlCommand(updateOriginalTableQuery, databaseConnection))
                    {
                        updateOriginalTableCommand.ExecuteNonQuery();
                    }

                    // Restablece AUTO_INCREMENT
                    string resetAutoIncrementQuery = "ALTER TABLE tb_atleta AUTO_INCREMENT = 1;";
                    using (var resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, databaseConnection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }

                    // Elimina la tabla temporal
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
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)) // Instancia de la clase MySqlCommand llamada commandDatabase que se usara para ejecutar una consulta en la base de datos
                    {
                        commandDatabase.CommandTimeout = 60; // Crea un tiempo de espera antes de terminar el intento de ejecución de error

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase)) // Instancia de la clase MySqlDataAdapter llamada adapter que se usara para llenar un conjunto de datos en memoria con los resultados de la consulta SQL
                        {
                            DataTable table = new DataTable(); // Instancia de la clase DataTable llamada table que se usara para crear una tabla de datos

                            // Convierte la columna de fecha a string si es necesario
                            foreach (DataRow row in table.Rows) // Recorre todas las filas de la tabla
                            {
                                row["Fecha_nacimiento"] = Convert.ToDateTime(row["Fecha_nacimiento"]).ToString("yyyy-MM-dd"); // Convierte los datos de la Fecha de nacimiento en una variable tipo DateTime y después los convierte de nuevo en una variable de tipo string
                            }

                            dataGridViewAtletas.DataSource = table; // Asigna la instancia table como la fuente de los datos para dataGridViewAtletas
                            adapter.Fill(table); // Llena la instancia table con los datos de la base de datos
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message); // Muestra un cuadro de mensaje con el error
                }
            }
        }

        public void ListarArbitros()
        {
            string query = "SELECT ID_arbitro, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Rango, Categoria FROM tb_arbitro"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Crea una tabla temporal y copia los datos de la tabla original
                    string createTempTableQuery = @"
                        CREATE TEMPORARY TABLE tb_arbitro_temp AS
                        SELECT Id_arbitro, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Rango, Categoria FROM tb_arbitro
                        ORDER BY Id_arbitro;"; // Crea una tabla temporal, la iguala a la tabla atleta y la pone en orden
                    using (var createTempTableCommand = new MySqlCommand(createTempTableQuery, databaseConnection))
                    {
                        createTempTableCommand.ExecuteNonQuery();
                    }

                    // Agrega la columna id a la tabla temporal y los ordena
                    string addTempIdColumnQuery = "ALTER TABLE tb_arbitro_temp ADD COLUMN new_id INT AUTO_INCREMENT PRIMARY KEY;";
                    using (var addTempIdColumnCommand = new MySqlCommand(addTempIdColumnQuery, databaseConnection))
                    {
                        addTempIdColumnCommand.ExecuteNonQuery();
                    }

                    // Actualiza los id a la tabla original
                    string updateOriginalTableQuery = @"
                        UPDATE tb_arbitro a
                        JOIN tb_arbitro_temp t ON a.Id_arbitro = t.Id_arbitro
                        SET a.Id_arbitro = t.new_id;";
                    using (var updateOriginalTableCommand = new MySqlCommand(updateOriginalTableQuery, databaseConnection))
                    {
                        updateOriginalTableCommand.ExecuteNonQuery();
                    }

                    // Restablece AUTO_INCREMENT
                    string resetAutoIncrementQuery = "ALTER TABLE tb_arbitro AUTO_INCREMENT = 1;";
                    using (var resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, databaseConnection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }

                    // Elimina la tabla temporal
                    string dropTempTableQuery = "DROP TEMPORARY TABLE IF EXISTS tb_arbitro_temp;";
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

        public void ListarProfesores()
        {
            string query = "SELECT ID_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Crea una tabla temporal y copia los datos de la tabla original
                    string createTempTableQuery = @"
                        CREATE TEMPORARY TABLE tb_profesor_temp AS
                        SELECT Id_profesor, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Escuela FROM tb_profesor
                        ORDER BY Id_profesor;"; // Crea una tabla temporal, la iguala a la tabla atleta y la pone en orden
                    using (var createTempTableCommand = new MySqlCommand(createTempTableQuery, databaseConnection))
                    {
                        createTempTableCommand.ExecuteNonQuery();
                    }

                    // Agrega la columna id a la tabla temporal y los ordena
                    string addTempIdColumnQuery = "ALTER TABLE tb_profesor_temp ADD COLUMN new_id INT AUTO_INCREMENT PRIMARY KEY;";
                    using (var addTempIdColumnCommand = new MySqlCommand(addTempIdColumnQuery, databaseConnection))
                    {
                        addTempIdColumnCommand.ExecuteNonQuery();
                    }

                    // Actualiza los id a la tabla original
                    string updateOriginalTableQuery = @"
                        UPDATE tb_profesor a
                        JOIN tb_profesor_temp t ON a.Id_profesor = t.Id_profesor
                        SET a.Id_profesor = t.new_id;";
                    using (var updateOriginalTableCommand = new MySqlCommand(updateOriginalTableQuery, databaseConnection))
                    {
                        updateOriginalTableCommand.ExecuteNonQuery();
                    }

                    // Restablece AUTO_INCREMENT
                    string resetAutoIncrementQuery = "ALTER TABLE tb_profesor AUTO_INCREMENT = 1;";
                    using (var resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, databaseConnection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }

                    // Elimina la tabla temporal
                    string dropTempTableQuery = "DROP TEMPORARY TABLE IF EXISTS tb_profesor_temp;";
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
            this.Close(); // Cierra la ventana actual
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Iguala el estado de la ventana actual a minimizado
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (panelAbierto)
            {
                case 0:
                    FormAltaAtleta formAltaAtleta = new FormAltaAtleta(this); // Crea una nueva instancia del formulario para el alta de los atletas
                    formAltaAtleta.Show(); // Muestra el formulario para el atla de los atletas
                    break;
                case 1:
                    FormAltaArbitro formAltaArbitro = new FormAltaArbitro(this); // Crea una nueva instancia del formulario para el alta de los arbitros
                    formAltaArbitro.Show(); // Muestra el formulario para el atla de los arbitros
                    break;
                case 2:
                    FormAltaProfesor formAltaProfesor = new FormAltaProfesor(this); ; // Crea una nueva instancia del formulario para el alta de los profesores
                    formAltaProfesor.Show(); // Muestra el formulario para el atla de los profesores
                    break;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            switch (panelAbierto)
            {
                case 0:
                    FormBajaAtleta formBajaAtleta = new FormBajaAtleta(this); // Crea una nueva instancia del formulario para la baja de los atletas
                    formBajaAtleta.Show(); // Muestra el formulario para la baja de atletas
                    break;
                case 1:
                    FormBajaArbitro formBajaArbitro = new FormBajaArbitro(this); // Crea una nueva instancia del formulario para la baja de los arbitros
                    formBajaArbitro.Show(); // Muestra el formulario para la baja de arbitros
                    break;
                case 2:
                    FormBajaProfesor formBajaProfesor = new FormBajaProfesor(this); // Crea una nueva instancia del formulario para la baja de los profesores
                    formBajaProfesor.Show(); // Muestra el formulario para la baja de profesores
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (panelAbierto)
            {
                case 0:
                    FormEdicionAtleta formEdicionAtleta = new FormEdicionAtleta(this); // Crea una nueva instancia del formulario para la edición de los atletas
                    formEdicionAtleta.Show(); // Muestra el formulario para la edición de los atletas
                    break;
                case 1:
                    FormEdicionArbitro formeEdicionArbitro = new FormEdicionArbitro(this); // Crea una nueva instancia del formulario para la edición de los arbitros
                    formeEdicionArbitro.Show(); // Muestra el formulario para la edición de los arbitros
                    break;
                case 2:
                    FormEdicionProfesor formEdicionProfesor = new FormEdicionProfesor(this); // Crea una nueva instancia del formulario para la edición de los profesores
                    formEdicionProfesor.Show(); // Muestra el formulario para la edición de los profesores
                    break;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (panelAbierto)
            {
                case 0:
                    FormFiltrarAtleta formFiltrarAtleta = new FormFiltrarAtleta(this); // Crea una nueva instancia del formulario para filtrar atletas
                    formFiltrarAtleta.Show(); // Muestra el formulario para filtrar atletas
                    break;
                case 1:
                    FormFiltrarArbitro formFiltrarArbitro = new FormFiltrarArbitro(this); // Crea una nueva instancia del formulario para filtrar arbitros
                    formFiltrarArbitro.Show(); // Muestra el formulario para filtrar arbitros
                    break;
                case 2:
                    FormFiltrarProfesor formFiltrarProfesor = new FormFiltrarProfesor(this); // Crea una nueva instancia del formulario para filtrar profesores
                    formFiltrarProfesor.Show(); // Muestra el formulario para filtrar profesores
                    break;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (panelAbierto == 0)
            {
                ListarAtletas(); // Ejecuta el metodo para listar los atletas
            }
            else if (panelAbierto == 1)
            {
                ListarArbitros(); // Ejecuta el metodo para listar los arbitros
            }
            else
            {
                ListarProfesores();
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

        private void btnListarAtleta_Click(object sender, EventArgs e)
        {
            panelAbierto = 0;
            ListarAtletas();  // Ejecuta el metodo para listar los atletas
            dataGridViewAtletas.Show(); // Muestra la cuadricula de datos con los datos de los atletas
        }

        private void btnListarArbitro_Click(object sender, EventArgs e)
        {
            panelAbierto = 1;
            ListarArbitros(); // Ejecuta el metodo para listar los arbitros
            dataGridViewAtletas.Show();
        }

        private void btnListarProfesor_Click(object sender, EventArgs e)
        {
            panelAbierto = 2;
            ListarProfesores(); // Ejecuta el metodo para listar los arbitros
            dataGridViewAtletas.Show();
        }
    }
}
