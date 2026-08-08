namespace GaragemDesktop
{
    partial class frmVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelecioneMarca = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.grdAdicionais = new System.Windows.Forms.DataGridView();
            this.lblCadastrarVeiculo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picGravarOffline = new System.Windows.Forms.PictureBox();
            this.lblFiltrarPeloNome = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblSelecioneModelo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.chkLeilao = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picAnexarFotos = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGravarOffline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnexarFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1101;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelecioneMarca
            // 
            this.lblSelecioneMarca.AutoSize = true;
            this.lblSelecioneMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneMarca.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecioneMarca.Location = new System.Drawing.Point(281, 96);
            this.lblSelecioneMarca.Name = "lblSelecioneMarca";
            this.lblSelecioneMarca.Size = new System.Drawing.Size(198, 28);
            this.lblSelecioneMarca.TabIndex = 1094;
            this.lblSelecioneMarca.Text = "SELECIONE A MARCA:";
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilometragem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuilometragem.Location = new System.Drawing.Point(307, 228);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(172, 28);
            this.lblQuilometragem.TabIndex = 1092;
            this.lblQuilometragem.Text = "QUILOMETRAGEM:";
            // 
            // grdAdicionais
            // 
            this.grdAdicionais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAdicionais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAdicionais.Location = new System.Drawing.Point(426, 427);
            this.grdAdicionais.MultiSelect = false;
            this.grdAdicionais.Name = "grdAdicionais";
            this.grdAdicionais.ReadOnly = true;
            this.grdAdicionais.RowHeadersWidth = 51;
            this.grdAdicionais.RowTemplate.Height = 24;
            this.grdAdicionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAdicionais.Size = new System.Drawing.Size(658, 280);
            this.grdAdicionais.TabIndex = 1090;
            // 
            // lblCadastrarVeiculo
            // 
            this.lblCadastrarVeiculo.AutoSize = true;
            this.lblCadastrarVeiculo.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarVeiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastrarVeiculo.Location = new System.Drawing.Point(612, 9);
            this.lblCadastrarVeiculo.Name = "lblCadastrarVeiculo";
            this.lblCadastrarVeiculo.Size = new System.Drawing.Size(369, 53);
            this.lblCadastrarVeiculo.TabIndex = 1085;
            this.lblCadastrarVeiculo.Text = "CADASTRAR VEÍCULO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-11, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1098;
            this.pictureBox2.TabStop = false;
            // 
            // picGravarOffline
            // 
            this.picGravarOffline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGravarOffline.Image = ((System.Drawing.Image)(resources.GetObject("picGravarOffline.Image")));
            this.picGravarOffline.Location = new System.Drawing.Point(1294, 12);
            this.picGravarOffline.Name = "picGravarOffline";
            this.picGravarOffline.Size = new System.Drawing.Size(114, 57);
            this.picGravarOffline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGravarOffline.TabIndex = 1096;
            this.picGravarOffline.TabStop = false;
            this.picGravarOffline.Click += new System.EventHandler(this.picGravarOffline_Click);
            // 
            // lblFiltrarPeloNome
            // 
            this.lblFiltrarPeloNome.AutoSize = true;
            this.lblFiltrarPeloNome.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPeloNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltrarPeloNome.Location = new System.Drawing.Point(168, 387);
            this.lblFiltrarPeloNome.Name = "lblFiltrarPeloNome";
            this.lblFiltrarPeloNome.Size = new System.Drawing.Size(125, 28);
            this.lblFiltrarPeloNome.TabIndex = 1102;
            this.lblFiltrarPeloNome.Text = "ADICIONAIS:";
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.Maroon;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(513, 96);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(227, 37);
            this.cbMarca.TabIndex = 1;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // lblSelecioneModelo
            // 
            this.lblSelecioneModelo.AutoSize = true;
            this.lblSelecioneModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneModelo.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecioneModelo.Location = new System.Drawing.Point(773, 96);
            this.lblSelecioneModelo.Name = "lblSelecioneModelo";
            this.lblSelecioneModelo.Size = new System.Drawing.Size(208, 28);
            this.lblSelecioneModelo.TabIndex = 1094;
            this.lblSelecioneModelo.Text = "SELECIONE O MODELO:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlaca.Location = new System.Drawing.Point(401, 295);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(76, 28);
            this.lblPlaca.TabIndex = 1091;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorCompra.Location = new System.Drawing.Point(322, 162);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(157, 28);
            this.lblValorCompra.TabIndex = 1092;
            this.lblValorCompra.Text = "VALOR COMPRA:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorVenda.Location = new System.Drawing.Point(843, 162);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(138, 28);
            this.lblValorVenda.TabIndex = 1092;
            this.lblValorVenda.Text = "VALOR VENDA:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSituacao.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSituacao.Location = new System.Drawing.Point(871, 230);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(110, 28);
            this.lblSituacao.TabIndex = 1106;
            this.lblSituacao.Text = "SITUAÇÃO:";
            // 
            // chkLeilao
            // 
            this.chkLeilao.AutoSize = true;
            this.chkLeilao.Font = new System.Drawing.Font("Impact", 13.8F);
            this.chkLeilao.ForeColor = System.Drawing.Color.White;
            this.chkLeilao.Location = new System.Drawing.Point(940, 362);
            this.chkLeilao.Name = "chkLeilao";
            this.chkLeilao.Size = new System.Drawing.Size(95, 32);
            this.chkLeilao.TabIndex = 10;
            this.chkLeilao.Text = "LEILÃO";
            this.chkLeilao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 9.8F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(169, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 21);
            this.label3.TabIndex = 1108;
            this.label3.Text = "Para selecionar mais de uma linha CLIQUE NA LINHA selecionando o botão Ctrl";
            // 
            // picAnexarFotos
            // 
            this.picAnexarFotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnexarFotos.BackColor = System.Drawing.Color.Transparent;
            this.picAnexarFotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAnexarFotos.Image = ((System.Drawing.Image)(resources.GetObject("picAnexarFotos.Image")));
            this.picAnexarFotos.Location = new System.Drawing.Point(1153, 486);
            this.picAnexarFotos.Name = "picAnexarFotos";
            this.picAnexarFotos.Size = new System.Drawing.Size(152, 193);
            this.picAnexarFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnexarFotos.TabIndex = 1101;
            this.picAnexarFotos.TabStop = false;
            this.picAnexarFotos.Click += new System.EventHandler(this.picAnexarFotos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 9.8F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(1181, 649);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 1108;
            this.label10.Text = "Anexar Fotos";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BackColor = System.Drawing.Color.Maroon;
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.ForeColor = System.Drawing.Color.White;
            this.txtValorCompra.Location = new System.Drawing.Point(513, 161);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(227, 36);
            this.txtValorCompra.TabIndex = 3;
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.Maroon;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.ForeColor = System.Drawing.Color.White;
            this.txtKm.Location = new System.Drawing.Point(513, 227);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(227, 36);
            this.txtKm.TabIndex = 5;
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.Maroon;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(1004, 96);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(227, 37);
            this.cbModelo.TabIndex = 2;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.Color.Maroon;
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.ForeColor = System.Drawing.Color.White;
            this.txtValorVenda.Location = new System.Drawing.Point(1004, 162);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(227, 36);
            this.txtValorVenda.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(173, 771);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 47);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(420, 771);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(180, 47);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(667, 771);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 47);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(905, 771);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(1152, 771);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 45);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbSituacao
            // 
            this.cbSituacao.BackColor = System.Drawing.Color.Maroon;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Vendido"});
            this.cbSituacao.Location = new System.Drawing.Point(1004, 228);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(227, 37);
            this.cbSituacao.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblObs.Location = new System.Drawing.Point(926, 295);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(55, 28);
            this.lblObs.TabIndex = 1106;
            this.lblObs.Text = "OBS:";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.Maroon;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.ForeColor = System.Drawing.Color.White;
            this.txtObs.Location = new System.Drawing.Point(1004, 291);
            this.txtObs.MaxLength = 1000;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(227, 36);
            this.txtObs.TabIndex = 8;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAno.Location = new System.Drawing.Point(420, 356);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(54, 28);
            this.lblAno.TabIndex = 1091;
            this.lblAno.Text = "ANO:";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Maroon;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAno.ForeColor = System.Drawing.Color.White;
            this.txtAno.Location = new System.Drawing.Point(513, 355);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(227, 36);
            this.txtAno.TabIndex = 9;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Maroon;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(513, 291);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(227, 36);
            this.txtPlaca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1180, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 1122;
            this.label5.Text = "GRAVAR OFFLINE";
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1440, 884);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.chkLeilao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblFiltrarPeloNome);
            this.Controls.Add(this.picAnexarFotos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelecioneModelo);
            this.Controls.Add(this.lblSelecioneMarca);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblQuilometragem);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.grdAdicionais);
            this.Controls.Add(this.lblCadastrarVeiculo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picGravarOffline);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmVeiculo";
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGravarOffline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnexarFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelecioneMarca;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.DataGridView grdAdicionais;
        private System.Windows.Forms.Label lblCadastrarVeiculo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picGravarOffline;
        private System.Windows.Forms.Label lblFiltrarPeloNome;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblSelecioneModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.CheckBox chkLeilao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picAnexarFotos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label5;
    }
}