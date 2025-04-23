namespace Projeto_WFA
{
    partial class FrmRegistroAcesso
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
            dgvRegistros = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            clnTipoOperacao = new DataGridViewTextBoxColumn();
            btnVoltar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnDataHora, clnTipoOperacao });
            dgvRegistros.Location = new Point(74, 88);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.Size = new Size(653, 350);
            dgvRegistros.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnUsuario
            // 
            clnUsuario.HeaderText = "Usuario";
            clnUsuario.Name = "clnUsuario";
            clnUsuario.ReadOnly = true;
            clnUsuario.Width = 225;
            // 
            // clnDataHora
            // 
            clnDataHora.HeaderText = "Data e Hora";
            clnDataHora.Name = "clnDataHora";
            clnDataHora.ReadOnly = true;
            clnDataHora.Width = 225;
            // 
            // clnTipoOperacao
            // 
            clnTipoOperacao.HeaderText = "Operação";
            clnTipoOperacao.Name = "clnTipoOperacao";
            clnTipoOperacao.ReadOnly = true;
            clnTipoOperacao.Width = 150;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.btnVoltar;
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 40);
            btnVoltar.TabIndex = 14;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmRegistroAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(dgvRegistros);
            Name = "FrmRegistroAcesso";
            Text = "FrmRegistroAcesso";
            Load += FrmRegistroAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
        private PictureBox btnVoltar;
    }
}