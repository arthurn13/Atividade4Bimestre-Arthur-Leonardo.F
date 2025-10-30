using Microsoft.VisualBasic;
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
    public partial class frmarea : Form
    {

        public frmarea()
        {
            InitializeComponent();
        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }

        private void btndowhile_Click(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i = 1, comodo;
            double largura, comp, areacomodo, areatotal;
            areatotal = 0;
            areacomodo = 0;
            comodo = Convert.ToInt32(txtcomodo.Text);
            if (!int.TryParse(txtcomodo.Text, out comodo))
            {
                MessageBox.Show("Digite um número válido de cômodos!");
                return; // sai do método para evitar erro
            }
            while (i <= comodo)
            {
                string compStr = Interaction.InputBox($"Digite o comprimento do cômodo {i}:");
                string largStr = Interaction.InputBox($"Digite a largura do cômodo {i}:");
                /*Mensagem de texto para o usuário*/

                comp = Convert.ToDouble(compStr);
                largura = Convert.ToDouble(largStr);
                areacomodo = comp * largura;
                txtareacomodo.Text = areacomodo.ToString();
                areatotal = areatotal + areacomodo;
                i++;      
            }
            txtareatotal.Text = areatotal.ToString();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtareacomodo.Clear();
            txtareatotal.Clear();
            txtcomodo.Clear();
            txtcomp.Clear();
            txtlargura.Clear();
            txtcomodo.Focus();
        }
    }
}
