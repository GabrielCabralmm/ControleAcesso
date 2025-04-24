using Microsoft.Win32;
using Projeto_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_WFA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new();
            frmLogin.ShowDialog();
            Show();

            lblTipo.Text = Program.usuario.Nome;
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FrmRegistroAcesso frmRegistroAcesso = new();
            frmRegistroAcesso.TopLevel = false;
            frmRegistroAcesso.FormBorderStyle = FormBorderStyle.None;
            frmRegistroAcesso.MaximizeBox = true;
            frmRegistroAcesso.AutoSize = true;
            frmRegistroAcesso.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmRegistroAcesso);
            pnlMenu.Visible = false;
            pnlCentral.Dock = DockStyle.Fill;

            frmRegistroAcesso.Show();
            pnlCentral.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new();
            frmCadastro.TopLevel = false;
            frmCadastro.FormBorderStyle = FormBorderStyle.None;
            frmCadastro.MaximizeBox = true;
            frmCadastro.AutoSize = true;
            frmCadastro.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(frmCadastro);
            pnlMenu.Visible = false;
            pnlCentral.Dock = DockStyle.Fill;

            frmCadastro.Show();
            pnlCentral.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (Program.usuario.Id > 0)
            {
                RegistroAcesso registroAcesso = new();
                registroAcesso.UsuarioId = Program.usuario.Id;
                registroAcesso.RegistrarSaida();
                Application.Exit();
            }
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
