﻿using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class FormAltaAtleta : Form
    {
        FormMenu formMenu;
        public Point mousePos;
        string query;

        public FormAltaAtleta(FormMenu menu)
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

        private void btnAltaAtleta_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO tb_atleta (Cedula, Nombre, Apellido, Edad, Sexo, Fecha_nacimiento, Federado, Escuela, Puntos) VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Sexo, @Fecha_nacimiento, @Federado, @Escuela, @Puntos)";

            // Si los valores cumple los requisitos se ejecuta el metodo AltaAtleta
            if (numCedula.Value > 9999999 && tbNombre.Text != "" && tbNombre.Text != string.Empty && tbApellido.Text != "" && tbApellido.Text != string.Empty && numEdad.Value >= 9 && cbGenero.SelectedIndex != -1 && dateFechaNacimiento.Value != DateTime.Now && numFederado.Value != 0 && tbEscuela.Text != "" && tbEscuela.Text != string.Empty)
            {
                AltaAtleta();
            }
            else
            {
                MessageBox.Show("Faltan datos, porfavor verifique y ingrese los datos faltantes");
            }
        }

        private void AltaAtleta()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open(); // Abre la conexión
                    using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                    {
                        commandDatabase.CommandTimeout = 60;

                        // Cambia los valores del atleta a los valores de TextBox, ComboBox, NumericUpDown y DateTimePicker
                        commandDatabase.Parameters.AddWithValue("@Cedula", Convert.ToInt32(numCedula.Value));
                        commandDatabase.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                        commandDatabase.Parameters.AddWithValue("@Apellido", tbApellido.Text);
                        commandDatabase.Parameters.AddWithValue("@Edad", Convert.ToInt32(numEdad.Value));
                        commandDatabase.Parameters.AddWithValue("@Sexo", cbGenero.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        commandDatabase.Parameters.AddWithValue("@Fecha_nacimiento", dateFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                        commandDatabase.Parameters.AddWithValue("@Federado", Convert.ToInt32(numFederado.Value));
                        commandDatabase.Parameters.AddWithValue("@Escuela", tbEscuela.Text);
                        commandDatabase.Parameters.AddWithValue("@Puntos", Convert.ToInt32(numPuntos.Value));

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atleta creado exitosamente!");

                            // Cambia los valores de los TextBox, ComboBox, NumericUpDown y DateTimePicker a nulos o valor por defecto
                            numCedula.Value = 0;
                            tbNombre.Text = string.Empty;
                            tbApellido.Text = string.Empty;
                            numEdad.Value = 9;
                            cbGenero.SelectedIndex = -1;
                            dateFechaNacimiento.Value = DateTime.Now;
                            numFederado.Value = 0;
                            tbEscuela.Text = string.Empty;
                            numPuntos.Value = 0;

                            this.formMenu = formMenu;

                            formMenu.ListarAtletas();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el atleta. Inténtelo de nuevo.");
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

        private void panelAzulBtnAltaAtleta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}