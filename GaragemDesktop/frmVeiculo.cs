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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GaragemDesktop
{
    public partial class frmVeiculo : Form
    {

        bool ehPrimeiraVez = true;
        List<int> lstIdsAdicionais = new List<int>();
        List<string> lstFotos = new List<string>();
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
            Util.ConfigurarCombo(cbMarca, "Marca1", "Id");
            Util.ConfigurarCombo(cbModelo, "Modelo1", "Id");
            // Aqui você acessa a imagem que colocou no Resources
            picGravarOffline.Image = Properties.Resources.button_desligado; // imagem OFF
            picGravarOffline.Tag = "off"; // estado inicial
            CarregarMarca();
            CarregarAdicionais();
            grdAdicionais.ClearSelection();
            ehPrimeiraVez = false;

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
                    }
                }

                catch (Exception)
                {

                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
                }
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

            // Verifica se existe um veículo selecionado para exclusão
            if (codigoRegistro > 0)
            {
                // Pede confirmação do usuário antes de deletar
                if (MessageBox.Show("Deseja realmente excluir este veículo?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Instancia o DAO e chama o método de exclusão passando o ID do veículo
                        VeiculoDAO objDao = new VeiculoDAO();
                        objDao.ExcluirVeiculo(codigoRegistro);

                        // Exibe mensagem de sucesso
                        Util.ExibirMsg(Util.TipoMsg.Informativo);

                        // Limpa os campos da tela e reseta o estado dos botões
                        LimparCampos();
                        Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir veículo: " + ex.Message, "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um veículo antes de tentar excluir.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            new frmPesquisarVeiculo(this).ShowDialog();
        }

        private void grdAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o clique foi em uma linha válida
            if (e.RowIndex >= 0)
            {
                // Obtém o objeto Adicional da linha clicada
                Adicional adicionalSelecionado = grdAdicionais.Rows[e.RowIndex].DataBoundItem as Adicional;

                if (adicionalSelecionado != null)
                {
                    // 1. Alterna a presença na lista lógica de IDs selecionados
                    if (lstIdsAdicionais.Contains(adicionalSelecionado.Id))
                    {
                        lstIdsAdicionais.Remove(adicionalSelecionado.Id);
                    }
                    else
                    {
                        lstIdsAdicionais.Add(adicionalSelecionado.Id);
                    }

                    // 2. Se a grid tiver uma coluna do tipo CheckBox, altera a marcação visual
                    // Assumindo que a coluna do Checkbox é a primeira (índice 0) ou se chama "colMarcado"
                    foreach (DataGridViewCell cell in grdAdicionais.Rows[e.RowIndex].Cells)
                    {
                        if (cell is DataGridViewCheckBoxCell checkBoxCell)
                        {
                            bool estaMarcado = Convert.ToBoolean(checkBoxCell.Value ?? false);
                            checkBoxCell.Value = !estaMarcado;
                            break;
                        }
                    }

                    // Força a atualização da linha na grid
                    grdAdicionais.RefreshEdit();
                }
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (codigoRegistro > 0 && ValidarCampos())
            {
                try
                {
                    Veiculo veiculo = new Veiculo
                    {
                        Id = codigoRegistro,
                        GaragemId = Util.CodigoLogado,
                        ModeloId = (int)cbModelo.SelectedValue,
                        Km = txtKm.Text,
                        Obs = txtObs.Text,
                        Placa = txtPlaca.Text,
                        Situacao = cbSituacao.SelectedIndex,
                        Ano = txtAno.Text,
                        ValorCompra = Convert.ToDecimal(txtValorCompra.Text),
                        ValorVenda = Convert.ToDecimal(txtValorVenda.Text),
                        Leilao = (byte)(chkLeilao.Checked ? 1 : 0)
                    };

                    AdicionarItensConfiguracao();

                    // PASSE A LISTA DE FOTOS AQUI TAMBÉM
                    new VeiculoDAO().AlterarVeiculo(veiculo, lstIdsAdicionais, lstFotos);

                    Util.ExibirMsg(Util.TipoMsg.Informativo);
                    LimparCampos();
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnAdicionar, btnAlterar, btnExcluir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ehPrimeiraVez)
            {
                FiltrarModelo();
            }

        }

        private void picGravarOffline_Click(object sender, EventArgs e)
        {
            if (picGravarOffline.Tag.ToString() == "off")
            {
                picGravarOffline.Image = Properties.Resources.button_ligado;
                picGravarOffline.Tag = "on";
            }
            else
            {
                picGravarOffline.Image = Properties.Resources.button_desligado;
                picGravarOffline.Tag = "off";
            }
        }



        private void picAnexarFotos_Click(object sender, EventArgs e)
        {
            using (frmFoto telaFoto = new frmFoto(lstFotos))
            {
                if (telaFoto.ShowDialog() == DialogResult.OK)
                {
                    lstFotos = telaFoto.ListaFotosSelecionadas;
                }
            }
        }

        #endregion

        #region Métodos
        private void MarcarItemGrid()
        {
            grdAdicionais.ClearSelection();

            //Percorrendo as linhas selecionadas da grid

            foreach (DataGridViewRow linha in grdAdicionais.Rows)
            {

                //Checagem do tipo
                if (linha.DataBoundItem is Adicional)
                {
                    Adicional objLinhaSelecionada = (Adicional)linha.DataBoundItem;

                    int idDaVezAdicional = objLinhaSelecionada.Id;

                    if (lstIdsAdicionais.Contains(idDaVezAdicional))
                    {
                        linha.Selected = true;
                    }
                }
            }
        }

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
                if (Linha.DataBoundItem is Adicional)
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

        public void DetalharVeiculo(Veiculo objVeiculo)
        {
            // Armazena o ID do registro que está sendo editado
            codigoRegistro = objVeiculo.Id;

            cbMarca.SelectedValue = objVeiculo.Modelo.MarcaId;
            cbModelo.SelectedValue = objVeiculo.ModeloId;
            txtPlaca.Text = objVeiculo.Placa;
            txtAno.Text = objVeiculo.Ano;
            txtKm.Text = objVeiculo.Km;
            cbSituacao.SelectedIndex = objVeiculo.Situacao;
            txtValorCompra.Text = objVeiculo.ValorCompra.ToString();
            txtValorVenda.Text = objVeiculo.ValorVenda.ToString();
            txtObs.Text = objVeiculo.Obs;
            chkLeilao.Checked = objVeiculo.Leilao == 1;

            // Habilita os botões de Alterar e Excluir e desabilita o Adicionar
            Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnAdicionar, btnAlterar, btnExcluir);

            // 1. Carrega os adicionais do veículo
            lstIdsAdicionais.Clear();
            if (objVeiculo.Adicional != null)
            {
                foreach (var item in objVeiculo.Adicional)
                {
                    lstIdsAdicionais.Add(item.Id);
                }
            }
            MarcarItemGrid();

            // 2. CARREGA AS FOTOS SALVAS DO VEÍCULO
            lstFotos.Clear(); // Limpa fotos de buscas anteriores

            if (objVeiculo.Foto != null)
            {
                foreach (var foto in objVeiculo.Foto)
                {
                    lstFotos.Add(foto.Foto1);
                }
            }
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


                objDao.CadastrarVeiculo(veiculo, lstIdsAdicionais, lstFotos);
                Util.ExibirMsg(Util.TipoMsg.Informativo);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FiltrarModelo()
        {

            if (cbMarca.SelectedIndex > -1)
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
                Util.ExibirMsg(Util.TipoMsg.Atencao, campos);
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
            lstFotos.Clear();
        }

        private void CadastrarOff()
        {
            XmlDocument xml = new XmlDocument();
            string nomeArquivo = Util.DevolverNomeArquivo(Util.ArquivoTela.Veiculo);

            if (!File.Exists(nomeArquivo))
            {
                XmlElement noVeiculo = xml.CreateElement("veiculo");
                xml.AppendChild(noVeiculo);
            }
            else
            {
                xml.Load(nomeArquivo);
            }

            XmlElement xmlItem = xml.CreateElement("item");

            // 1. CAMPOS DA TELA
            XmlElement xmlMarcaId = xml.CreateElement("marcaId");
            xmlMarcaId.InnerText = Convert.ToString(cbMarca.SelectedValue);
            xmlItem.AppendChild(xmlMarcaId);

            XmlElement xmlModeloId = xml.CreateElement("modeloId");
            xmlModeloId.InnerText = Convert.ToString(cbModelo.SelectedValue);
            xmlItem.AppendChild(xmlModeloId);

            XmlElement xmlValorCompra = xml.CreateElement("valorCompra");
            xmlValorCompra.InnerText = txtValorCompra.Text.Trim();
            xmlItem.AppendChild(xmlValorCompra);

            XmlElement xmlValorVenda = xml.CreateElement("valorVenda");
            xmlValorVenda.InnerText = txtValorVenda.Text.Trim();
            xmlItem.AppendChild(xmlValorVenda);

            XmlElement xmlQuilometragem = xml.CreateElement("quilometragem");
            xmlQuilometragem.InnerText = txtKm.Text.Trim();
            xmlItem.AppendChild(xmlQuilometragem);

            XmlElement xmlSituacao = xml.CreateElement("situacao");
            xmlSituacao.InnerText = Convert.ToString(cbSituacao.SelectedValue ?? cbSituacao.Text);
            xmlItem.AppendChild(xmlSituacao);

            XmlElement xmlPlaca = xml.CreateElement("placa");
            xmlPlaca.InnerText = txtPlaca.Text.Trim();
            xmlItem.AppendChild(xmlPlaca);

            XmlElement xmlObs = xml.CreateElement("obs");
            xmlObs.InnerText = txtObs.Text.Trim();
            xmlItem.AppendChild(xmlObs);

            XmlElement xmlAno = xml.CreateElement("ano");
            xmlAno.InnerText = txtAno.Text.Trim();
            xmlItem.AppendChild(xmlAno);

            XmlElement xmlLeilao = xml.CreateElement("leilao");
            xmlLeilao.InnerText = chkLeilao.Checked.ToString().ToLower(); // "true" ou "false"
            xmlItem.AppendChild(xmlLeilao);

            XmlElement xmlCodGaragem = xml.CreateElement("idgaragem");
            xmlCodGaragem.InnerText = Util.CodigoLogado.ToString();
            xmlItem.AppendChild(xmlCodGaragem);


            // 2. LISTA DE ADICIONAIS SELECIONADOS DIRETO DA GRID
            XmlElement xmlAdicionais = xml.CreateElement("adicionais");

            foreach (DataGridViewRow row in grdAdicionais.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    XmlElement xmlAdicItem = xml.CreateElement("adicional");
                    XmlElement xmlAdicId = xml.CreateElement("id");

                    // Tenta pegar o ID pelo objeto vinculado (DataBoundItem) ou pela célula "id"
                    string idAdicional = "";

                    if (row.DataBoundItem != null)
                    {
                        // Se a linha tiver um objeto vinculado, pega a propriedade Id via reflexão/dinâmico
                        dynamic item = row.DataBoundItem;
                        idAdicional = item.Id.ToString();
                    }
                    else if (row.Cells["id"].Value != null) // Altere "id" para o Name da sua coluna de ID na grid
                    {
                        idAdicional = row.Cells["id"].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(idAdicional))
                    {
                        xmlAdicId.InnerText = idAdicional;
                        xmlAdicItem.AppendChild(xmlAdicId);
                        xmlAdicionais.AppendChild(xmlAdicItem);
                    }
                }
            }
            xmlItem.AppendChild(xmlAdicionais);


            // 3. LISTA DE FOTOS ANEXADAS
            XmlElement xmlFotos = xml.CreateElement("fotos");
            foreach (string caminhoFoto in lstFotos)
            {
                XmlElement xmlFotoItem = xml.CreateElement("foto");

                XmlElement xmlCaminho = xml.CreateElement("caminhoLocal");
                xmlCaminho.InnerText = caminhoFoto;
                xmlFotoItem.AppendChild(xmlCaminho);

                xmlFotos.AppendChild(xmlFotoItem);
            }
            xmlItem.AppendChild(xmlFotos);


            // SALVA NO XML
            XmlNode xmlRaiz = xml.SelectSingleNode("veiculo");
            xmlRaiz.AppendChild(xmlItem);

            xml.Save(nomeArquivo);
        }

        #endregion



       
    }
}
     
