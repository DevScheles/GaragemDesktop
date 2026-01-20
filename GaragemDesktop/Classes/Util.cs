using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemDesktop.Classes
{
    public static class Util

    {

        public static int CodigoLogado = 1;
        

        public enum TipoMsg
        {
            Erro,
            Atencao,
            Informativo
            
        }

       public enum EstadoTela
        {
            Novo,
            Edicao
        }

        public static void ExibirMsg(TipoMsg tipo, string campos = "")
        {
            switch (tipo)
            {
                case TipoMsg.Erro:
                    MessageBox.Show("Ocorreu um erro tente novamente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.Atencao:
                    MessageBox.Show("Preencher o(s) campo(s)\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case TipoMsg.Informativo: 
                    MessageBox.Show("Ação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Metodo responsável por gerenciar os botões da tela.
        /// </summary>
        /// <param name="estadoTela">Estado da tela</param>
        /// <param name="adicionar">Botão Adicionar</param>
        /// <param name="alterar">Botão Alterar</param>
        /// <param name="excluir">Botão Excluir</param>

      public static void ConfigurarEstadoTela(EstadoTela estadoTela, Button adicionar, Button alterar, Button excluir)
        {
            switch (estadoTela)
            {
                case EstadoTela.Novo:
                    adicionar.Enabled = true;
                    alterar.Enabled = false;
                    excluir.Enabled = false;

                    alterar.BackColor = Color.Gray;
                    excluir.BackColor = Color.Gray;

                    break;
                case EstadoTela.Edicao:
                    adicionar.Enabled = false;
                    alterar.Enabled = true;
                    excluir.Enabled = true;

                    adicionar.BackColor = Color.Gray;
                    alterar.BackColor = Color.RoyalBlue;
                    excluir.BackColor = Color.Maroon;


                    break;
                default:
                    break;
            }
        }


        public static void ConfigurarFormulário(Form frm, string titulo)
        {
            frm.Text = titulo;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void ConfigurarGrid(DataGridView grd)
        {
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd.MultiSelect = false;
            grd.ReadOnly = true;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
