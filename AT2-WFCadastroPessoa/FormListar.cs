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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            MessageBox.Show($"Total de cadastros: {Pessoa.ObterLista().Count}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void FormListar_Load(object sender, EventArgs e)
        {
            dgvListaPessoas.DataSource = null;
            dgvListaPessoas.DataSource = Pessoa.ObterLista();
        }
    }
}