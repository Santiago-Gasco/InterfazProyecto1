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
    public partial class FormFixture : Form
    {
        public FormFixture()
        {
            InitializeComponent();
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
