using DAO;
using GaragemDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemDesktop
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_LOGIN);
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnAcessar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            progressBar1.Visible = true;
            btnAcessar.Enabled = false;

            try
            {
                UsuarioDAO objDAO = new UsuarioDAO();

                Acesso objAcesso = await Task.Run(() =>
                    objDAO.Logar(txtLogin.Text, txtSenha.Text));

                if (objAcesso == null)
                {
                    Util.ExibirMsg(Util.TipoMsg.NaoEncontradoUser);
                    return;
                }

                Util.CodigoLogado = (int)objAcesso.GaragemId;
                this.DialogResult = DialogResult.OK;
            }
            finally
            {
                progressBar1.Visible = false;
                btnAcessar.Enabled = true;
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                campos = "Login\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                campos = "Senha";
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;



        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
