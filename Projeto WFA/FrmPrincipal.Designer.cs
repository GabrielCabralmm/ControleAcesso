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
            lblTipo = new Label();
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
            pnlCentral.Paint += pnlCentral_Paint;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 40, 80);
            btnSair.Location = new Point(713, 8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(7, 40, 80);
            pnlMenu.Controls.Add(lblTipo);
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Controls.Add(btnCadastrar);
            pnlMenu.Controls.Add(btnRegistros);
            pnlMenu.ForeColor = Color.Black;
            pnlMenu.Location = new Point(0, 1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(800, 38);
            pnlMenu.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(12, 3);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(18, 30);
            lblTipo.TabIndex = 3;
            lblTipo.Text = ".";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 40, 80);
            btnCadastrar.Location = new Point(632, 8);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.White;
            btnRegistros.FlatAppearance.BorderSize = 0;
            btnRegistros.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 40, 80);
            btnRegistros.Location = new Point(551, 8);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(75, 23);
            btnRegistros.TabIndex = 0;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pnlMenu);
            Controls.Add(pnlCentral);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistros;
        private Button btnCadastrar;
        private Button btnSair;
        private Label lblTipo;
        public static Panel pnlMenu;
        public static Panel pnlCentral;
    }
}