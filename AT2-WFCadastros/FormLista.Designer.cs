namespace AT2_WFCadastros
{
    partial class FormLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLista));
            dgvListaCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategoria).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCategoria
            // 
            dgvListaCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategoria.Dock = DockStyle.Fill;
            dgvListaCategoria.Location = new Point(0, 0);
            dgvListaCategoria.Name = "dgvListaCategoria";
            dgvListaCategoria.Size = new Size(571, 215);
            dgvListaCategoria.TabIndex = 0;
            // 
            // FormLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(112, 134, 147);
            ClientSize = new Size(571, 215);
            Controls.Add(dgvListaCategoria);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Categoria";
            Load += FormLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCategoria;
    }
}