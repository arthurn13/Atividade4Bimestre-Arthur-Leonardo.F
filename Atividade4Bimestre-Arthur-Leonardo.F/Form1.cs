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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();
        }

        private void conversãoDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmconversao conversao = new frmconversao();
            conversao.Show();
        }

        private void áreaDeCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
