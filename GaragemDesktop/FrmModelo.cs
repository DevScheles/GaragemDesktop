using DAO;
using DAO.VO;
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
    public partial class FrmModelo : Form
    {
        int codigoRegistro = 0;
        string informacao = string.Empty;
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
            Util.ConfigurarCombo(cbSelecioneMarca, "Marca", "Id");
            CarregarMarcas();
            Consultar();
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
            //if (ValidarCampos())
            //{
            //    Cadastrar();
            //    LimparCampos();
            //    Consultar();
            //    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
            //}
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
                        LimparCampos();
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
                ModeloVO objLinhaClicada = (ModeloVO)grdResultado.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaClicada.ObjEditar.Modelo1;
                cbSelecioneMarca.SelectedValue = objLinhaClicada.ObjEditar.MarcaId;


                codigoRegistro = objLinhaClicada.ObjEditar.Id;
                informacao = objLinhaClicada.ObjEditar.Modelo1;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnAdicionar, btnAlterar, btnExcluir);
            }
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

            if (string.IsNullOrWhiteSpace(txtNome.Text))
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
            cbSelecioneMarca.SelectedIndex = -1;
            txtNome.Clear();
        }

        private void CarregarMarcas()
        {
            MarcaDAO objDAO = new MarcaDAO();
            List<Marca> lstMarcas = objDAO.ConsultarMarcas(Util.CodigoLogado);
            cbSelecioneMarca.DisplayMember = "Marca1";
            cbSelecioneMarca.ValueMember = "Id";


            cbSelecioneMarca.DataSource = lstMarcas;
            cbSelecioneMarca.SelectedIndex = -1;
        }

        private void Cadastrar()
        {
            ModeloDAO objDAO = new ModeloDAO();
            Modelo objModelo = new Modelo();

            try
            {
                objModelo.Modelo1 = txtNome.Text;
                objModelo.MarcaId = (int)cbSelecioneMarca.SelectedValue;
                objModelo.GaragemId = Util.CodigoLogado;

                objDAO.CadastrarModelo(objModelo);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }

        }


        private void CadastrarOff()
        {
            XmlDocument xml = new XmlDocument();
            string nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Modelo);

            if (!File.Exists(nomeArquivo))
            {
                //Cria o XML com a base
                XmlElement noModelo = xml.CreateElement("modelo");
                xml.AppendChild(noModelo);
            }
            else
            {
                xml.Load(nomeArquivo);
            }

            XmlElement xmlItem = xml.CreateElement("item");

            XmlElement xmlMarca = xml.CreateElement("marcaId");
            xmlMarca.InnerText = Convert.ToString(cbSelecioneMarca.SelectedValue);
            xmlItem.AppendChild(xmlMarca);

            XmlElement xmlModelo = xml.CreateElement("nome");
            xmlModelo.InnerText = txtNome.Text.Trim();
            xmlItem.AppendChild(xmlModelo);

            XmlElement xmlCodGaragem = xml.CreateElement("idgaragem");
            xmlCodGaragem.InnerText = Util.CodigoLogado.ToString();
            xmlItem.AppendChild(xmlCodGaragem);

            //Recupera o nó raiz
            XmlNode xmlRaiz = xml.SelectSingleNode("modelo");

            xmlRaiz.AppendChild(xmlItem);

            xml.Save(nomeArquivo);


        }

        private void Alterar()
        {
            ModeloDAO objDAO = new ModeloDAO();
            Modelo objModelo = new Modelo();

            objModelo.Modelo1 = txtNome.Text;
            objModelo.MarcaId = (int)cbSelecioneMarca.SelectedValue;
            objModelo.Id = codigoRegistro;

            objDAO.AlterarModelo(objModelo);

            try
            {
                Util.ExibirMsg(Util.TipoMsg.Informativo);
                LimparCampos();
            }
            catch
            {


            }
        }


        private void Excluir()
        {
            try
            {
                ModeloDAO objDAO = new ModeloDAO();
                objDAO.ExcluirModelo(codigoRegistro);
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
            ModeloDAO objDAO = new ModeloDAO();
            List<ModeloVO> lstModelos = objDAO.ConsultarModelo(Util.CodigoLogado);
            grdResultado.DataSource = lstModelos;
            grdResultado.Columns["ObjEditar"].Visible = false;


        }


        #endregion


    }
}


