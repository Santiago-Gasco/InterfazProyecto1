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
            panel1.Width += 3;

            if (panel1.Width >= 801)
            {
                timer1.Stop();
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
