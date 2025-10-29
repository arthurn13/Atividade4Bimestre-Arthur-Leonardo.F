using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4Bimestre_Arthur_Leonardo.F
{
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1;
            double result, num;
            num = Convert.ToDouble(txtnum.Text);
            if(num > 10)
            {
                txtresult.Text = "Valor inválido";
            }else
                do
                {
                    result = i * num;
                    i++;
                    txtresult.Text += result + ", \r\n";
                } while (i <= 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int i;
            double result, num;
            num = Convert.ToDouble(txtnum.Text);
            if(num > 10)
            {
                txtresult.Text = "Valor inválido";
            }
            else
                for (i = 1; i <= 10; i++)
            {
                result = i * num;
                txtresult.Text += result + ", \r\n";
            }

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            double result, num;
            num = Convert.ToDouble(txtnum.Text);
            if (num > 10)
            {
                txtresult.Text = "Valor inválido";
            }
            else
            while (i <= 10)
            {
                result = i * num;
                txtresult.Text += result + ", \r\n";
                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
