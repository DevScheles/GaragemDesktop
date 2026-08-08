using DAO;
using DAO.VO;
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
        bool ehPrimeiraVez = true;
        bool ehPrimeiraVezMarca = true;
        frmVeiculo frmTelaPai;

        public frmPesquisarVeiculo(frmVeiculo frmApontamento)
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_PESQUISA_VEICULO);
            Util.ConfigurarGrid(grdResultado);
            frmTelaPai = frmApontamento;
        }

        #region Eventos
        private void frmPesquisarVeiculo_Load(object sender, EventArgs e)
        {
            Util.ConfigurarCombo(cbMarca, "Marca1", "Id");
            Util.ConfigurarCombo(cbModelo, "Modelo1", "Id");
            Util.ConfigurarGrid(grdResultado);
            CarregarMarca();
            ehPrimeiraVez = false;
        }

        #endregion

        #region Métodos

        private void CarregarMarca()
        {
            cbMarca.DataSource = new MarcaDAO().ConsultarMarcas(Util.CodigoLogado);
            cbMarca.SelectedIndex = -1;
        }

        private void FiltrarModelo()
        {

            if (cbMarca.SelectedIndex > -1)
            {
                cbModelo.DataSource = new ModeloDAO().FiltrarModelo((int)cbMarca.SelectedValue, Util.CodigoLogado);
                cbModelo.SelectedIndex = -1;
            }


            else
            {
                cbModelo.DataSource = null;
            }




        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            // COMBOBOX
            if (cbMarca.SelectedIndex == -1)
            {
                campos += lblSelecioneMarca.Text + "\n";
                flag = false;
            }

            if (cbModelo.SelectedIndex == -1)
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
      

        #endregion

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ehPrimeiraVez)
            {
                FiltrarModelo();
                ehPrimeiraVezMarca = false;
            }
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbModelo.SelectedIndex > -1  && !ehPrimeiraVez && !ehPrimeiraVezMarca)
            {
                FiltrarVeiculo();
            }

        }

        private void FiltrarVeiculo()
        {
            VeiculoDAO objDAO = new VeiculoDAO();
            List<VeiculoVO> lst = objDAO.FiltrarVeiculo(Util.CodigoLogado, (int)cbModelo.SelectedValue);

            if (lst.Count == 0)
            {
                Util.ExibirMsg(Util.TipoMsg.NaoEncontrado);
                grdResultado.DataSource = null;
                return;
            }

            grdResultado.DataSource = lst;
            grdResultado.Columns["ObjEdicao"].Visible = false;
            grdResultado.Columns["Situacao"].HeaderText = "Situação";

        }

        private void lblSelecioneModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblSelecioneMarca_Click(object sender, EventArgs e)
        {

        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdResultado.RowCount > 0)
            {
                VeiculoVO objLinha = (VeiculoVO)grdResultado.CurrentRow.DataBoundItem;

                Veiculo objPassarParaOutraTela = objLinha.objEdicao;

                frmTelaPai.DetalharVeiculo(objPassarParaOutraTela);

                this.Close();
            }
        }
    }
}
