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

namespace GaragemDesktop
{
    public partial class frmConsultarVendas : Form
    {
        public frmConsultarVendas()
        {
            InitializeComponent();
            Util.ConfigurarFormulário(this, Texto.TITULO_CONSULTAR_VENDAS);
            Util.ConfigurarGrid(grdResultado);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultarVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
