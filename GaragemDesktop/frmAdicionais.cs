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
    public partial class frmAdicionais : Form
    {
        public frmAdicionais()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_ADICIONAIS);
            Util.ConfigurarGrid(grdResultado);
        }

        #region Eventos

        private void frmAdicionais_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion


        #region Métodos
        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (string.IsNullOrWhiteSpace(txtAdicionais.Text))
            {
                campos = lblNomeDoAdicional.Text;
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;

        }

        private void LimparCampos()
        {
            txtAdicionais.Clear();
        }

        #endregion
    }
}
