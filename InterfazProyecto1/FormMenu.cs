using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
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
        string orden = "DESC";

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
                btnRanking.Size = btnRanking.MinimumSize;
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
                btnRanking.Size = btnRanking.MaximumSize;
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
            string query;

            if (panelAbierto > 2)
            {
                query = "SELECT ID_atleta, Ranking, Puntos, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta"; // Variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos
            }
            else
            {
                query = "SELECT ID_atleta, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela, Ranking, Puntos FROM tb_atleta"; // Variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos
            }

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Crea una tabla temporal y copia los datos de la tabla original
                    string createTempTableQuery = @"
                        CREATE TEMPORARY TABLE tb_atleta_temp AS
                        SELECT Id_atleta, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela, Ranking, Puntos
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

        public void ListarAtletasPorRanking()
        {
            string query = "SELECT ID_atleta, Ranking, Puntos, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela FROM tb_atleta_ranking"; //variable de tipo string que contiene el comando necesario para pedirle los datos a la base de datos

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString)) //abre una conexión con la base de datos
            {
                databaseConnection.Open();

                try
                {
                    // Borra la tabla temporal ordenada por puntos si existe
                    string dropTempTableQuery = "DROP TEMPORARY TABLE IF EXISTS tb_atleta_ranking;";
                    using (var dropTempTableCommand = new MySqlCommand(dropTempTableQuery, databaseConnection))
                    {
                        dropTempTableCommand.ExecuteNonQuery();
                    }

                    // Crea una tabla temporal y copia los datos de la tabla original
                    string createTempTableQuery = $@"
                        CREATE TEMPORARY TABLE IF NOT EXISTS tb_atleta_ranking AS
                        SELECT ID_atleta, Ranking, Puntos, Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela
                        FROM tb_atleta
                        ORDER BY Puntos {orden};"; // Crea una tabla temporal, la iguala a la tabla atleta y la pone en orden
                    using (var createTempTableCommand = new MySqlCommand(createTempTableQuery, databaseConnection))
                    {
                        createTempTableCommand.ExecuteNonQuery();
                    }

                    int ranking;
                    string operacionRanking = "";
                    List<int> atletas = new List<int>();

                    // Obtener los IDs de los atletas
                    string orderRankingQuery = "SELECT ID_atleta FROM tb_atleta_ranking;";
                    using (var orderRankingCommand = new MySqlCommand(orderRankingQuery, databaseConnection))
                    {
                        using (MySqlDataReader reader = orderRankingCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idAtleta = reader.GetInt32("ID_atleta");
                                atletas.Add(idAtleta);
                            }
                            reader.Close();
                        }
                    }

                    if (orden == "DESC")
                    {
                        ranking = 1;
                        operacionRanking = "++";
                    }
                    else
                    {
                        ranking = atletas.Count;
                        operacionRanking = "--";
                    }

                    // Actualizar el ranking de los atletas
                    foreach (int idAtleta in atletas)
                    {
                        string updateRankingQuery = $"UPDATE tb_atleta SET Ranking = {ranking} WHERE ID_atleta = {idAtleta};";
                        using (var updateRankingCommand = new MySqlCommand(updateRankingQuery, databaseConnection))
                        {
                            updateRankingCommand.ExecuteNonQuery();
                        }

                        ranking = (operacionRanking == "++") ? ranking + 1 : (operacionRanking == "--") ? ranking - 1 : ranking;
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
            else if (panelAbierto == 2)
            {
                ListarProfesores(); // Ejecuta el metodo para listar los profesores
            }
            else
            {
                ListarAtletasPorRanking(); // Ejecuta el metodo para listar los atletas por puntos
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
            dataGridViewAtletas.Visible = true;
            ListarAtletas();  // Ejecuta el metodo para listar los atletas
            dataGridViewAtletas.Show();
            ListarUsuarios();
        }

        private void btnListarArbitro_Click(object sender, EventArgs e)
        {
            panelAbierto = 1;
            dataGridViewAtletas.Visible = true;
            ListarArbitros(); // Ejecuta el metodo para listar los arbitros
            dataGridViewAtletas.Show();
            ListarUsuarios();
        }

        private void btnListarProfesor_Click(object sender, EventArgs e)
        {
            panelAbierto = 2;
            dataGridViewAtletas.Visible = true;
            ListarProfesores(); // Ejecuta el metodo para listar los arbitros
            dataGridViewAtletas.Show();
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            btnRefrescar.Visible = true;
            btnAlta.Visible = true;
            btnBaja.Visible = true;
            btnEditar.Visible = true;
            btnFiltrar.Visible = true;
            btnOrden.Visible = false;
            btnTerminarRanking.Visible = false;
            panelAzulBtnRefrescar.Visible = true;
            panelAzulBtnAlta.Visible = true;
            panelAzulBtnBaja.Visible = true;
            panelAzulBtnEditar.Visible = true;
            panelAzulBtnFiltrar.Visible = true;
            panelAzulBtnOrden.Visible = false;
            panelAzulBtnTerminarRanking.Visible = false;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            panelAbierto = 3;
            ListarAtletasPorRanking();
            btnRefrescar.Visible = true;
            btnAlta.Visible = false;
            btnBaja.Visible = false;
            btnEditar.Visible = false;
            btnFiltrar.Visible = false;
            btnOrden.Visible = true;
            btnTerminarRanking.Visible = true;
            panelAzulBtnRefrescar.Visible = true;
            panelAzulBtnAlta.Visible = false;
            panelAzulBtnBaja.Visible = false;
            panelAzulBtnEditar.Visible = false;
            panelAzulBtnFiltrar.Visible = false;
            panelAzulBtnOrden.Visible = true;
            panelAzulBtnTerminarRanking.Visible = true;
            dataGridViewAtletas.Visible = true;
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            btnRefrescar.Visible = false;
            btnAlta.Visible = false;
            btnBaja.Visible = false;
            btnEditar.Visible = false;
            btnFiltrar.Visible = false;
            btnOrden.Visible = false;
            btnTerminarRanking.Visible = false;
            panelAzulBtnRefrescar.Visible = false;
            panelAzulBtnAlta.Visible = false;
            panelAzulBtnBaja.Visible = false;
            panelAzulBtnEditar.Visible = false;
            panelAzulBtnFiltrar.Visible = false;
            panelAzulBtnOrden.Visible = false;
            panelAzulBtnTerminarRanking.Visible = false;
            dataGridViewAtletas.Visible = false;
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            // Cambia el orden del ranking segun sea, ascendente y descendente
            if (orden == "DESC")
            {
                btnOrden.Image = Properties.Resources.icons8_reversed_numerical_sorting_30;
                orden = "ASC";
                ListarAtletasPorRanking();
            }
            else
            {
                btnOrden.Image = Properties.Resources.icons8_numeric_30;
                orden = "DESC";
                ListarAtletasPorRanking();
            }

            // Se llama otra vez para ordenar los atlteas que tienen 0 puntos ya que su ranking queda desordenado
            ListarAtletasPorRanking();
        }

        private void btnTerminarRanking_Click(object sender, EventArgs e)
        {
            FormTerminarRanking formTerminarRanking = new FormTerminarRanking(this); // Crea una nueva instancia del formulario para terminar el ranking de atletas
            formTerminarRanking.Show(); // Muestra el formulario para terminar el ranking de atletas
        }

        private void cbAtleta1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta1.Checked == true)
            {
                tbAtletaCuartos1.Text = tbAtleta1.Text;
                cbAtleta2.Enabled = false;
            }

            if (cbAtleta1.Checked == false && cbAtleta2.Checked == false)
            {
                cbAtleta1.Enabled = true;
                cbAtleta2.Enabled = true;
                tbAtletaCuartos1.Text = "";
            }
        }

        private void cbAtleta2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta2.Checked == true)
            {
                tbAtletaCuartos1.Text = tbAtleta2.Text;
                cbAtleta1.Enabled = false;
            }

            if (cbAtleta1.Checked == false && cbAtleta2.Checked == false)
            {
                cbAtleta1.Enabled = true;
                cbAtleta2.Enabled = true;
                tbAtletaCuartos1.Text = "";
            }
        }

        private void cbAtleta3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta3.Checked == true)
            {
                tbAtletaCuartos2.Text = tbAtleta3.Text;
                cbAtleta4.Enabled = false;
            }

            if (cbAtleta3.Checked == false && cbAtleta4.Checked == false)
            {
                cbAtleta3.Enabled = true;
                cbAtleta4.Enabled = true;
                tbAtletaCuartos2.Text = "";
            }
        }

        private void cbAtleta4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta4.Checked == true)
            {
                tbAtletaCuartos2.Text = tbAtleta4.Text;
                cbAtleta3.Enabled = false;
            }

            if (cbAtleta3.Checked == false && cbAtleta4.Checked == false)
            {
                cbAtleta3.Enabled = true;
                cbAtleta4.Enabled = true;
                tbAtletaCuartos2.Text = "";
            }
        }

        private void cbAtleta5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta5.Checked == true)
            {
                tbAtletaCuartos3.Text = tbAtleta5.Text;
                cbAtleta6.Enabled = false;
            }

            if (cbAtleta5.Checked == false && cbAtleta6.Checked == false)
            {
                cbAtleta5.Enabled = true;
                cbAtleta6.Enabled = true;
                tbAtletaCuartos3.Text = "";
            }
        }

        private void cbAtleta6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta6.Checked == true)
            {
                tbAtletaCuartos3.Text = tbAtleta6.Text;
                cbAtleta5.Enabled = false;
            }

            if (cbAtleta5.Checked == false && cbAtleta6.Checked == false)
            {
                cbAtleta5.Enabled = true;
                cbAtleta6.Enabled = true;
                tbAtletaCuartos3.Text = "";
            }
        }

        private void cbAtleta7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta7.Checked == true)
            {
                tbAtletaCuartos4.Text = tbAtleta7.Text;
                cbAtleta8.Enabled = false;
            }

            if (cbAtleta7.Checked == false && cbAtleta8.Checked == false)
            {
                cbAtleta7.Enabled = true;
                cbAtleta8.Enabled = true;
                tbAtletaCuartos4.Text = "";
            }
        }

        private void cbAtleta8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta8.Checked == true)
            {
                tbAtletaCuartos4.Text = tbAtleta8.Text;
                cbAtleta7.Enabled = false;
            }

            if (cbAtleta7.Checked == false && cbAtleta8.Checked == false)
            {
                cbAtleta7.Enabled = true;
                cbAtleta8.Enabled = true;
                tbAtletaCuartos4.Text = "";
            }
        }

        private void cbAtleta9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta9.Checked == true)
            {
                tbAtletaCuartos5.Text = tbAtleta9.Text;
                cbAtleta10.Enabled = false;
            }

            if (cbAtleta9.Checked == false && cbAtleta10.Checked == false)
            {
                cbAtleta9.Enabled = true;
                cbAtleta10.Enabled = true;
                tbAtletaCuartos5.Text = "";
            }
        }

        private void cbAtleta10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta10.Checked == true)
            {
                tbAtletaCuartos5.Text = tbAtleta10.Text;
                cbAtleta9.Enabled = false;
            }

            if (cbAtleta9.Checked == false && cbAtleta10.Checked == false)
            {
                cbAtleta9.Enabled = true;
                cbAtleta10.Enabled = true;
                tbAtletaCuartos5.Text = "";
            }
        }

        private void cbAtleta11_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta11.Checked == true)
            {
                tbAtletaCuartos6.Text = tbAtleta11.Text;
                cbAtleta12.Enabled = false;
            }

            if (cbAtleta11.Checked == false && cbAtleta12.Checked == false)
            {
                cbAtleta11.Enabled = true;
                cbAtleta12.Enabled = true;
                tbAtletaCuartos6.Text = "";
            }
        }

        private void cbAtleta12_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta12.Checked == true)
            {
                tbAtletaCuartos6.Text = tbAtleta12.Text;
                cbAtleta11.Enabled = false;
            }

            if (cbAtleta11.Checked == false && cbAtleta12.Checked == false)
            {
                cbAtleta11.Enabled = true;
                cbAtleta12.Enabled = true;
                tbAtletaCuartos6.Text = "";
            }
        }

        private void cbAtleta13_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta13.Checked == true)
            {
                tbAtletaCuartos7.Text = tbAtleta13.Text;
                cbAtleta14.Enabled = false;
            }

            if (cbAtleta13.Checked == false && cbAtleta14.Checked == false)
            {
                cbAtleta13.Enabled = true;
                cbAtleta14.Enabled = true;
                tbAtletaCuartos7.Text = "";
            }
        }

        private void cbAtleta14_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta14.Checked == true)
            {
                tbAtletaCuartos7.Text = tbAtleta14.Text;
                cbAtleta13.Enabled = false;
            }

            if (cbAtleta13.Checked == false && cbAtleta14.Checked == false)
            {
                cbAtleta13.Enabled = true;
                cbAtleta14.Enabled = true;
                tbAtletaCuartos7.Text = "";
            }
        }

        private void cbAtleta15_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta15.Checked == true)
            {
                tbAtletaCuartos8.Text = tbAtleta15.Text;
                cbAtleta16.Enabled = false;
            }

            if (cbAtleta15.Checked == false && cbAtleta16.Checked == false)
            {
                cbAtleta15.Enabled = true;
                cbAtleta16.Enabled = true;
                tbAtletaCuartos8.Text = "";
            }
        }

        private void cbAtleta16_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtleta16.Checked == true)
            {
                tbAtletaCuartos8.Text = tbAtleta16.Text;
                cbAtleta15.Enabled = false;
            }

            if (cbAtleta15.Checked == false && cbAtleta16.Checked == false)
            {
                cbAtleta15.Enabled = true;
                cbAtleta16.Enabled = true;
                tbAtletaCuartos8.Text = "";
            }
        }

        private void cbAtletaCuartos1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos1.Checked == true)
            {
                tbAtletaSemis1.Text = tbAtletaCuartos1.Text;
                cbAtletaCuartos2.Enabled = false;
            }

            if (cbAtletaCuartos1.Checked == false && cbAtletaCuartos2.Checked == false)
            {
                cbAtletaCuartos1.Enabled = true;
                cbAtletaCuartos2.Enabled = true;
                tbAtletaSemis1.Text = "";
            }
        }

        private void cbAtletaCuartos2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos2.Checked == true)
            {
                tbAtletaSemis1.Text = tbAtletaCuartos2.Text;
                cbAtletaCuartos1.Enabled = false;
            }

            if (cbAtletaCuartos1.Checked == false && cbAtletaCuartos2.Checked == false)
            {
                cbAtletaCuartos1.Enabled = true;
                cbAtletaCuartos2.Enabled = true;
                tbAtletaSemis1.Text = "";
            }
        }

        private void cbAtletaCuartos3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos3.Checked == true)
            {
                tbAtletaSemis2.Text = tbAtletaCuartos3.Text;
                cbAtletaCuartos4.Enabled = false;
            }

            if (cbAtletaCuartos3.Checked == false && cbAtletaCuartos4.Checked == false)
            {
                cbAtletaCuartos3.Enabled = true;
                cbAtletaCuartos4.Enabled = true;
                tbAtletaSemis2.Text = "";
            }
        }

        private void cbAtletaCuartos4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos4.Checked == true)
            {
                tbAtletaSemis2.Text = tbAtletaCuartos4.Text;
                cbAtletaCuartos3.Enabled = false;
            }

            if (cbAtletaCuartos3.Checked == false && cbAtletaCuartos4.Checked == false)
            {
                cbAtletaCuartos3.Enabled = true;
                cbAtletaCuartos4.Enabled = true;
                tbAtletaSemis2.Text = "";
            }
        }

        private void cbAtletaCuartos5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos5.Checked == true)
            {
                tbAtletaSemis3.Text = tbAtletaCuartos5.Text;
                cbAtletaCuartos6.Enabled = false;
            }

            if (cbAtletaCuartos5.Checked == false && cbAtletaCuartos6.Checked == false)
            {
                cbAtletaCuartos5.Enabled = true;
                cbAtletaCuartos6.Enabled = true;
                tbAtletaSemis3.Text = "";
            }
        }

        private void cbAtletaCuartos6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos6.Checked == true)
            {
                tbAtletaSemis3.Text = tbAtletaCuartos6.Text;
                cbAtletaCuartos5.Enabled = false;
            }

            if (cbAtletaCuartos5.Checked == false && cbAtletaCuartos6.Checked == false)
            {
                cbAtletaCuartos5.Enabled = true;
                cbAtletaCuartos6.Enabled = true;
                tbAtletaSemis3.Text = "";
            }
        }

        private void cbAtletaCuartos7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos7.Checked == true)
            {
                tbAtletaSemis4.Text = tbAtletaCuartos7.Text;
                cbAtletaCuartos8.Enabled = false;
            }

            if (cbAtletaCuartos7.Checked == false && cbAtletaCuartos8.Checked == false)
            {
                cbAtletaCuartos7.Enabled = true;
                cbAtletaCuartos8.Enabled = true;
                tbAtletaSemis4.Text = "";
            }
        }

        private void cbAtletaCuartos8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaCuartos8.Checked == true)
            {
                tbAtletaSemis4.Text = tbAtletaCuartos8.Text;
                cbAtletaCuartos7.Enabled = false;
            }

            if (cbAtletaCuartos7.Checked == false && cbAtletaCuartos8.Checked == false)
            {
                cbAtletaCuartos7.Enabled = true;
                cbAtletaCuartos8.Enabled = true;
                tbAtletaSemis4.Text = "";
            }
        }

        private void cbAtletaSemis1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaSemis1.Checked == true)
            {
                tbAtletaFinal1.Text = tbAtletaSemis1.Text;
                cbAtletaSemis3.Enabled = false;
            }

            if (cbAtletaSemis1.Checked == false && cbAtletaSemis3.Checked == false)
            {
                cbAtletaSemis1.Enabled = true;
                cbAtletaSemis3.Enabled = true;
                tbAtletaFinal1.Text = "";
            }
        }

        private void cbAtletaSemis3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaSemis3.Checked == true)
            {
                tbAtletaFinal1.Text = tbAtletaSemis3.Text;
                cbAtletaSemis1.Enabled = false;
            }

            if (cbAtletaSemis1.Checked == false && cbAtletaSemis3.Checked == false)
            {
                cbAtletaSemis1.Enabled = true;
                cbAtletaSemis3.Enabled = true;
                tbAtletaFinal1.Text = "";
            }
        }

        private void cbAtletaSemis2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaSemis2.Checked == true)
            {
                tbAtletaFinal2.Text = tbAtletaSemis2.Text;
                cbAtletaSemis4.Enabled = false;
            }

            if (cbAtletaSemis2.Checked == false && cbAtletaSemis4.Checked == false)
            {
                cbAtletaSemis2.Enabled = true;
                cbAtletaSemis4.Enabled = true;
                tbAtletaFinal2.Text = "";
            }
        }

        private void cbAtletaSemis4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaSemis4.Checked == true)
            {
                tbAtletaFinal2.Text = tbAtletaSemis4.Text;
                cbAtletaSemis2.Enabled = false;
            }

            if (cbAtletaSemis2.Checked == false && cbAtletaSemis4.Checked == false)
            {
                cbAtletaSemis2.Enabled = true;
                cbAtletaSemis4.Enabled = true;
                tbAtletaFinal2.Text = "";
            }
        }

        private void cbAtletaFinal1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaFinal1.Checked == true)
            {
                tbAtletaFinal1.BackColor = Color.Yellow;
                tbAtletaFinal2.BackColor = Color.Gray;
                cbAtletaFinal2.Enabled = false;
            }

            if (cbAtletaFinal1.Checked == false && cbAtletaFinal2.Checked == false)
            {
                cbAtletaFinal1.Enabled = true;
                cbAtletaFinal2.Enabled = true;
                tbAtletaFinal1.BackColor = Color.White;
                tbAtletaFinal2.BackColor = Color.White;
            }
        }

        private void cbAtletaFinal2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtletaFinal2.Checked == true)
            {
                tbAtletaFinal1.BackColor = Color.Gray;
                tbAtletaFinal2.BackColor = Color.Yellow;
                cbAtletaFinal1.Enabled = false;
            }

            if (cbAtletaFinal1.Checked == false && cbAtletaFinal2.Checked == false)
            {
                cbAtletaFinal1.Enabled = true;
                cbAtletaFinal2.Enabled = true;
                tbAtletaFinal1.BackColor = Color.White;
                tbAtletaFinal2.BackColor = Color.White;
            }
        }
    }
}
