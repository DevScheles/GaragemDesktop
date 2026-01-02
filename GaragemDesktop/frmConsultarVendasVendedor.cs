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
    public partial class frmConsultarVendasVendedor : Form
    {
        public frmConsultarVendasVendedor()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_CONSULTAR_VENDAS_VENDEDOR);
            Util.ConfigurarGrid(grdResultado);
        }


        #region Eventos
        private void frmConsultarVendasVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        #endregion


        #region Métodos

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (cbSelecioneVendedor.SelectedIndex == -1)
            {
                campos += lblSelecioneVendedor.Text + "\n";
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;
        }

        #endregion
    }
}
