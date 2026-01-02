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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
       
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        menuStrip1.Renderer = new MaroonMenuRenderer();
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
        }




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
    }
}

