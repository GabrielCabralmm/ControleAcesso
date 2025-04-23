namespace Projeto_WFA
{
    partial class FrmLogin
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
            txtCpf = new TextBox();
            btnCancelar = new Button();
            lblObrigatorios = new Label();
            lblIncorreto = new Label();
            SuspendLayout();
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(311, 146);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(178, 30);
            lblCadastro.TabIndex = 16;
            lblCadastro.Text = "Login de Usuarios";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(287, 290);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 29);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Logar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(265, 243);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(271, 23);
            txtSenha.TabIndex = 14;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(265, 199);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "Cpf";
            txtCpf.Size = new Size(271, 23);
            txtCpf.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(408, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblObrigatorios
            // 
            lblObrigatorios.AutoSize = true;
            lblObrigatorios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObrigatorios.ForeColor = Color.FromArgb(192, 0, 0);
            lblObrigatorios.Location = new Point(265, 181);
            lblObrigatorios.Name = "lblObrigatorios";
            lblObrigatorios.Size = new Size(162, 15);
            lblObrigatorios.TabIndex = 18;
            lblObrigatorios.Text = "Preencha ambos os campos!";
            lblObrigatorios.Visible = false;
            // 
            // lblIncorreto
            // 
            lblIncorreto.AutoSize = true;
            lblIncorreto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncorreto.ForeColor = Color.FromArgb(192, 0, 0);
            lblIncorreto.Location = new Point(265, 181);
            lblIncorreto.Name = "lblIncorreto";
            lblIncorreto.Size = new Size(134, 15);
            lblIncorreto.TabIndex = 19;
            lblIncorreto.Text = "CPF ou senha inválidos!";
            lblIncorreto.Visible = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIncorreto);
            Controls.Add(lblObrigatorios);
            Controls.Add(btnCancelar);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtCpf);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblCadastro;
        public Button btnCadastrar;
        public TextBox txtSenha;
        public TextBox txtCpf;
        public Button btnCancelar;
        private Label lblObrigatorios;
        private Label lblIncorreto;
    }
}