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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            int qtdeCadastro = Pessoa.ObterLista().Count;
            int novoCadastro = qtdeCadastro + 1;
            txtCadastro.Text = novoCadastro.ToString("D4");
        }
        public void LimparCampos()
        {
            mktCPF.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            mktCelular.Clear();
            ckbFilhos.CheckState = CheckState.Indeterminate;
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnSalvar_Click(object snper, EventArgs e)
        {
            string cpfLimpo = new string(mktCPF.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(cpfLimpo) || cpfLimpo.Length != 11)
            {
                Erro("Campo CPF não pode estar vazio ou inválido!");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                Erro("Campo Nome não pode estar vazio!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(mktCelular.Text) || mktCelular.Text.Length < 11)
            {
                Erro("Campo Celular não pode estar vazio!");
                return;
            }

            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de telefone!");
                return;
            }

            TipoTelefone tipoTelefone;
            if (rdbComercial.Checked)
            {
                tipoTelefone = TipoTelefone.Comercial;
            }
            else if (rdbPessoal.Checked)
            {
                tipoTelefone = TipoTelefone.Pessoal;
            }
            else
            {
                tipoTelefone = TipoTelefone.Recado;
            }

            Pessoa np = new Pessoa();

            np.Cadastro = Convert.ToInt32(txtCadastro.Text);
            np.Cpf = mktCPF.Text;
            np.Nome = txtNomeCompleto.Text;
            np.Email = txtEmail.Text;
            np.Ddd = mktCelular.Text.Substring(0, 4);
            np.Celular = mktCelular.Text.Substring(4);
            np.Filhos = ckbFilhos.Checked;
            np.TipoTelefone = tipoTelefone;

            Pessoa.ListaPessoas.Add(np);

            int qtdeCadastro = Pessoa.ObterLista().Count;
            int novoCadastro = qtdeCadastro + 1;
            txtCadastro.Text = novoCadastro.ToString("D4");

            string filhosTexto = np.Filhos == true ? "Sim" : "Não";

            string mensagem = @$"
            Cadastro: {np.Cadastro}
            CPF: {np.Cpf}
            Nome: {np.Nome}
            Email: {np.Email}
            DDD: {np.Ddd}
            Celular: {np.Celular}
            Tipo Telefone: {np.TipoTelefone}
            Possui Filhos?: {filhosTexto}";

            Sucesso(mensagem);
            LimparCampos();




        }

        private void rdbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
