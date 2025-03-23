using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        public void FormLista_Load(object sender, EventArgs e)
        {
            dgvListaCategoria.DataSource = CadastroCategoria.ObterLista();
        }
    }
}
