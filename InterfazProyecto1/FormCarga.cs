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
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3; //aumenta el ancho del panel1 con cada tick del timer

            if (panel1.Width >= 801) //If en el que cuando el ancho del panel1 alcanza el valor 801, osea el final de la barra de carga, el timer se detiene y se abre el formELeccionLoginRegistro
            {
                timer1.Stop();
                FormEleccionLoginRegistro formEleccionLoginRegistro = new FormEleccionLoginRegistro();
                formEleccionLoginRegistro.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
