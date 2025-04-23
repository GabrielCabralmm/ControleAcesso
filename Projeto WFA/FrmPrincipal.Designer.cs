namespace Projeto_WFA
{
    partial class FrmPrincipal
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
            pnlCentral = new Panel();
            btnSair = new Button();
            pnlMenu = new Panel();
            btnCadastrar = new Button();
            btnRegistros = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCentral
            // 
            pnlCentral.Location = new Point(0, 38);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(800, 412);
            pnlCentral.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Controls.Add(btnCadastrar);
            pnlMenu.Controls.Add(btnRegistros);
            pnlMenu.Location = new Point(0, 1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(800, 38);
            pnlMenu.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(632, 8);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.Location = new Point(551, 8);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(75, 23);
            btnRegistros.TabIndex = 0;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenu);
            Controls.Add(pnlCentral);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistros;
        private Button btnCadastrar;
        private Button btnSair;
        public Panel pnlMenu;
        public Panel pnlCentral;
    }
}