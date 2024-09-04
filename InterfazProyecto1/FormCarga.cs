using System;
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
            // Suma 3 al tamaño del panel cada vez que el timer se ejecuta
            panelCarga.Width += 3;

            // Si el valor del panel es igual a 801 (el valor deseado) termina el timer, muestra el FormEleccionLoginRegistro y esconde el form actual
            if (panelCarga.Width >= 801)
            {
                timerCarga.Stop();
                FormEleccionLoginRegistro formEleccionLoginRegistro = new FormEleccionLoginRegistro();
                formEleccionLoginRegistro.Show();
                this.Hide();
            }
        }
    }
}
