namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnAcessar = new Button();
            lblLogon = new Label();
            txtLogon = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(32, 153);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(148, 23);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // lblLogon
            // 
            lblLogon.AutoSize = true;
            lblLogon.Location = new Point(30, 32);
            lblLogon.Name = "lblLogon";
            lblLogon.Size = new Size(41, 15);
            lblLogon.TabIndex = 1;
            lblLogon.Text = "Logon";
            lblLogon.Click += label1_Click;
            // 
            // txtLogon
            // 
            txtLogon.Location = new Point(32, 50);
            txtLogon.Name = "txtLogon";
            txtLogon.Size = new Size(148, 23);
            txtLogon.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(32, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(148, 23);
            txtSenha.TabIndex = 2;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(32, 83);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 222);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogon);
            Controls.Add(lblLogon);
            Controls.Add(btnAcessar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acessar";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label lblLogon;
        private TextBox txtLogon;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}
