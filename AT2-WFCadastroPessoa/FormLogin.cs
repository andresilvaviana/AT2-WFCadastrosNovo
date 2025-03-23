namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Longo = "sistema";
            us.Senha = "123456";

            Usuario.ListaUsuario.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuario)
            {
                if ((user.Longo == txtLogon.Text) && (user.Senha == txtSenha.Text))
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        FormPrincipal form = new FormPrincipal();
                        form.ShowDialog();

                        return;
                    }
                

            }
            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            txtLogon.Clear();
            txtSenha.Clear();
            return;

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }
    }
}
