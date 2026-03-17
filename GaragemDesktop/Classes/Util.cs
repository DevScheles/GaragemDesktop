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


        public enum ArquivoTela
        {
            Vendedor = 0,
            Marca = 1,
            Modelo=2
        }

        public const string PathXml = "C:\\Users\\Otávio\\source\\repos\\Projeto Garagem Desktop\\GaragemDesktop\\XML\\";

        public static string DevolverNomeArquivo(ArquivoTela tela)
        {
            string nome = string.Empty;

            switch (tela)
            {
                case ArquivoTela.Vendedor:
                    nome = "vendedor.xml";
                    break;
                case ArquivoTela.Marca:
                    nome = "marca.xml";
                    break;
                case ArquivoTela.Modelo:
                    nome = "moddelo.xml";
                    break;
                
            }

            return PathXml + nome;
        }








        public enum TipoUsuario
        {
            Adm= 1,
            Vendedor= 2
        }
        

        public enum TipoMsg
        {
            Erro,
            Atencao,
            Informativo,
            ConfirmacaoExclusao,
            CpfDuplicado,
            CpfInvalido,
            NaoPodeExcluir,
            NaoEncontrado
            
        }

       public enum EstadoTela
        {
            Novo,
            Edicao
        }

        public static void ConfigurarCombo(ComboBox combo,string display = "", string value = "")
        {

            if (display != "" && value != "")
            {
                combo.DisplayMember = display;
                combo.ValueMember = value;
                
            }
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FlatStyle = FlatStyle.Flat;

            combo.BackColor = Color.Maroon;
            combo.ForeColor = Color.White;


                
        }

        public static bool ExibirMsg(TipoMsg tipo, string campos = "")
        {
            bool ret = true;

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
                case TipoMsg.CpfDuplicado: 
                    MessageBox.Show("CPF já Cadastrado:\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case TipoMsg.CpfInvalido: 
                    MessageBox.Show("CPF inválido:\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case TipoMsg.NaoPodeExcluir: 
                    MessageBox.Show("Não pode ser excluido o registro:\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case TipoMsg.NaoEncontrado: 
                    MessageBox.Show("Não foi encontrado nenhum registro:", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.ConfirmacaoExclusao: 
                  if ( MessageBox.Show("Deseja confirmar a exclusão do registro:" + campos, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        ret = false;
                    }
                    break;
                default:
                    break;
            }

            return ret;

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

                    adicionar.BackColor = Color.FromArgb(0, 191, 99);
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

        public static bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }


        public static void ConfigurarFormulário(Form frm, string titulo)
        {
            frm.Text = titulo;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void ConfigurarGrid(DataGridView grd, bool multiline = false)
        {
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd.MultiSelect = multiline;
            grd.ReadOnly = true;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grd.BorderStyle = BorderStyle.None;
            grd.BackgroundColor = Color.FromArgb(20, 20, 20);
            grd.EnableHeadersVisualStyles = false;

            // HEADER
            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grd.ColumnHeadersHeight = 35;

            // LINHAS
            grd.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            grd.DefaultCellStyle.ForeColor = Color.White;
            grd.DefaultCellStyle.SelectionBackColor = Color.FromArgb(150, 0, 0);
            grd.DefaultCellStyle.SelectionForeColor = Color.White;
            grd.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            grd.RowTemplate.Height = 30;

            grd.RowHeadersVisible = false;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.AllowUserToResizeRows = false;
        }
    }
}

