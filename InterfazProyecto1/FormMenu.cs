using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace InterfazProyecto1
{
    public partial class FormMenu : Form
    {
        string query;
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
            btnGuardar.Visible = false;
            btnCargar.Visible = false;
            btnReset.Visible = false;
            panelAzulBtnRefrescar.Visible = true;
            panelAzulBtnAlta.Visible = true;
            panelAzulBtnBaja.Visible = true;
            panelAzulBtnEditar.Visible = true;
            panelAzulBtnFiltrar.Visible = true;
            panelAzulBtnOrden.Visible = false;
            panelAzulBtnGuardar.Visible = false;
            panelAzulBtnCargar.Visible = false;
            panelAzulBtnReset.Visible = false;
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
            btnGuardar.Visible = false;
            btnCargar.Visible = false;
            btnReset.Visible = false;
            panelAzulBtnRefrescar.Visible = true;
            panelAzulBtnAlta.Visible = false;
            panelAzulBtnBaja.Visible = false;
            panelAzulBtnEditar.Visible = false;
            panelAzulBtnFiltrar.Visible = false;
            panelAzulBtnOrden.Visible = true;
            panelAzulBtnTerminarRanking.Visible = true;
            panelAzulBtnGuardar.Visible = false;
            panelAzulBtnCargar.Visible = false;
            panelAzulBtnReset.Visible = false;
            dataGridViewAtletas.Visible = true;
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            panelAbierto = 4;
            btnRefrescar.Visible = false;
            btnAlta.Visible = false;
            btnBaja.Visible = false;
            btnEditar.Visible = false;
            btnFiltrar.Visible = false;
            btnOrden.Visible = false;
            btnTerminarRanking.Visible = false;
            btnGuardar.Visible = true;
            btnCargar.Visible = true;
            btnReset.Visible = true;
            panelAzulBtnRefrescar.Visible = false;
            panelAzulBtnAlta.Visible = false;
            panelAzulBtnBaja.Visible = false;
            panelAzulBtnEditar.Visible = false;
            panelAzulBtnFiltrar.Visible = false;
            panelAzulBtnOrden.Visible = false;
            panelAzulBtnTerminarRanking.Visible = false;
            panelAzulBtnGuardar.Visible = true;
            panelAzulBtnCargar.Visible = true;
            panelAzulBtnReset.Visible = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO tb_eventos (Nombre, Participantes, Orden) VALUES (@Nombre, @Participantes, @Orden)";

            GuardarFixture();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FormCargarFixture formCargarFixture = new FormCargarFixture(this); // Crea una nueva instancia del formulario para cargar un fixture
            formCargarFixture.Show(); // Muestra el formulario para cargar un fixture
        }

        int cbHabilitado;

        private void GuardarFixture()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Cambia los valores del atleta a los valores de TextBox

                        int cbNum = 1;
                        string cadenaValoresCheckBox = "";
                        for (int i = 0; i <= 14; i++)
                        {
                            string cbNombre = "cbAtleta" + cbNum.ToString();
                            CheckBox cb1 = this.Controls.Find(cbNombre, true).FirstOrDefault() as CheckBox;

                            cbNum++;
                            string cbNombre2 = "cbAtleta" + cbNum.ToString();
                            CheckBox cb2 = this.Controls.Find(cbNombre2, true).FirstOrDefault() as CheckBox;

                            // Verificar que los CheckBox no sean null antes de usarlos
                            if (cb1 != null && cb2 != null)
                            {
                                VerificarCheckBoxHabilitado(cb1, cb2);
                                cadenaValoresCheckBox += cbHabilitado.ToString() + "-";
                            }

                            cbNum++;
                        }

                        string participantes = tbAtleta1.Text + "-" + tbAtleta2.Text + "-" + tbAtleta3.Text + "-" + tbAtleta4.Text + "-" + tbAtleta5.Text + "-" + tbAtleta6.Text + "-" + tbAtleta7.Text + "-" + tbAtleta8.Text + "-" + tbAtleta9.Text + "-" + tbAtleta10.Text + "-" + tbAtleta11.Text + "-" + tbAtleta12.Text + "-" + tbAtleta13.Text + "-" + tbAtleta14.Text + "-" + tbAtleta15.Text + "-" + tbAtleta16.Text + "-";
                        string orden = cadenaValoresCheckBox;
                        commandDatabase.Parameters.AddWithValue("@Nombre", tbNombreFixture.Text);
                        commandDatabase.Parameters.AddWithValue("@Participantes", participantes);
                        commandDatabase.Parameters.AddWithValue("@Orden", orden);

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fixture guardado exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el fixture. Inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }

        public void CargarFixture(string nombreFixture)
        {
            ResetCheckBoxTextBox();

            query = "SELECT * FROM tb_eventos WHERE Nombre = @Nombre";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.Parameters.AddWithValue("@Nombre", nombreFixture);

                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                commandDatabase.CommandTimeout = 60;

                                string participantes = reader["Participantes"].ToString();
                                string orden = reader["Orden"].ToString();
                                List<string> listaParticipantes = new List<string>();

                                string atleta = "";
                                int numAtleta = 0;

                                for (int i = 0; i < participantes.Length; i++)
                                {
                                    char a = participantes[i];

                                    if (a == '-')
                                    {
                                        switch (numAtleta)
                                        {
                                            case 0:
                                                tbAtleta1.Text = atleta;
                                                break;
                                            case 1:
                                                tbAtleta2.Text = atleta;
                                                break;
                                            case 2:
                                                tbAtleta3.Text = atleta;
                                                break;
                                            case 3:
                                                tbAtleta4.Text = atleta;
                                                break;
                                            case 4:
                                                tbAtleta5.Text = atleta;
                                                break;
                                            case 5:
                                                tbAtleta6.Text = atleta;
                                                break;
                                            case 6:
                                                tbAtleta7.Text = atleta;
                                                break;
                                            case 7:
                                                tbAtleta8.Text = atleta;
                                                break;
                                            case 8:
                                                tbAtleta9.Text = atleta;
                                                break;
                                            case 9:
                                                tbAtleta10.Text = atleta;
                                                break;
                                            case 10:
                                                tbAtleta11.Text = atleta;
                                                break;
                                            case 11:
                                                tbAtleta12.Text = atleta;
                                                break;
                                            case 12:
                                                tbAtleta13.Text = atleta;
                                                break;
                                            case 13:
                                                tbAtleta14.Text = atleta;
                                                break;
                                            case 14:
                                                tbAtleta15.Text = atleta;
                                                break;
                                            case 15:
                                                tbAtleta16.Text = atleta;
                                                break;
                                        }
                                        atleta = "";
                                        numAtleta++;
                                    }
                                    else
                                    {
                                        atleta += a;
                                    }
                                }

                                int cbNum = 1;
                                int tbNum = 17;

                                for (int a = 0; a < orden.Length; a++)
                                {
                                    char o = orden[a];

                                    if (o != '-')
                                    {
                                        string cbNombre = "cbAtleta" + cbNum.ToString();
                                        CheckBox cb1 = this.Controls.Find(cbNombre, true).FirstOrDefault() as CheckBox;

                                        cbNum++;
                                        string cbNombre2 = "cbAtleta" + cbNum.ToString();
                                        CheckBox cb2 = this.Controls.Find(cbNombre2, true).FirstOrDefault() as CheckBox;

                                        string tbNombre = "tbAtleta" + tbNum.ToString();
                                        TextBox tb1 = this.Controls.Find(tbNombre, true).FirstOrDefault() as TextBox;

                                        cbNum++;
                                        string tbNombre2 = "tbAtleta" + tbNum.ToString();
                                        TextBox tb2 = this.Controls.Find(tbNombre2, true).FirstOrDefault() as TextBox;

                                        if (cb1 != null && cb2 != null)
                                        {
                                            if (o == 0)
                                            {
                                                cb1.Checked = true;
                                            }
                                            else
                                            {
                                                cb2.Checked = true;
                                            }
                                        }
                                    }
                                }
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

        private void CambiarCheckBox(CheckBox cb1, CheckBox cb2, TextBox tb1, TextBox tb2)
        {
            if (cb1.Checked == true)
            {
                tb1.Text = tb2.Text;
                cb2.Enabled = false;
            }

            if (cb1.Checked == false && cb2.Checked == false)
            {
                cb1.Enabled = true;
                cb2.Enabled = true;
                tb1.Text = "";
            }
        }

        private void FinalCheckBox(CheckBox cb1, CheckBox cb2, TextBox tb1, TextBox tb2)
        {
            if (cb1.Checked == true)
            {
                tb1.BackColor = Color.Yellow;
                tb2.BackColor = Color.Gray;
                cb2.Enabled = false;
            }

            if (cb1.Checked == false && cb2.Checked == false)
            {
                cb1.Enabled = true;
                cb2.Enabled = true;
                tb1.BackColor = Color.White;
                tb2.BackColor = Color.White;
            }
        }

        private void VerificarCheckBoxHabilitado(CheckBox cb1, CheckBox cb2)
        {
            // Verifica que uno de los dos checkbox este activado, si ninguno esta activado

            if (cb1.Checked == true)
            {
                cbHabilitado = 0;
            }
            else if (cb2.Checked == true)
            {
                cbHabilitado = 1;
            }
            else
            {
                cbHabilitado = 2;
            }
        }

        private void ResetCheckBoxTextBox()
        {
            int cbNum = 1;
            int tbNum = 1;

            for (int i = 0; i <= 31; i++)
            {
                string cbNombre = "cbAtleta" + cbNum.ToString();
                CheckBox cb1 = this.Controls.Find(cbNombre, true).FirstOrDefault() as CheckBox;

                cbNum++;
                string cbNombre2 = "cbAtleta" + cbNum.ToString();
                CheckBox cb2 = this.Controls.Find(cbNombre2, true).FirstOrDefault() as CheckBox;

                string tbNombre = "tbAtleta" + tbNum.ToString();
                TextBox tb1 = this.Controls.Find(tbNombre, true).FirstOrDefault() as TextBox;

                cbNum++;
                string tbNombre2 = "tbAtleta" + tbNum.ToString();
                TextBox tb2 = this.Controls.Find(tbNombre2, true).FirstOrDefault() as TextBox;

                if (cb1 != null && cb2 != null && tb1 != null && tb2 != null)
                {
                    cb1.Checked = false;
                    cb2.Checked = false;
                    tb1.Text = "";
                    tb2.Text = "";
                    tb1.BackColor = Color.White;
                    tb2.BackColor = Color.White;
                }
            }
        }

        private void cbAtleta1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta1, cbAtleta2, tbAtleta17, tbAtleta1);
        }

        private void cbAtleta2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta2, cbAtleta1, tbAtleta17, tbAtleta2);
        }

        private void cbAtleta3_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta3, cbAtleta4, tbAtleta18, tbAtleta3);
        }

        private void cbAtleta4_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta4, cbAtleta3, tbAtleta18, tbAtleta4);
        }

        private void cbAtleta5_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta5, cbAtleta6, tbAtleta19, tbAtleta5);
        }

        private void cbAtleta6_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta6, cbAtleta5, tbAtleta19, tbAtleta6);
        }

        private void cbAtleta7_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta7, cbAtleta8, tbAtleta20, tbAtleta7);
        }

        private void cbAtleta8_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta8, cbAtleta7, tbAtleta20, tbAtleta8);
        }

        private void cbAtleta9_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta9, cbAtleta10, tbAtleta21, tbAtleta9);
        }

        private void cbAtleta10_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta10, cbAtleta9, tbAtleta21, tbAtleta10);
        }

        private void cbAtleta11_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta11, cbAtleta12, tbAtleta22, tbAtleta11);
        }

        private void cbAtleta12_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta12, cbAtleta11, tbAtleta22, tbAtleta12);
        }

        private void cbAtleta13_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta13, cbAtleta14, tbAtleta23, tbAtleta13);
        }

        private void cbAtleta14_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta14, cbAtleta13, tbAtleta23, tbAtleta14);
        }

        private void cbAtleta15_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta15, cbAtleta16, tbAtleta24, tbAtleta15);
        }

        private void cbAtleta16_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta16, cbAtleta15, tbAtleta24, tbAtleta16);
        }

        private void cbAtletaCuartos1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta17, cbAtleta18, tbAtleta25, tbAtleta17);
        }

        private void cbAtletaCuartos2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta18, cbAtleta17, tbAtleta25, tbAtleta18);
        }

        private void cbAtletaCuartos3_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta19, cbAtleta20, tbAtleta26, tbAtleta19);
        }

        private void cbAtletaCuartos4_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta20, cbAtleta19, tbAtleta26, tbAtleta20);
        }

        private void cbAtletaCuartos5_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta21, cbAtleta22, tbAtleta27, tbAtleta21);
        }

        private void cbAtletaCuartos6_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta22, cbAtleta21, tbAtleta27, tbAtleta22);
        }

        private void cbAtletaCuartos7_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta23, cbAtleta24, tbAtleta28, tbAtleta23);
        }

        private void cbAtletaCuartos8_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta24, cbAtleta23, tbAtleta28, tbAtleta24);
        }

        private void cbAtletaSemis1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta25, cbAtleta26, tbAtleta29, tbAtleta25);
        }

        private void cbAtletaSemis2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta26, cbAtleta25, tbAtleta29, tbAtleta26);
        }

        private void cbAtletaSemis3_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta27, cbAtleta28, tbAtleta30, tbAtleta27);
        }

        private void cbAtletaSemis4_CheckedChanged(object sender, EventArgs e)
        {
            CambiarCheckBox(cbAtleta28, cbAtleta27, tbAtleta30, tbAtleta28);
        }

        private void cbAtletaFinal1_CheckedChanged(object sender, EventArgs e)
        {
            FinalCheckBox(cbAtleta29, cbAtleta30, tbAtleta29, tbAtleta30);
        }

        private void cbAtletaFinal2_CheckedChanged(object sender, EventArgs e)
        {
            FinalCheckBox(cbAtleta30, cbAtleta29, tbAtleta30, tbAtleta29);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCheckBoxTextBox();
        }
    }
}
