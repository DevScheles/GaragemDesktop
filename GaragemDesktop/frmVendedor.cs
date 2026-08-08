using DAO;
using DAO.VO;
using GaragemDesktop.Classes;
using System;
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

        int codigoRegistro = 0;
        string Informacao = string.Empty;



        #region Eventos

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            chkStatus.Visible = false;
            lblAtivo.Visible = false;
            Consultar();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar,btnExcluir);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cadastrar();
                LimparCampos();
                Consultar();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
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
            if (Util.ExibirMsg(Util.TipoMsg.ConfirmacaoExclusao, Informacao))
            {
                Excluir();
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
          
        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdResultado.RowCount > 0)
            {
                VendedorVO objLinhaClicada = (VendedorVO)grdResultado.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaClicada.objEditar.Vendedor1;
                txtComissao.Text = objLinhaClicada.objEditar.Comissao.ToString();
                txtCpf.Text = objLinhaClicada.objEditar.CPF;
                txtEmail.Text = objLinhaClicada.objEditar.Email;
                txtEndereco.Text = objLinhaClicada.objEditar.Endereco;
                txtTelefone.Text = objLinhaClicada.objEditar.Telefone;
                txtEndereco.Text = objLinhaClicada.objEditar.Endereco;

                codigoRegistro = objLinhaClicada.objEditar.Id;
                Informacao = objLinhaClicada.objEditar.Vendedor1;
                chkStatus.Visible = true;
                lblAtivo.Visible = true;
                chkStatus.Checked = objLinhaClicada.Situacao == "Inativo" ? false : true;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnAdicionar, btnAlterar, btnExcluir);
            }
        }

        private void txtNomeFiltro_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (!Util.ValidarCpf(txtCpf.Text))
            {
                Util.ExibirMsg(Util.TipoMsg.CpfInvalido, txtCpf.Text);
                txtCpf.Clear();
                return;
            }

            if (VerificarCpfDuplicado())
            {
                Util.ExibirMsg(Util.TipoMsg.CpfDuplicado, txtCpf.Text);
                txtCpf.Clear();
            }
        }

        private void grdResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion


        #region Métodos
        private void Excluir()
        {
             
            VendedorDAO objDao = new VendedorDAO();

            if(!objDao.VerificarSeTemVenda(codigoRegistro, Util.CodigoLogado))
            {
                Util.ExibirMsg(Util.TipoMsg.NaoPodeExcluir, Informacao);
                return;
            }

            

            try
            {
                objDao.ExcluirVendedor(codigoRegistro, Util.CodigoLogado);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();
                Consultar();

            }
            catch(Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.NaoPodeExcluir);
            }
        }
        

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
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
                campos += lblCPF.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                campos += lblEndereco.Text + "\n";
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(txtComissao.Text))
            {
                campos += lblComissao.Text + "\n";
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
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtComissao.Clear();
            txtNome.Focus();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            chkStatus.Visible = false;
            lblAtivo.Visible = false;
        }

        private void Cadastrar()
        {
            try
            {
                Vendedor objVendedor = new Vendedor();
                VendedorDAO objDao = new VendedorDAO();

                //objVendedor.Id = codigoRegistro; esse aqui só no alterar
                objVendedor.Vendedor1 = txtNome.Text;
                objVendedor.CPF = txtCpf.Text;
                objVendedor.Email = txtEmail.Text;
                objVendedor.Telefone = txtTelefone.Text;
                objVendedor.Endereco = txtEndereco.Text;
                objVendedor.Comissao = Convert.ToDecimal(txtComissao.Text);
                objVendedor.GaragemId = Util.CodigoLogado;

                Acesso objAcesso = new Acesso();

                objAcesso.Login = txtCpf.Text;
                objAcesso.Senha =Seguranca.GerarHash(txtCpf.Text);
                objAcesso.Status = 1;
                objAcesso.Tipo = (int)Util.TipoUsuario.Vendedor;
                objAcesso.GaragemId = Util.CodigoLogado;

                objVendedor.Acesso.Add(objAcesso);
                objDao.CadastrarVendedor(objVendedor);
            }
            catch (Exception ex)
            {

                throw;
            }
         
                

        }

        private bool VerificarCpfDuplicado()
        {
            return new VendedorDAO().VerificarCpfDuplicado(Util.CodigoLogado, txtCpf.Text);
        }

        private void Alterar()
        {
            try
            {
                Vendedor objVendedor = new Vendedor();
                VendedorDAO objDao = new VendedorDAO();

                objVendedor.Id = codigoRegistro;
                objVendedor.Vendedor1 = txtNome.Text;
                objVendedor.CPF = txtCpf.Text;
                objVendedor.Email = txtEmail.Text;
                objVendedor.Telefone = txtTelefone.Text;
                objVendedor.Endereco = txtEndereco.Text;
                objVendedor.Comissao = Convert.ToDecimal(txtComissao.Text);
                objVendedor.GaragemId = Util.CodigoLogado;

               new VendedorDAO().AlterarVendedor(objVendedor, (byte)(chkStatus.Checked ? 1 : 0));
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();
            }

            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
           
        }

        private void Consultar()
        {
            grdResultado.DataSource = new VendedorDAO().FiltrarVendedor(txtNome.Text.Trim(), Util.CodigoLogado);
            grdResultado.Columns["ObjEditar"].Visible = false;
            grdResultado.Columns["Situacao"].HeaderText = "Situação";
            grdResultado.Columns["Comissao"].HeaderText = "Comissão";
        }
        
        #endregion

       
    }
}
