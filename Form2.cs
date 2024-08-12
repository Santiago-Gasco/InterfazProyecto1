using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazProyecto1
{
    public partial class Form2 : Form
    {
        bool expandirMenu;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expandirMenu)
            {
                flowLayoutPanel1.Width -= 10;

                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    expandirMenu = false;
                    timer1.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;

                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)
                {
                    expandirMenu = true;
                    timer1.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblPestaña.Text = "Menu";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPestaña.Text = "Alta atleta";
        }

        private void btnBorrarAtleta_Click(object sender, EventArgs e)
        {
            lblPestaña.Text = "Baja atleta";
        }

        private void btnEditarAtleta_Click(object sender, EventArgs e)
        {
            lblPestaña.Text = "Edicion atleta";
        }

        private void btnListarAtleta_Click(object sender, EventArgs e)
        {
            lblPestaña.Text = "Lista atleta";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numAtletaCedula_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
