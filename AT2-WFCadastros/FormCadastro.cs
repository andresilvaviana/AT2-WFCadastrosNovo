using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastro : Form
    {
        private ETipoStatus eTipoStatus;

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
           int qtdeProdutos = CadastroCategoria.ObterLista().Count;
           int novoCodigo = qtdeProdutos + 1;
           txtCodigo.Text = novoCodigo.ToString("D4");
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            txtCodigo.Clear();
            txtNomeCategoria.Clear();
            txtDescricao.Clear();
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                Erro("Campo Nome não pode estar vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Erro("Campo Descrição não pode estar vazio!");
                return;
            }

            if (!rdbAtivo.Checked && !rdbInativo.Checked)
            {
                Erro("Deve-se marcar uma opção de Status!");
                return;
            }
            else
            {
                if (rdbAtivo.Checked)
                    eTipoStatus = ETipoStatus.Ativo;
                else if (rdbInativo.Checked)
                    eTipoStatus = ETipoStatus.Inativo;
            }

            CadastroCategoria novoC = new CadastroCategoria();
            novoC.Codigo = Convert.ToInt32(txtCodigo.Text);
            novoC.Nome = txtNomeCategoria.Text;
            novoC.Descricao = txtDescricao.Text;
            novoC.Status = eTipoStatus;
            novoC.Cadastro = dtpDataCadastro.Value;

            CadastroCategoria.ListaCategoria.Add(novoC);

            Sucesso("Categoria de Produto Realizado com Sucesso!");
            LimparFormulario();
            int qtdeProdutos = CadastroCategoria.ObterLista().Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString("D4");

            return;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
