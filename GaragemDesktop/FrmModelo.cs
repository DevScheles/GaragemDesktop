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
    public partial class FrmModelo : Form
    {
        public FrmModelo()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_MODELO);
            Util.ConfigurarGrid(grdResultado);
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            // Aqui você acessa a imagem que colocou no Resources
            picGravarOffline.Image = Properties.Resources.button_desligado; // imagem OFF
            picGravarOffline.Tag = "off"; // estado inicial
        }


        private void picGravarOffline_Click(object sender, EventArgs e)
        {
            if (picGravarOffline.Tag.ToString() == "off")
            {
                // Ligar
                picGravarOffline.Image = Properties.Resources.button_ligado;
                picGravarOffline.Tag = "on";
            }
            else
            {
                // Desligar
                picGravarOffline.Image = Properties.Resources.button_desligado;
                picGravarOffline.Tag = "off";
            }
        }


        #region Eventos
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

            if (cbSelecioneMarca.SelectedIndex == -1)
            {
                campos += lblSelecioneMarca.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                campos += lblNomeModelo.Text;
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
            txtModelo.Clear();
        }

        #endregion
    }
}


