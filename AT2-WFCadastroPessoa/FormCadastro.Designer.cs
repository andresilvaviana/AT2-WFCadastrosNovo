namespace AT2_WFCadastroPessoa
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblCadastrar = new Label();
            lblCPF = new Label();
            lblNomeCompleto = new Label();
            lblEmail = new Label();
            lblCelular = new Label();
            txtCadastro = new TextBox();
            ckbFilhos = new CheckBox();
            rdbVoltar = new Button();
            btnSalvar = new Button();
            txtNomeCompleto = new TextBox();
            mktCelular = new MaskedTextBox();
            txtEmail = new TextBox();
            grpTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            mktCPF = new MaskedTextBox();
            grpTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastrar
            // 
            lblCadastrar.AutoSize = true;
            lblCadastrar.Location = new Point(23, 28);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(54, 15);
            lblCadastrar.TabIndex = 0;
            lblCadastrar.Text = "Cadastro";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(142, 28);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(22, 92);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(23, 212);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(73, 15);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "DDD/Celular";
            // 
            // txtCadastro
            // 
            txtCadastro.Location = new Point(23, 46);
            txtCadastro.Name = "txtCadastro";
            txtCadastro.ReadOnly = true;
            txtCadastro.Size = new Size(100, 23);
            txtCadastro.TabIndex = 1;
            // 
            // ckbFilhos
            // 
            ckbFilhos.AutoSize = true;
            ckbFilhos.Location = new Point(23, 282);
            ckbFilhos.Name = "ckbFilhos";
            ckbFilhos.Size = new Size(99, 19);
            ckbFilhos.TabIndex = 6;
            ckbFilhos.Text = "Possui Filhos?";
            ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // rdbVoltar
            // 
            rdbVoltar.Font = new Font("Clarendon Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbVoltar.Image = (Image)resources.GetObject("rdbVoltar.Image");
            rdbVoltar.Location = new Point(23, 329);
            rdbVoltar.Name = "rdbVoltar";
            rdbVoltar.Size = new Size(114, 44);
            rdbVoltar.TabIndex = 11;
            rdbVoltar.Text = "Voltar";
            rdbVoltar.UseVisualStyleBackColor = true;
            rdbVoltar.Click += rdbVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Clarendon Blk BT", 9F);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(153, 329);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 44);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(23, 110);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(239, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // mktCelular
            // 
            mktCelular.Location = new Point(23, 233);
            mktCelular.Mask = "(00)00000-0000";
            mktCelular.Name = "mktCelular";
            mktCelular.Size = new Size(113, 23);
            mktCelular.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 4;
            // 
            // grpTipoTelefone
            // 
            grpTipoTelefone.Controls.Add(rdbRecado);
            grpTipoTelefone.Controls.Add(rdbComercial);
            grpTipoTelefone.Controls.Add(rdbPessoal);
            grpTipoTelefone.Location = new Point(142, 210);
            grpTipoTelefone.Name = "grpTipoTelefone";
            grpTipoTelefone.Size = new Size(120, 100);
            grpTipoTelefone.TabIndex = 7;
            grpTipoTelefone.TabStop = false;
            grpTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(11, 71);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 9;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(11, 46);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 8;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(11, 24);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 7;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // mktCPF
            // 
            mktCPF.Location = new Point(142, 46);
            mktCPF.Mask = "000,000,000-00";
            mktCPF.Name = "mktCPF";
            mktCPF.Size = new Size(120, 23);
            mktCPF.TabIndex = 2;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 196, 181);
            ClientSize = new Size(289, 385);
            Controls.Add(mktCPF);
            Controls.Add(grpTipoTelefone);
            Controls.Add(txtEmail);
            Controls.Add(mktCelular);
            Controls.Add(txtNomeCompleto);
            Controls.Add(btnSalvar);
            Controls.Add(rdbVoltar);
            Controls.Add(ckbFilhos);
            Controls.Add(txtCadastro);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCPF);
            Controls.Add(lblCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            grpTipoTelefone.ResumeLayout(false);
            grpTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastrar;
        private Label lblCPF;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblCelular;
        private TextBox txtCadastro;
        private CheckBox ckbFilhos;
        private Button rdbVoltar;
        private Button btnSalvar;
        private TextBox txtNomeCompleto;
        private MaskedTextBox mktCelular;
        private TextBox txtEmail;
        private GroupBox grpTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private MaskedTextBox mktCPF;
    }
}