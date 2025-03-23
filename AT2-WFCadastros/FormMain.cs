namespace AT2_WFCadastros
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLista form = new FormLista();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
