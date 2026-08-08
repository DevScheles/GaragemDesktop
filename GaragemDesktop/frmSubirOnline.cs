using DAO;
using GaragemDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GaragemDesktop
{
    public partial class frmSubirOnline : Form
    {
        public frmSubirOnline()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_VEICULO);
            Util.ConfigurarGrid(grdResultado);
        }


        #region Eventos
        private void frmSubirOnline_Load(object sender, EventArgs e)
        {
            VerificarSeleção();
        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSelecioneTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSeleção();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            CadastrarOnline();
        }

        #endregion

        #region Métodos

        private void VerificarSeleção()
        {
            if(cbSelecioneTela.SelectedIndex > -1)
            {
                btnSubir.Visible = true;
                CarregarGrid();
            }

            else
            {
                btnSubir.Visible = false;
            }
        }
        
        private bool LimparCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (cbSelecioneTela.SelectedIndex == -1)
            {
                campos += lblSelecioneTela.Text + "\n";
                flag = false;
            }

            if (!flag)
            {
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
            }

            return flag;

        }

        private void CarregarGrid()
        {
            grdResultado.DataSource = null;
            string nomeArquivo = string.Empty;
            switch ((Util.ArquivoTela)cbSelecioneTela.SelectedIndex)
            {
                case Util.ArquivoTela.Marca:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Marca);

                    if (File.Exists(nomeArquivo))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(nomeArquivo);

                        if (ds.Tables.Count > 0)
                        {
                            grdResultado.DataSource = ds.Tables[0];
                        }

                    }

                    break;
                case Util.ArquivoTela.Modelo:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Modelo);

                    if (File.Exists(nomeArquivo))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(nomeArquivo);

                        if (ds.Tables.Count > 0)
                        {
                            grdResultado.DataSource = ds.Tables[0];
                        }

                    }
                    break;

                case Util.ArquivoTela.Adicional:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Adicional);

                    if (File.Exists(nomeArquivo))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(nomeArquivo);

                        if (ds.Tables.Count > 0)
                        {
                            grdResultado.DataSource = ds.Tables[0];
                        }
                    }
                    break;

                case Util.ArquivoTela.Foto:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Foto);

                    if (File.Exists(nomeArquivo))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(nomeArquivo);

                        if (ds.Tables.Count > 0)
                        {
                            grdResultado.DataSource = ds.Tables[0];
                        }
                    }
                    break;

                case Util.ArquivoTela.Veiculo:

                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Veiculo);

                    if (File.Exists(nomeArquivo))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(nomeArquivo);

                        if (ds.Tables.Count > 0)
                        {
                            grdResultado.DataSource = ds.Tables[0];
                        }
                    }

                    break;

                    
            }

            // --- OCULTAR A COLUNA ID AQUI ---
            if (grdResultado.Columns.Contains("idgaragem"))
            {
                grdResultado.Columns["idgaragem"].Visible = false;
            }

            // --- ALTERAR O TÍTULO DA COLUNA PARA "Nome" ---
            if (grdResultado.Columns.Contains("nome"))
            {
                grdResultado.Columns["nome"].HeaderText = "Nome";
            }
        }

        private void ExcluirItem(string nome)
        {
            XmlDocument xml = new XmlDocument();
            string nomeArquivo = string.Empty;

            switch((Util.ArquivoTela)cbSelecioneTela.SelectedIndex)
            {

                case Util.ArquivoTela.Marca:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Marca);
                    xml.Load(nomeArquivo);
                    XmlNode xmlnode = xml.SelectSingleNode($"//item[nome ='{nome}']");
                    if (xmlnode != null)
                    {
                        xmlnode.ParentNode.RemoveChild(xmlnode);
                        xml.Save(nomeArquivo);
                    }
                    break;

                case Util.ArquivoTela.Adicional:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Adicional);

                    xml.Load(nomeArquivo);

                    XmlNode xmlNode = xml.SelectSingleNode($"//item[nome='{nome}']");

                    if (xmlNode != null)
                    {
                        xmlNode.ParentNode.RemoveChild(xmlNode);
                        xml.Save(nomeArquivo);
                    }
                    break;

                case Util.ArquivoTela.Veiculo:
                    nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Veiculo);
                    if (File.Exists(nomeArquivo))
                    {
                        xml.Load(nomeArquivo);
                        XmlNode xmlNodeVeiculo = xml.SelectSingleNode($"//item[placa='{nome}']");
                        if (xmlNodeVeiculo != null)
                        {
                            xmlNodeVeiculo.ParentNode.RemoveChild(xmlNodeVeiculo);
                            xml.Save(nomeArquivo);
                        }
                    }
                    break;
            }
        }

        private void CadastrarOnline()
        {
            foreach (DataGridViewRow item in grdResultado.Rows)
            {
                if (!item.IsNewRow)
                {
                    switch ((Util.ArquivoTela)cbSelecioneTela.SelectedIndex)
                    {
                        case Util.ArquivoTela.Marca:
                            Marca objMarca = new Marca();
                            MarcaDAO objDAO = new MarcaDAO();

                            objMarca.Marca1 = item.Cells["nome"].Value.ToString();
                            objMarca.GaragemId = Convert.ToInt32(item.Cells["idgaragem"].Value);

                            objDAO.CadastrarMarca(objMarca);
                            ExcluirItem(objMarca.Marca1);
                            break;

                        case Util.ArquivoTela.Veiculo:
                            Veiculo objVeiculo = new Veiculo();
                            VeiculoDAO objVeiculoDAO = new VeiculoDAO();

                            // 1. DADOS BÁSICOS DO VEÍCULO
                            if (item.Cells["modeloId"].Value != null)
                                objVeiculo.ModeloId = Convert.ToInt32(item.Cells["modeloId"].Value);

                            if (item.Cells["valorCompra"].Value != null)
                                objVeiculo.ValorCompra = Convert.ToDecimal(item.Cells["valorCompra"].Value);

                            if (item.Cells["valorVenda"].Value != null)
                                objVeiculo.ValorVenda = Convert.ToDecimal(item.Cells["valorVenda"].Value);

                            if (item.Cells["quilometragem"].Value != null)
                                objVeiculo.Km = item.Cells["quilometragem"].Value.ToString();

                            if (item.Cells["situacao"].Value != null)
                            {
                                string situacaoTexto = item.Cells["situacao"].Value.ToString();

                                if (int.TryParse(situacaoTexto, out int situacaoId))
                                {
                                    objVeiculo.Situacao = situacaoId;
                                }
                                else
                                {
                                    if (situacaoTexto.Equals("Ativo", StringComparison.OrdinalIgnoreCase))
                                        objVeiculo.Situacao = 1;
                                    else if (situacaoTexto.Equals("Inativo", StringComparison.OrdinalIgnoreCase))
                                        objVeiculo.Situacao = 0;
                                    else
                                        objVeiculo.Situacao = 1;
                                }
                            }

                            if (item.Cells["placa"].Value != null)
                                objVeiculo.Placa = item.Cells["placa"].Value.ToString();

                            objVeiculo.Obs = item.Cells["obs"].Value?.ToString();

                            if (item.Cells["ano"].Value != null)
                                objVeiculo.Ano = item.Cells["ano"].Value.ToString();

                            if (item.Cells["leilao"].Value != null)
                            {
                                bool eLeilao = Convert.ToBoolean(item.Cells["leilao"].Value);
                                objVeiculo.Leilao = (byte)(eLeilao ? 1 : 0);
                            }

                            if (item.Cells["idgaragem"].Value != null)
                                objVeiculo.GaragemId = Convert.ToInt32(item.Cells["idgaragem"].Value);

                            // 2. BUSCA ADICIONAIS E FOTOS LENDO O ARQUIVO XML DIRETAMENTE PELA PLACA
                            List<int> lstAdicionais = new List<int>();
                            List<string> lstFotos = new List<string>();

                            string nomeArquivoXml = Util.DevolverNomeArquivo(Util.ArquivoTela.Veiculo);
                            if (File.Exists(nomeArquivoXml))
                            {
                                XmlDocument xmlDoc = new XmlDocument();
                                xmlDoc.Load(nomeArquivoXml);

                                XmlNode noXmlItem = xmlDoc.SelectSingleNode($"//item[placa='{objVeiculo.Placa}']");
                                if (noXmlItem != null)
                                {
                                    // Adicionais
                                    XmlNodeList noAdicionais = noXmlItem.SelectNodes("adicionais/adicional/id");
                                    if (noAdicionais != null)
                                    {
                                        foreach (XmlNode noId in noAdicionais)
                                        {
                                            if (int.TryParse(noId.InnerText, out int idAdic))
                                                lstAdicionais.Add(idAdic);
                                        }
                                    }

                                    // Fotos
                                    XmlNodeList noFotos = noXmlItem.SelectNodes("fotos/foto/caminhoLocal");
                                    if (noFotos != null)
                                    {
                                        foreach (XmlNode noCaminho in noFotos)
                                        {
                                            if (!string.IsNullOrEmpty(noCaminho.InnerText))
                                                lstFotos.Add(noCaminho.InnerText);
                                        }
                                    }
                                }
                            }

                            // 3. ENVIA PARA O BANCO DE DADOS ONLINE
                            objVeiculoDAO.CadastrarVeiculo(objVeiculo, lstAdicionais, lstFotos);

                            // 4. REMOVE DO XML OFFLINE
                            ExcluirItem(objVeiculo.Placa);
                            break;

                        case Util.ArquivoTela.Adicional:
                            Adicional objAdicional = new Adicional();
                            AdicionalDAO objDAOAdicional = new AdicionalDAO();

                            objAdicional.Nome = item.Cells["nome"].Value.ToString();
                            objAdicional.GaragemId = Convert.ToInt32(item.Cells["idgaragem"].Value);

                            objDAOAdicional.CadastrarAdicional(objAdicional);
                            ExcluirItem(objAdicional.Nome);
                            break;
                    }
                }
            }

            // Recarrega o Grid atualizando a visualização
            CarregarGrid();
        }


        #endregion

        
    }
}
