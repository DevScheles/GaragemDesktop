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
    public partial class frmVeiculo : Form
    {

        bool ehPrimeiraVez = true;
        List<int> lstIdsAdicionais = new List<int>();
        int codigoRegistro = 0;
        public frmVeiculo()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_VEICULO);
            Util.ConfigurarGrid(grdAdicionais);
        }

        #region Eventos
        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            Util.ConfigurarGrid(grdAdicionais, true);
            Util.ConfigurarCombo(cbSituacao);
            Util.ConfigurarCombo(cbMarca, "Marca1" , "Id");
            Util.ConfigurarCombo(cbModelo, "Modelo1" , "Id");
            CarregarMarca();
            CarregarAdicionais();
            grdAdicionais.ClearSelection();
            ehPrimeiraVez = false;

        }

      

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

           if(ValidarCampos())
            {
                Cadastrar();
                LimparCampos();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            }
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

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ehPrimeiraVez)
            {
                FiltrarModelo();
            }

        }
        #endregion

        #region Métodos

        private void CarregarMarca()
        {
            cbMarca.DataSource = new MarcaDAO().ConsultarMarcas(Util.CodigoLogado);
            cbMarca.SelectedIndex = -1;
        }
        private void AdicionarItensConfiguracao()
        {
            lstIdsAdicionais.Clear();

            //Percorrendo as linhas selecionadas da grid

            foreach (DataGridViewRow Linha in grdAdicionais.SelectedRows)
            {

                //Chegagem do tipo
                if(Linha.DataBoundItem is Adicional)
                {
                    Adicional objLinhaSelecionada = (Adicional)Linha.DataBoundItem;
                    lstIdsAdicionais.Add(objLinhaSelecionada.Id);
                }
            }
        }

        private void CarregarAdicionais()
        {
            grdAdicionais.DataSource = new AdicionalDAO().ConsultarAdicionais(Util.CodigoLogado);

            grdAdicionais.Columns["Id"].Visible = false;
            grdAdicionais.Columns["GaragemId"].Visible = false;
            grdAdicionais.Columns["Garagem"].Visible = false;
            grdAdicionais.Columns["Veiculo"].Visible = false;
        }

        private void Cadastrar()
        {
            Veiculo veiculo = new Veiculo();
            VeiculoDAO objDao = new VeiculoDAO();

            try
            {
                veiculo.GaragemId = Util.CodigoLogado;
                veiculo.ModeloId = (int)cbModelo.SelectedValue;
                veiculo.Km = txtKm.Text;
                veiculo.Obs = txtObs.Text;
                veiculo.Placa = txtPlaca.Text;
                veiculo.Situacao = (short)cbSituacao.SelectedIndex;
                veiculo.Ano = txtAno.Text;
                veiculo.ValorCompra = Convert.ToDecimal(txtValorCompra.Text);
                veiculo.ValorVenda = Convert.ToDecimal(txtValorVenda.Text);
                veiculo.Leilao = (byte)(chkLeilao.Checked ? 1 : 0);

                AdicionarItensConfiguracao();
                objDao.CadastrarVeiculo(veiculo, lstIdsAdicionais);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
        }


           
           
        


        private void FiltrarModelo()
        {

            if(cbMarca.SelectedIndex > -1)
            {
                Util.ConfigurarCombo(cbModelo, "Modelo1", "Id");
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


            if (string.IsNullOrWhiteSpace(txtValorVenda.Text))
            {
                campos += lblValorVenda.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtKm.Text))
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
            codigoRegistro = 0;
            cbModelo.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbSituacao.SelectedIndex = -1;
            txtPlaca.Clear();
            txtKm.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            txtObs.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
            grdAdicionais.ClearSelection();
            chkLeilao.Checked = false;
        }

        #endregion

        
    }
}
