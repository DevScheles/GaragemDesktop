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
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelecioneMarca = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblCadastrarVeiculo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picVendedorAtivo = new System.Windows.Forms.PictureBox();
            this.lblFiltrarPeloNome = new System.Windows.Forms.Label();
            this.cbSelecioneMarca = new System.Windows.Forms.ComboBox();
            this.lblSelecioneModelo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.cbSelecioneModelo = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedorAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(164, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1101;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1271, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 1097;
            this.label5.Text = "ATIVO";
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
            // grdResultado
            // 
            this.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(426, 374);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.RowTemplate.Height = 24;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(658, 280);
            this.grdResultado.TabIndex = 1090;
            this.grdResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(908, 730);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 45);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1089;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(658, 730);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1088;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(419, 730);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1087;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(173, 730);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1086;
            this.pictureBox5.TabStop = false;
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
            this.pictureBox2.Size = new System.Drawing.Size(310, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1098;
            this.pictureBox2.TabStop = false;
            // 
            // picVendedorAtivo
            // 
            this.picVendedorAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVendedorAtivo.Image = ((System.Drawing.Image)(resources.GetObject("picVendedorAtivo.Image")));
            this.picVendedorAtivo.Location = new System.Drawing.Point(1294, 12);
            this.picVendedorAtivo.Name = "picVendedorAtivo";
            this.picVendedorAtivo.Size = new System.Drawing.Size(114, 57);
            this.picVendedorAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVendedorAtivo.TabIndex = 1096;
            this.picVendedorAtivo.TabStop = false;
            // 
            // lblFiltrarPeloNome
            // 
            this.lblFiltrarPeloNome.AutoSize = true;
            this.lblFiltrarPeloNome.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPeloNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltrarPeloNome.Location = new System.Drawing.Point(168, 334);
            this.lblFiltrarPeloNome.Name = "lblFiltrarPeloNome";
            this.lblFiltrarPeloNome.Size = new System.Drawing.Size(125, 28);
            this.lblFiltrarPeloNome.TabIndex = 1102;
            this.lblFiltrarPeloNome.Text = "ADICIONAIS:";
            // 
            // cbSelecioneMarca
            // 
            this.cbSelecioneMarca.BackColor = System.Drawing.Color.Maroon;
            this.cbSelecioneMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSelecioneMarca.FormattingEnabled = true;
            this.cbSelecioneMarca.Location = new System.Drawing.Point(513, 96);
            this.cbSelecioneMarca.Name = "cbSelecioneMarca";
            this.cbSelecioneMarca.Size = new System.Drawing.Size(227, 37);
            this.cbSelecioneMarca.TabIndex = 1;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(432, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 28);
            this.label8.TabIndex = 1091;
            this.label8.Text = "ANO:";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Impact", 13.8F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(886, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 32);
            this.checkBox1.TabIndex = 1107;
            this.checkBox1.Text = "LEILÃO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 9.8F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(169, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 21);
            this.label3.TabIndex = 1108;
            this.label3.Text = "Para selecionar mais de uma linha CLIQUE NA LINHA selecionando o botão Ctrl";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1153, 730);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1087;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1153, 433);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1101;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 9.8F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(1181, 596);
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
            this.txtValorCompra.TabIndex = 1109;
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.BackColor = System.Drawing.Color.Maroon;
            this.txtQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilometragem.ForeColor = System.Drawing.Color.White;
            this.txtQuilometragem.Location = new System.Drawing.Point(513, 227);
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.Size = new System.Drawing.Size(227, 36);
            this.txtQuilometragem.TabIndex = 1110;
            // 
            // cbSelecioneModelo
            // 
            this.cbSelecioneModelo.BackColor = System.Drawing.Color.Maroon;
            this.cbSelecioneModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSelecioneModelo.FormattingEnabled = true;
            this.cbSelecioneModelo.Location = new System.Drawing.Point(1004, 96);
            this.cbSelecioneModelo.Name = "cbSelecioneModelo";
            this.cbSelecioneModelo.Size = new System.Drawing.Size(227, 37);
            this.cbSelecioneModelo.TabIndex = 1111;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.Color.Maroon;
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.ForeColor = System.Drawing.Color.White;
            this.txtValorVenda.Location = new System.Drawing.Point(1004, 162);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(227, 36);
            this.txtValorVenda.TabIndex = 1112;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Maroon;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAno.ForeColor = System.Drawing.Color.White;
            this.txtAno.Location = new System.Drawing.Point(513, 294);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(227, 36);
            this.txtAno.TabIndex = 1114;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(173, 730);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 47);
            this.btnAdicionar.TabIndex = 1115;
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
            this.btnAlterar.Location = new System.Drawing.Point(420, 730);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(180, 47);
            this.btnAlterar.TabIndex = 1116;
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
            this.btnExcluir.Location = new System.Drawing.Point(667, 730);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 47);
            this.btnExcluir.TabIndex = 1117;
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
            this.btnCancelar.Location = new System.Drawing.Point(905, 730);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 1118;
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
            this.btnPesquisar.Location = new System.Drawing.Point(1152, 730);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 45);
            this.btnPesquisar.TabIndex = 1119;
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
            this.cbSituacao.TabIndex = 1120;
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1440, 851);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.cbSelecioneModelo);
            this.Controls.Add(this.txtQuilometragem);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cbSelecioneMarca);
            this.Controls.Add(this.lblFiltrarPeloNome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSelecioneModelo);
            this.Controls.Add(this.lblSelecioneMarca);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblQuilometragem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblCadastrarVeiculo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picVendedorAtivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmVeiculo";
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedorAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelecioneMarca;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblCadastrarVeiculo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picVendedorAtivo;
        private System.Windows.Forms.Label lblFiltrarPeloNome;
        private System.Windows.Forms.ComboBox cbSelecioneMarca;
        private System.Windows.Forms.Label lblSelecioneModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtQuilometragem;
        private System.Windows.Forms.ComboBox cbSelecioneModelo;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbSituacao;
    }
}