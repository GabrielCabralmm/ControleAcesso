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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.Logar(txtCpf.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    Close();
                    RegistroAcesso registroAcesso = new();
                    registroAcesso.UsuarioId = usuario.Id;
                    registroAcesso.RegistrarEntrada();
                }
                else
                {
                    lblIncorreto.Visible = true;
                    lblObrigatorios.Visible = false;
                }
            }
            else
            {
                lblObrigatorios.Visible = true;
                lblIncorreto.Visible = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
