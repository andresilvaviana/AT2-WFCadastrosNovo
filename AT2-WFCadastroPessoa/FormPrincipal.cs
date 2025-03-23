using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void entarrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListar form = new FormListar();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
