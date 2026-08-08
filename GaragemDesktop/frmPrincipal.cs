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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace GaragemDesktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        #region Eventos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MaroonMenuRenderer();
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            CarregarEstoqueAtivo();
            CarregarVendasRealizadas();
            CarregarFaturamento();
            ConfigurarToolTips();
            Util.ConfigurarGrid(grdResultado);


            Consultar();

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRegistroMarcas().ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModelo().ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVendedor().ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmVeiculo().ShowDialog();
        }

        private void porVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarVendasVendedor().ShowDialog();
        }

        private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarVendas().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void grdResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalVeiculos_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlCardVeiculos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void lblGaragemAberta_Click(object sender, EventArgs e)
        {

        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdicionais().ShowDialog();
        }

        private void suvirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSubirOnline().ShowDialog();
        }

        private void lblCarregarVendas_Click(object sender, EventArgs e)
        {

        }

        private void pnlCardEstoque_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEstoqueAtivo_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Métodos
        private void EstilizarSubItem(ToolStripMenuItem sub)
        {
            Color maroon = Color.FromArgb(139, 0, 0);
            Color maroonHover = Color.FromArgb(110, 0, 0);

            sub.BackColor = maroon;
            sub.ForeColor = Color.Black;

            sub.AutoSize = false;
            sub.Height = 32;
            sub.Padding = new Padding(10, 0, 10, 0);

            // Hover
            sub.MouseEnter += (s, e) =>
            {
                sub.BackColor = maroonHover;
            };

            sub.MouseLeave += (s, e) =>
            {
                sub.BackColor = maroon;
            };

            // Clique (remove azul)
            sub.MouseDown += (s, e) =>
            {
                sub.BackColor = maroonHover;
            };

            sub.MouseUp += (s, e) =>
            {
                sub.BackColor = maroon;
            };
        }

        private void Consultar()
        {
            ModeloDAO objDAO = new ModeloDAO();
            List<ModeloVO> lstModelos = objDAO.ConsultarModelo(Util.CodigoLogado);
            grdResultado.DataSource = lstModelos;
            grdResultado.Columns["ObjEditar"].Visible = false;


        }

        // 1. Declare o objeto fora dos métodos (no topo da classe frmPrincipal)
        private ToolTip customToolTip = new ToolTip();

        //Configuração de toolTips dos icones do panel.
        private void ConfigurarToolTips()
        {
            // Desativa o tooltip amarelo padrão
            if (menuStrip1 != null) menuStrip1.ShowItemToolTips = false;

            // Configura o ToolTip para ser desenhado por nós
            customToolTip.OwnerDraw = true;
            customToolTip.Popup += CustomToolTip_Popup;
            customToolTip.Draw += CustomToolTip_Draw;

            // Associa o texto e eventos a cada ícone do menu
            VincularToolTipCustom(cadastrosToolStripMenuItem, "Cadastros");
            VincularToolTipCustom(vendedorToolStripMenuItem, "Cadastro Usuário");
            VincularToolTipCustom(veículoToolStripMenuItem, "Cadastro Veículo");
            VincularToolTipCustom(vendasToolStripMenuItem, "Consultar Vendas");
            VincularToolTipCustom(sairToolStripMenuItem, "Sair");
        }

        // Método auxiliar para exibir o ToolTip ao passar o mouse
        private void VincularToolTipCustom(ToolStripMenuItem item, string texto)
        {
            item.MouseEnter += (s, e) =>
            {
                Point posicaoMouse = this.PointToClient(Cursor.Position);
                customToolTip.Show(texto, this, posicaoMouse.X + 12, posicaoMouse.Y + 15);
            };

            item.MouseLeave += (s, e) =>
            {
                customToolTip.Hide(this);
            };
        }

        // Define o tamanho da caixa da dica (Largura x Altura)
        private void CustomToolTip_Popup(object sender, PopupEventArgs e)
        {
            // Aumenta a caixa para caber a fonte maior
            e.ToolTipSize = new Size(130, 32);
        }

        // Desenha visualmente a caixa com fundo escuro, texto branco e fonte maior
        private void CustomToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Cores alinhadas com o tema da Baronir Automóveis
            Color corFundo = Color.FromArgb(35, 35, 35);
            Color corBorda = Color.FromArgb(180, 40, 40); // Vermelho da logo
            Color corTexto = Color.White;

            using (SolidBrush brushFundo = new SolidBrush(corFundo))
            using (Pen penBorda = new Pen(corBorda, 1))
            using (Font fonteMaior = new Font("Segoe UI", 10F, FontStyle.Bold)) // <--- Tamanho e estilo da fonte
            {
                // Preenche o fundo
                e.Graphics.FillRectangle(brushFundo, e.Bounds);

                // Desenha a borda vermelha
                e.Graphics.DrawRectangle(penBorda, 0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1);

                // Desenha o texto centralizado e com fonte legível
                TextRenderer.DrawText(
                    e.Graphics,
                    e.ToolTipText,
                    fonteMaior,
                    e.Bounds,
                    corTexto,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter
                );
            }
        }


        private void CarregarEstoqueAtivo()
        {
            VeiculoDAO objDAO = new VeiculoDAO();

            lblEstoqueAtivo.Text = objDAO.ContarVeiculosAtivos(Util.CodigoLogado).ToString();
        }

        private void CarregarVendasRealizadas()
        {
            VeiculoDAO objDAO = new VeiculoDAO();

            lblCarregarVendasRealizadas.Text = objDAO.ContarVeiculosVendidos(Util.CodigoLogado).ToString();
        }

        private void CarregarFaturamento()
        {
            VeiculoDAO objDAO = new VeiculoDAO();
            decimal faturamento = objDAO.ObterFaturamentoTotal(Util.CodigoLogado);

            // Formata o decimal no formato de moeda brasileira (ex: R$ 15.000,00)
            lblFaturamento.Text = faturamento.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
        }


    }
    #endregion
}

