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
    public partial class frmconversao : Form
    {
        public frmconversao()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double grausc = 10, grausf, resultado;
            do
            {
                grausf = (grausc * 1.8) + 32;
                grausc = grausc + 10;
                resultado = grausf;
                i = i + 10;
                txtresult.Text += resultado + "\r\n";
            } while (i <= 100);
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double grausc = 10, grausf, resultado;
            while (i <= 100) 
            {
                grausf = (grausc * 1.8) + 32;
                grausc = grausc + 10;
                resultado = grausf;
                i = i + 10;
                txtresult.Text += resultado + "\r\n";
            } 
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int i;
            double grausc = 10, grausf, resultado;
            for(i = 10; i <= 100; i = i + 10){
                grausf = (grausc * 1.8) + 32;
                grausc = grausc + 10;
                resultado = grausf;
                txtresult.Text += resultado + "\r\n";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
