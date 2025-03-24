using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_de_filmes
{
    public partial class Locadora : Form
    {
        public Locadora()
        {
            InitializeComponent();
        }

        private void locNovoFilme_Click(object sender, EventArgs e)
        {

        }

        private void locSalvarDados_Click(object sender, EventArgs e)
        {

        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locSair_Click(object sender, EventArgs e)
        {
            DialogResult FecharAplicacao = MessageBox.Show("Tem certeza que deseja fechar a aplicação?", "Fechar a aplicação?", MessageBoxButtons.YesNo);
            if (FecharAplicacao == DialogResult.Yes)
            {
                this.Close();
            }
            else if (FecharAplicacao == DialogResult.No) 
            {
                this.Refresh();
            }
        }
    }
}
