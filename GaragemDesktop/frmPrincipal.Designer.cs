namespace GaragemDesktop
{
    partial class frmPrincipal
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
            System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suvirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardEstoque = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblEstoqueAtivo = new System.Windows.Forms.Label();
            this.lblEstoqueDisponivel = new System.Windows.Forms.Label();
            this.pnlCardVendas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblCarregarVendasRealizadas = new System.Windows.Forms.Label();
            this.lblVendasRealizadas = new System.Windows.Forms.Label();
            this.pnlCardFaturamento = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.lblReceitaFaturada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblGaragemAberta = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblVeiculosCadastrados = new System.Windows.Forms.Label();
            this.lblVeiculosNoPatio = new System.Windows.Forms.Label();
            this.lblTotalVeiculos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCardVeiculos = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowCards.SuspendLayout();
            this.pnlCardEstoque.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlCardVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlCardFaturamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCardVeiculos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 11F);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cadastrosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.adicionaisToolStripMenuItem,
            this.suvirToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.cadastrosToolStripMenuItem.Image = global::GaragemDesktop.Properties.Resources.menu_Cadastros;
            this.cadastrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.ToolTipText = "Cadastros";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.marcasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.marcasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.marcasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.modelosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modelosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.modelosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // adicionaisToolStripMenuItem
            // 
            this.adicionaisToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.adicionaisToolStripMenuItem.Name = "adicionaisToolStripMenuItem";
            this.adicionaisToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.adicionaisToolStripMenuItem.Text = "Adicionais";
            this.adicionaisToolStripMenuItem.Click += new System.EventHandler(this.adicionaisToolStripMenuItem_Click);
            // 
            // suvirToolStripMenuItem
            // 
            this.suvirToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.suvirToolStripMenuItem.Name = "suvirToolStripMenuItem";
            this.suvirToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.suvirToolStripMenuItem.Text = "Subir Online";
            this.suvirToolStripMenuItem.Click += new System.EventHandler(this.suvirToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vendedorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            cadastroToolStripMenuItem});
            this.vendedorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vendedorToolStripMenuItem.Image = global::GaragemDesktop.Properties.Resources.menu_Vendedor;
            this.vendedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.ToolTipText = "Vendedor";
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.veículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.veículoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.veículoToolStripMenuItem.Image = global::GaragemDesktop.Properties.Resources.menu_Carros;
            this.veículoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porVendedorToolStripMenuItem,
            this.porPeríodoToolStripMenuItem});
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendasToolStripMenuItem.Image = global::GaragemDesktop.Properties.Resources.menu_Vendas;
            this.vendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.ToolTipText = "Vendas";
            // 
            // porVendedorToolStripMenuItem
            // 
            this.porVendedorToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porVendedorToolStripMenuItem.Name = "porVendedorToolStripMenuItem";
            this.porVendedorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.porVendedorToolStripMenuItem.Text = "Por Vendedor";
            this.porVendedorToolStripMenuItem.Click += new System.EventHandler(this.porVendedorToolStripMenuItem_Click);
            // 
            // porPeríodoToolStripMenuItem
            // 
            this.porPeríodoToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porPeríodoToolStripMenuItem.Name = "porPeríodoToolStripMenuItem";
            this.porPeríodoToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.porPeríodoToolStripMenuItem.Text = "Por Período";
            this.porPeríodoToolStripMenuItem.Click += new System.EventHandler(this.porPeríodoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 15F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1500, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sairToolStripMenuItem.Image = global::GaragemDesktop.Properties.Resources.menu_Sair;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // flowCards
            // 
            this.flowCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.flowCards.Controls.Add(this.pnlCardVeiculos);
            this.flowCards.Controls.Add(this.pnlCardEstoque);
            this.flowCards.Controls.Add(this.pnlCardVendas);
            this.flowCards.Controls.Add(this.pnlCardFaturamento);
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowCards.Location = new System.Drawing.Point(0, 72);
            this.flowCards.Name = "flowCards";
            this.flowCards.Padding = new System.Windows.Forms.Padding(5);
            this.flowCards.Size = new System.Drawing.Size(1500, 127);
            this.flowCards.TabIndex = 1;
            this.flowCards.WrapContents = false;
            // 
            // pnlCardEstoque
            // 
            this.pnlCardEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardEstoque.Controls.Add(this.panel11);
            this.pnlCardEstoque.Controls.Add(this.panel5);
            this.pnlCardEstoque.Controls.Add(this.pictureBox3);
            this.pnlCardEstoque.Controls.Add(this.lblEstoque);
            this.pnlCardEstoque.Controls.Add(this.lblEstoqueAtivo);
            this.pnlCardEstoque.Controls.Add(this.lblEstoqueDisponivel);
            this.pnlCardEstoque.Location = new System.Drawing.Point(341, 15);
            this.pnlCardEstoque.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardEstoque.Name = "pnlCardEstoque";
            this.pnlCardEstoque.Size = new System.Drawing.Size(306, 110);
            this.pnlCardEstoque.TabIndex = 2;
            this.pnlCardEstoque.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardEstoque_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(1, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 4);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Location = new System.Drawing.Point(92, 9);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(101, 20);
            this.lblEstoque.TabIndex = 3;
            this.lblEstoque.Text = "Estoque Ativo";
            // 
            // lblEstoqueAtivo
            // 
            this.lblEstoqueAtivo.AutoSize = true;
            this.lblEstoqueAtivo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblEstoqueAtivo.ForeColor = System.Drawing.Color.White;
            this.lblEstoqueAtivo.Location = new System.Drawing.Point(90, 30);
            this.lblEstoqueAtivo.Name = "lblEstoqueAtivo";
            this.lblEstoqueAtivo.Size = new System.Drawing.Size(38, 46);
            this.lblEstoqueAtivo.TabIndex = 1;
            this.lblEstoqueAtivo.Text = "0";
            this.lblEstoqueAtivo.Click += new System.EventHandler(this.lblEstoqueAtivo_Click);
            // 
            // lblEstoqueDisponivel
            // 
            this.lblEstoqueDisponivel.AutoSize = true;
            this.lblEstoqueDisponivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueDisponivel.ForeColor = System.Drawing.Color.White;
            this.lblEstoqueDisponivel.Location = new System.Drawing.Point(53, 89);
            this.lblEstoqueDisponivel.Name = "lblEstoqueDisponivel";
            this.lblEstoqueDisponivel.Size = new System.Drawing.Size(136, 20);
            this.lblEstoqueDisponivel.TabIndex = 0;
            this.lblEstoqueDisponivel.Text = "Estoque Disponível";
            // 
            // pnlCardVendas
            // 
            this.pnlCardVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardVendas.Controls.Add(this.panel10);
            this.pnlCardVendas.Controls.Add(this.panel2);
            this.pnlCardVendas.Controls.Add(this.pictureBox4);
            this.pnlCardVendas.Controls.Add(this.lblVendas);
            this.pnlCardVendas.Controls.Add(this.lblCarregarVendasRealizadas);
            this.pnlCardVendas.Controls.Add(this.lblVendasRealizadas);
            this.pnlCardVendas.Location = new System.Drawing.Point(667, 15);
            this.pnlCardVendas.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardVendas.Name = "pnlCardVendas";
            this.pnlCardVendas.Size = new System.Drawing.Size(306, 110);
            this.pnlCardVendas.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 4);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Location = new System.Drawing.Point(92, 9);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(56, 20);
            this.lblVendas.TabIndex = 3;
            this.lblVendas.Text = "Vendas";
            // 
            // lblCarregarVendasRealizadas
            // 
            this.lblCarregarVendasRealizadas.AutoSize = true;
            this.lblCarregarVendasRealizadas.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblCarregarVendasRealizadas.ForeColor = System.Drawing.Color.White;
            this.lblCarregarVendasRealizadas.Location = new System.Drawing.Point(90, 30);
            this.lblCarregarVendasRealizadas.Name = "lblCarregarVendasRealizadas";
            this.lblCarregarVendasRealizadas.Size = new System.Drawing.Size(38, 46);
            this.lblCarregarVendasRealizadas.TabIndex = 1;
            this.lblCarregarVendasRealizadas.Text = "0";
            this.lblCarregarVendasRealizadas.Click += new System.EventHandler(this.lblCarregarVendas_Click);
            // 
            // lblVendasRealizadas
            // 
            this.lblVendasRealizadas.AutoSize = true;
            this.lblVendasRealizadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendasRealizadas.ForeColor = System.Drawing.Color.White;
            this.lblVendasRealizadas.Location = new System.Drawing.Point(53, 89);
            this.lblVendasRealizadas.Name = "lblVendasRealizadas";
            this.lblVendasRealizadas.Size = new System.Drawing.Size(131, 20);
            this.lblVendasRealizadas.TabIndex = 0;
            this.lblVendasRealizadas.Text = "Vendas Realizadas";
            // 
            // pnlCardFaturamento
            // 
            this.pnlCardFaturamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardFaturamento.Controls.Add(this.panel12);
            this.pnlCardFaturamento.Controls.Add(this.panel7);
            this.pnlCardFaturamento.Controls.Add(this.pictureBox5);
            this.pnlCardFaturamento.Controls.Add(this.label1);
            this.pnlCardFaturamento.Controls.Add(this.lblFaturamento);
            this.pnlCardFaturamento.Controls.Add(this.lblReceitaFaturada);
            this.pnlCardFaturamento.Location = new System.Drawing.Point(993, 15);
            this.pnlCardFaturamento.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardFaturamento.Name = "pnlCardFaturamento";
            this.pnlCardFaturamento.Size = new System.Drawing.Size(488, 110);
            this.pnlCardFaturamento.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(1, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(465, 4);
            this.panel7.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faturamento";
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblFaturamento.ForeColor = System.Drawing.Color.White;
            this.lblFaturamento.Location = new System.Drawing.Point(101, 28);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(81, 46);
            this.lblFaturamento.TabIndex = 1;
            this.lblFaturamento.Text = "0,00";
            // 
            // lblReceitaFaturada
            // 
            this.lblReceitaFaturada.AutoSize = true;
            this.lblReceitaFaturada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaFaturada.ForeColor = System.Drawing.Color.White;
            this.lblReceitaFaturada.Location = new System.Drawing.Point(176, 89);
            this.lblReceitaFaturada.Name = "lblReceitaFaturada";
            this.lblReceitaFaturada.Size = new System.Drawing.Size(119, 20);
            this.lblReceitaFaturada.TabIndex = 0;
            this.lblReceitaFaturada.Text = "Receita Faturada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 4);
            this.panel1.TabIndex = 2;
            // 
            // grdResultado
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grdResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdResultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(16, 259);
            this.grdResultado.Name = "grdResultado";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.RowTemplate.Height = 24;
            this.grdResultado.Size = new System.Drawing.Size(979, 564);
            this.grdResultado.TabIndex = 3;
            this.grdResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellContentClick);
            // 
            // picIcone
            // 
            this.picIcone.Image = ((System.Drawing.Image)(resources.GetObject("picIcone.Image")));
            this.picIcone.Location = new System.Drawing.Point(1042, 263);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(416, 538);
            this.picIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcone.TabIndex = 5;
            this.picIcone.TabStop = false;
            // 
            // lblGaragemAberta
            // 
            this.lblGaragemAberta.AutoSize = true;
            this.lblGaragemAberta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaragemAberta.ForeColor = System.Drawing.Color.White;
            this.lblGaragemAberta.Location = new System.Drawing.Point(1189, 217);
            this.lblGaragemAberta.Name = "lblGaragemAberta";
            this.lblGaragemAberta.Size = new System.Drawing.Size(156, 28);
            this.lblGaragemAberta.TabIndex = 6;
            this.lblGaragemAberta.Text = "Garagem Aberta";
            this.lblGaragemAberta.Click += new System.EventHandler(this.lblGaragemAberta_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1146, 218);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // lblVeiculosCadastrados
            // 
            this.lblVeiculosCadastrados.AutoSize = true;
            this.lblVeiculosCadastrados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblVeiculosCadastrados.Location = new System.Drawing.Point(13, 217);
            this.lblVeiculosCadastrados.Name = "lblVeiculosCadastrados";
            this.lblVeiculosCadastrados.Size = new System.Drawing.Size(200, 28);
            this.lblVeiculosCadastrados.TabIndex = 5;
            this.lblVeiculosCadastrados.Text = "Veículos Cadastrados:";
            // 
            // lblVeiculosNoPatio
            // 
            this.lblVeiculosNoPatio.AutoSize = true;
            this.lblVeiculosNoPatio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosNoPatio.ForeColor = System.Drawing.Color.White;
            this.lblVeiculosNoPatio.Location = new System.Drawing.Point(53, 89);
            this.lblVeiculosNoPatio.Name = "lblVeiculosNoPatio";
            this.lblVeiculosNoPatio.Size = new System.Drawing.Size(124, 20);
            this.lblVeiculosNoPatio.TabIndex = 0;
            this.lblVeiculosNoPatio.Text = "Veiculos No Pátio";
            // 
            // lblTotalVeiculos
            // 
            this.lblTotalVeiculos.AutoSize = true;
            this.lblTotalVeiculos.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTotalVeiculos.ForeColor = System.Drawing.Color.White;
            this.lblTotalVeiculos.Location = new System.Drawing.Point(90, 30);
            this.lblTotalVeiculos.Name = "lblTotalVeiculos";
            this.lblTotalVeiculos.Size = new System.Drawing.Size(38, 46);
            this.lblTotalVeiculos.TabIndex = 1;
            this.lblTotalVeiculos.Text = "0";
            this.lblTotalVeiculos.Click += new System.EventHandler(this.lblTotalVeiculos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veiculos no";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCardVeiculos
            // 
            this.pnlCardVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardVeiculos.Controls.Add(this.panel4);
            this.pnlCardVeiculos.Controls.Add(this.pictureBox1);
            this.pnlCardVeiculos.Controls.Add(this.label2);
            this.pnlCardVeiculos.Controls.Add(this.lblTotalVeiculos);
            this.pnlCardVeiculos.Controls.Add(this.lblVeiculosNoPatio);
            this.pnlCardVeiculos.Location = new System.Drawing.Point(15, 15);
            this.pnlCardVeiculos.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardVeiculos.Name = "pnlCardVeiculos";
            this.pnlCardVeiculos.Size = new System.Drawing.Size(306, 110);
            this.pnlCardVeiculos.TabIndex = 0;
            this.pnlCardVeiculos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardVeiculos_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel3.Location = new System.Drawing.Point(21, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 4);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(77, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 4);
            this.panel4.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel6.Location = new System.Drawing.Point(21, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 4);
            this.panel6.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(76, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 4);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel9.Location = new System.Drawing.Point(21, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(229, 4);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel10.Location = new System.Drawing.Point(77, 81);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(229, 4);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel11.Location = new System.Drawing.Point(76, 81);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(229, 4);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel12.Location = new System.Drawing.Point(49, 81);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(465, 4);
            this.panel12.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1500, 835);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblGaragemAberta);
            this.Controls.Add(this.lblVeiculosCadastrados);
            this.Controls.Add(this.picIcone);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowCards);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowCards.ResumeLayout(false);
            this.pnlCardEstoque.ResumeLayout(false);
            this.pnlCardEstoque.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlCardVendas.ResumeLayout(false);
            this.pnlCardVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlCardFaturamento.ResumeLayout(false);
            this.pnlCardFaturamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCardVeiculos.ResumeLayout(false);
            this.pnlCardVeiculos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeríodoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCardEstoque;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblEstoqueAtivo;
        private System.Windows.Forms.Label lblEstoqueDisponivel;
        private System.Windows.Forms.Panel pnlCardVendas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblCarregarVendasRealizadas;
        private System.Windows.Forms.Label lblVendasRealizadas;
        private System.Windows.Forms.Panel pnlCardFaturamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.Label lblReceitaFaturada;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblGaragemAberta;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblVeiculosCadastrados;
        private System.Windows.Forms.ToolStripMenuItem adicionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suvirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCardVeiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalVeiculos;
        private System.Windows.Forms.Label lblVeiculosNoPatio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
    }
}