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
                    }

                }
                
            }
            grdResultado.DataSource = null;
        }


        #endregion

        private void btnSubir_Click(object sender, EventArgs e)
        {
            CadastrarOnline();
        }
    }
}
