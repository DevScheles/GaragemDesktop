using GaragemDesktop.Classes;
using System;
using System.Windows.Forms;
using DAO;

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

        #region Eventos
        private void frmRegistroMarcas_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
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

        #region Metódos

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
