using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace InterfazProyecto1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "admin" && tbContraseña.Text == "admin")
            {
                tbNombre.ForeColor = Color.FromArgb(0, 255, 0);
                tbContraseña.ForeColor = Color.FromArgb(0, 255, 0);
                await Task.Delay(300);
                Form2 ventanaPrincipal = new Form2();
                ventanaPrincipal.Show();
                this.Hide();
            }
            else
            {
                if (tbNombre.Text != "admin" && tbContraseña.Text != "admin")
                {
                    tbNombre.ForeColor = Color.FromArgb(255, 0, 0);
                    tbContraseña.ForeColor = Color.FromArgb(255, 0, 0);
                    await Task.Delay(1000);
                    tbNombre.ForeColor = Color.FromArgb(0, 0, 0);
                    tbContraseña.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else if (tbNombre.Text != "admin")
                {
                    tbContraseña.ForeColor = Color.FromArgb(0, 255, 0);
                    tbNombre.ForeColor = Color.FromArgb(255, 0, 0);
                    await Task.Delay(1000);
                    tbContraseña.ForeColor = Color.FromArgb(0, 0, 0);
                    tbNombre.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else if (tbContraseña.Text != "admin")
                {
                    tbNombre.ForeColor = Color.FromArgb(0, 255, 0);
                    tbContraseña.ForeColor = Color.FromArgb(255, 0, 0);
                    await Task.Delay(1000);
                    tbNombre.ForeColor = Color.FromArgb(0, 0, 0);
                    tbContraseña.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
