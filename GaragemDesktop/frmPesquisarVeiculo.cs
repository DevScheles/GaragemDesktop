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
    public partial class frmPesquisarVeiculo : Form
    {
        public frmPesquisarVeiculo()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_PESQUISA_VEICULO);
            Util.ConfigurarGrid(grdResultado);
        }

        #region Eventos
        private void frmPesquisarVeiculo_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Métodos

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            // COMBOBOX
            if (cbSelecioneMarca.SelectedIndex == -1)
            {
                campos += lblSelecioneMarca.Text + "\n";
                flag = false;
            }

            if (cbSelecioneModelo.SelectedIndex == -1)
            {
                campos += lblSelecioneModelo.Text + "\n";
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;
        }

        #endregion


        #region Eventos
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        #endregion
    }
}
