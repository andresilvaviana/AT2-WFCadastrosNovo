namespace AT2_WFCadastros
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
            lblCodigo = new Label();
            lblNomeCategoria = new Label();
            txtCodigo = new TextBox();
            txtNomeCategoria = new TextBox();
            lblDescricao = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtDescricao = new TextBox();
            groupBox1 = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            label1 = new Label();
            dtpDataCadastro = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(20, 72);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(110, 15);
            lblNomeCategoria.TabIndex = 1;
            lblNomeCategoria.Text = "Nome da Categoria";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(20, 33);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(136, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCategoria.Location = new Point(20, 90);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(277, 23);
            txtNomeCategoria.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(20, 131);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(222, 265);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 41);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(141, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Location = new Point(20, 149);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(277, 101);
            txtDescricao.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbInativo);
            groupBox1.Controls.Add(rdbAtivo);
            groupBox1.Location = new Point(162, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(68, 22);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 3;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(6, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 2;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 265);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 12;
            label1.Text = "Data do Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Enabled = false;
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(20, 283);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(110, 23);
            dtpDataCadastro.TabIndex = 5;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(112, 134, 147);
            ClientSize = new Size(330, 333);
            Controls.Add(dtpDataCadastro);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtDescricao);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblDescricao);
            Controls.Add(txtNomeCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblNomeCategoria);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categoria";
            Load += FormCadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNomeCategoria;
        private TextBox txtCodigo;
        private TextBox txtNomeCategoria;
        private Label lblDescricao;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtDescricao;
        private GroupBox groupBox1;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label label1;
        private DateTimePicker dtpDataCadastro;
    }
}