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

        private void TimerCarga_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 801)
            {
                timerCarga.Stop();
                FormEleccionLoginRegistro formEleccionLoginRegistro = new FormEleccionLoginRegistro();
                formEleccionLoginRegistro.Show();
                this.Hide();
            }
        }
    }
}
