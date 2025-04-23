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
    public partial class FrmRegistroAcesso : Form
    {
        public FrmRegistroAcesso()
        {
            InitializeComponent();
        }

        private void FrmRegistroAcesso_Load(object sender, EventArgs e)
        {
            var registros = RegistroAcesso.ObterLista();
            int linha = 0;
            dgvRegistros.Rows.Clear();
            foreach (var registro in registros)
            {
                dgvRegistros.Rows.Add();
                dgvRegistros.Rows[linha].Cells[0].Value = registro.Id;
                dgvRegistros.Rows[linha].Cells[1].Value = registro.UsuarioId;
                dgvRegistros.Rows[linha].Cells[2].Value = registro.DataHora;
                dgvRegistros.Rows[linha].Cells[3].Value = registro.TipoOperacao;

                linha++;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal.pnlMenu.Visible = true;
        }
    }
}
