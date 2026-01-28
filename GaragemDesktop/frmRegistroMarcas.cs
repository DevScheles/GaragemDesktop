using GaragemDesktop.Classes;
using System;
using System.Windows.Forms;
using DAO;
using System.Collections.Generic;

namespace GaragemDesktop
{
    public partial class frmRegistroMarcas : Form
    {
        public frmRegistroMarcas()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_MARCA);
            Util.ConfigurarGrid(grdResultado);
        }

        int codigoRegistro = 0;

        #region Eventos
        private void frmRegistroMarcas_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            Consultar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cadastrar();
                Consultar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Alterar();
                Consultar();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.ExibirMsg(Util.TipoMsg.ConfirmacaoExclusao, txtNome.Text))
            {
                Excluir();
                Consultar();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdResultado.RowCount > 0)
            {
                Marca objLinhaClicada = (Marca) grdResultado.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaClicada.Marca1;
                codigoRegistro = objLinhaClicada.Id;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnAdicionar, btnAlterar, btnExcluir);
            }
        }
        #endregion

        #region Metódos

        private void Excluir()
        {
            MarcaDAO objDao = new MarcaDAO();

            try
            {
                objDao.ExcluirMarca(codigoRegistro);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();

            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
        }


        private void Alterar()
        {
            //Cria o obj que terá o metodo cadastrar
            MarcaDAO objDao = new MarcaDAO();

            //Cria o obj que terá as informações
            Marca objMarca = new Marca();

            objMarca.Marca1 = txtNome.Text;
            objMarca.Id = codigoRegistro;

            objDao.AlterarMarca(objMarca);

            try
            {
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();
            }
            catch 
            {

               
            }
        }

        private void Consultar()
        {
            MarcaDAO objDao = new MarcaDAO();
            List<Marca> lstRetorno = objDao.ConsultarMarcas(Util.CodigoLogado);
            grdResultado.DataSource = lstRetorno;

            //Altera a visibiliadade de colunas na gridview
            grdResultado.Columns["Id"].Visible = false;
            grdResultado.Columns["GaragemId"].Visible = false;
            grdResultado.Columns["Garagem"].Visible = false;
            grdResultado.Columns["Modelo"].Visible = false;

            //Altera o nome das colunas
            grdResultado.Columns["Marca1"].HeaderText = "Nome da Marca";
        }
        private void Cadastrar()
        {
            //Cria o obj que terá o metodo cadastrar
            MarcaDAO objDao = new MarcaDAO();

            //Cria o obj que terá as informações
            Marca objMarca = new Marca();

            objMarca.Marca1 = txtNome.Text;
            objMarca.GaragemId = Util.CodigoLogado;

            try
            {
                objDao.CadastrarMarca(objMarca);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();

            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                campos = lblNome.Text;
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
            txtNome.Clear();
            txtNome.Focus();
        }

        #endregion
    }
}
