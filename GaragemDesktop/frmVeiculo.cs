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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_VEICULO);
            Util.ConfigurarGrid(grdResultado);
        }

        #region Eventos
        private void frmVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            new frmPesquisarVeiculo().ShowDialog();
        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;


            if (string.IsNullOrWhiteSpace(txtValorVenda.Text))
            {
                campos += lblValorVenda.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtQuilometragem.Text))
            {
                campos += lblQuilometragem.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtValorCompra.Text))
            {
                campos += lblValorCompra.Text + "\n";
                flag = false;
            }

            if (cbSituacao.SelectedIndex == -1)
            {
                campos += lblSelecioneMarca.Text + "\n";
                flag = false;
            }

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

            if (cbSituacao.SelectedIndex == -1)
            {
                campos += lblSituacao.Text + "\n";
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao,campos);
            }

            return flag;

        }

        private void LimparCampos()
        {
            txtAno.Clear();
            txtQuilometragem.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
        }

        #endregion
    }
}
