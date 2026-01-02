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
    public partial class frmSubirOnline : Form
    {
        public frmSubirOnline()
        {
            InitializeComponent();
        }


        #region Eventos
        private void frmSubirOnline_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Métodos

        private bool LimparCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (cbSelecioneTela.SelectedIndex == -1)
            {
                campos += lblSelecioneTela.Text + "\n";
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
