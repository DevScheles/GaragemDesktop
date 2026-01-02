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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_VENDEDOR);
            Util.ConfigurarGrid(grdResultado);
        }



        #region Eventos

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            // Aqui você acessa a imagem que colocou no Resources
            picVendedorAtivo.Image = Properties.Resources.button_desligado; // imagem OFF
            picVendedorAtivo.Tag = "off"; // estado inicial
        }

        private void picVendedorAtivo_Click(object sender, EventArgs e)
        {
            if (picVendedorAtivo.Tag.ToString() == "off")
            {
                // Ligar
                picVendedorAtivo.Image = Properties.Resources.button_ligado;
                picVendedorAtivo.Tag = "on";
            }
            else
            {
                // Desligar
                picVendedorAtivo.Image = Properties.Resources.button_desligado;
                picVendedorAtivo.Tag = "off";
            }
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

            if (string.IsNullOrWhiteSpace(txtNomeVendedor.Text))
            {
                campos += lblNomeVendedor.Text + "\n";
                flag = false;
            }

            if (!txtTelefone.MaskCompleted || string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                campos += lblTelefone.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                campos += lblEmail.Text + "\n";
                flag = false;
            }

            if (!txtCpf.MaskCompleted || string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                campos += lblCpf.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                campos += lblEndereco.Text + "\n";
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
            txtNomeVendedor.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            
        }

        #endregion

    }
}
