using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GaragemDesktop
{
    public partial class frmFoto : Form
    {
        public List<string> ListaFotosSelecionadas { get; private set; }

        public frmFoto(List<string> fotosExistentes = null)
        {
            InitializeComponent();

            ListaFotosSelecionadas = fotosExistentes != null
                ? new List<string>(fotosExistentes)
                : new List<string>();

            // Configurações do FlowLayoutPanel para garantir exibição
            FlpExibicaoDeFotos.AutoScroll = true;
            FlpExibicaoDeFotos.WrapContents = true;

            RenderizarFotos();
        }

        private void RenderizarFotos()
        {
            FlpExibicaoDeFotos.Controls.Clear();

            foreach (string itemFoto in ListaFotosSelecionadas)
            {
                Image imagemExibicao = null;

                // 1. Tenta carregar se for arquivo físico no computador
                if (File.Exists(itemFoto))
                {
                    try
                    {
                        using (var stream = new FileStream(itemFoto, FileMode.Open, FileAccess.Read))
                        {
                            imagemExibicao = Image.FromStream(stream);
                        }
                    }
                    catch { }
                }
                // 2. Tenta carregar se for Base64 (salvo no banco de dados)
                else
                {
                    try
                    {
                        byte[] imageBytes = Convert.FromBase64String(itemFoto);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            imagemExibicao = Image.FromStream(ms);
                        }
                    }
                    catch { }
                }

                if (imagemExibicao != null)
                {
                    // Quadro do card aumentado (Largura: 220, Altura: 240)
                    Panel cardPanel = new Panel
                    {
                        Width = 220,
                        Height = 240,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        BackColor = Color.FromArgb(40, 40, 40)
                    };

                    // Imagem do veículo aumentada (Largura: 210, Altura: 180)
                    PictureBox pic = new PictureBox
                    {
                        Image = new Bitmap(imagemExibicao),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 210,
                        Height = 180,
                        Location = new Point(4, 4)
                    };

                    // Botão de excluir reajustado
                    Button btnExcluir = new Button
                    {
                        Text = "Excluir",
                        ForeColor = Color.White,
                        BackColor = Color.Crimson,
                        FlatStyle = FlatStyle.Flat,
                        Width = 210,
                        Height = 35,
                        Location = new Point(4, 190)
                    };
                    btnExcluir.FlatAppearance.BorderSize = 0;

                    string fotoRemover = itemFoto;
                    btnExcluir.Click += (s, ev) =>
                    {
                        pic.Image?.Dispose();
                        ListaFotosSelecionadas.Remove(fotoRemover);
                        RenderizarFotos();
                    };

                    cardPanel.Controls.Add(pic);
                    cardPanel.Controls.Add(btnExcluir);

                    FlpExibicaoDeFotos.Controls.Add(cardPanel);
                }
            }

            FlpExibicaoDeFotos.Refresh();
        }

        // Evento do botão "Selecionar" (Certifique-se de vincular este evento ao botão no Designer)
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecionar Fotos";
                dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string arquivo in dialog.FileNames)
                    {
                        if (!ListaFotosSelecionadas.Contains(arquivo))
                        {
                            ListaFotosSelecionadas.Add(arquivo);
                        }
                    }

                    RenderizarFotos();
                }
            }
        }

        // Evento do botão "Salvar"
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecionar Fotos";
                dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {




                    foreach (string arquivo in dialog.FileNames)
                    {
                        if (!ListaFotosSelecionadas.Contains(arquivo))
                        {
                            ListaFotosSelecionadas.Add(arquivo);
                        }
                    }

                    RenderizarFotos();
                }
            }
        }

        private void frmFoto_Load(object sender, EventArgs e)
        {

        }
    }
}