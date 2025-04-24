namespace Projeto_WFA
{
    partial class FrmCadastro
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
            lblCadastro = new Label();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            cmbTipo = new ComboBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            btnVoltar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(300, 96);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(200, 30);
            lblCadastro.TabIndex = 12;
            lblCadastro.Text = "Cadastro de Usuário";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(348, 326);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(265, 284);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(271, 23);
            txtSenha.TabIndex = 10;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Visitante", "Funcionário", "Administrador" });
            cmbTipo.Location = new Point(265, 240);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(271, 23);
            cmbTipo.TabIndex = 9;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(265, 196);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "Cpf";
            txtCpf.Size = new Size(271, 23);
            txtCpf.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(265, 152);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(271, 23);
            txtNome.TabIndex = 7;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.btnVoltar;
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 40);
            btnVoltar.TabIndex = 13;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVoltar);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(cmbTipo);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblCadastro;
        public Button btnCadastrar;
        public TextBox txtSenha;
        public ComboBox cmbTipo;
        public TextBox txtCpf;
        public TextBox txtNome;
        private PictureBox btnVoltar;
    }
}