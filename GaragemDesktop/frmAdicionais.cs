using DAO;
using GaragemDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GaragemDesktop
{
    public partial class frmAdicionais : Form
    {
        public frmAdicionais()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_ADICIONAIS);
            Util.ConfigurarGrid(grdResultado);
        }

        int codigoRegistro = 0;
        string Informação = string.Empty;

        #region Eventos

        private void frmAdicionais_Load(object sender, EventArgs e)
        {
            // Aqui você acessa a imagem que colocou no Resources
            picGravarOffline.Image = Properties.Resources.button_desligado; // imagem OFF
            picGravarOffline.Tag = "off"; // estado inicial
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            Consultar();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                try
                {
                    if (picGravarOffline.Tag.ToString() == "on")
                    {
                        // Ligar
                        picGravarOffline.Image = Properties.Resources.button_ligado;
                        picGravarOffline.Tag = "on";
                        CadastrarOff();
                        LimparCampos();
                        Util.ExibirMsg(Util.TipoMsg.Informativo);

                    }


                    else
                    {
                        // Desligar
                        picGravarOffline.Image = Properties.Resources.button_desligado;
                        picGravarOffline.Tag = "off";
                        Cadastrar();
                        Consultar();
                    }
                }



                catch (Exception)
                {

                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
                }


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
                Adicional objLinhaClicada = (Adicional)grdResultado.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaClicada.Nome;
                codigoRegistro = objLinhaClicada.Id;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnAdicionar, btnAlterar, btnExcluir);
            }
        }

        private void picGravarOffline_Click_1(object sender, EventArgs e)
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

        #endregion


        #region Métodos


        private void CadastrarOff()
        {
            XmlDocument xml = new XmlDocument();
            string nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Adicional);

            if (!File.Exists(nomeArquivo))
            {
                // Cria o XML com o nó raiz
                XmlElement noAdicional = xml.CreateElement("adicional");
                xml.AppendChild(noAdicional);
            }
            else
            {
                // Carrega o XML já existente
                xml.Load(nomeArquivo);
            }

            // Cria um novo item
            XmlElement xmlItem = xml.CreateElement("item");

            XmlElement xmlNome = xml.CreateElement("nome");
            xmlNome.InnerText = txtNome.Text;
            xmlItem.AppendChild(xmlNome);

            XmlElement xmlCodGaragem = xml.CreateElement("idgaragem");
            xmlCodGaragem.InnerText = Util.CodigoLogado.ToString();
            xmlItem.AppendChild(xmlCodGaragem);

            // Adiciona o item ao XML
            XmlNode xmlRaiz = xml.SelectSingleNode("adicional");
            xmlRaiz.AppendChild(xmlItem);

            // Salva o arquivo
            xml.Save(nomeArquivo);
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                campos = lblNomeDoAdicional.Text;
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;

        }

        private void Consultar()
        {
            AdicionalDAO objDao = new AdicionalDAO();
            List<Adicional> lstRetorno = objDao.ConsultarAdicionais(Util.CodigoLogado);
            grdResultado.DataSource = lstRetorno;

            //Altera a visibiliadade de colunas na gridview
            grdResultado.Columns["Id"].Visible = false;
            grdResultado.Columns["GaragemId"].Visible = false;
            grdResultado.Columns["Garagem"].Visible = false;
            grdResultado.Columns["Veiculo"].Visible = false;

            //Altera o nome das colunas
            grdResultado.Columns["Nome"].HeaderText = "Nome do Adicional";


        }

        private void Cadastrar()
        {
            //Cria o obj que terá o metodo cadastrar
            AdicionalDAO objDao = new AdicionalDAO();

            //Cria o obj que terá as informações
            Adicional objAdicional = new Adicional();

            objAdicional.Nome = txtNome.Text;
            objAdicional.GaragemId = Util.CodigoLogado;

            try
            {
                objDao.CadastrarAdicional(objAdicional);
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
            //Cria o obj que terá o método cadastrar
            AdicionalDAO objDao = new AdicionalDAO();

            //Cria o obj que terá as informações
            Adicional objAdicional = new Adicional();

            objAdicional.Nome = txtNome.Text;
            objAdicional.Id = codigoRegistro;

            objDao.AlterarAdicional(objAdicional);

            try
            {
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();
            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);

            }
        }

        private void Excluir()
        {
            AdicionalDAO objDao = new AdicionalDAO();

            try
            {
                objDao.ExcluirAdicional(codigoRegistro);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();

            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtNome.Focus();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
        }


        #endregion

       
    }
}
    

