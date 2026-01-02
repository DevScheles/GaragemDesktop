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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardVeiculos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalVeiculos = new System.Windows.Forms.Label();
            this.lblVeiculosNoPatio = new System.Windows.Forms.Label();
            this.pnlCardVagas = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVagas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVagasDisponiveis = new System.Windows.Forms.Label();
            this.pnlCardEstoque = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstoqueAtivo = new System.Windows.Forms.Label();
            this.pnlCardVendas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVendasRealizadas = new System.Windows.Forms.Label();
            this.pnlCardFaturamento = new System.Windows.Forms.Panel();
            this.lblCifrao = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReceitaFaturada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdVeiculosCadastrados = new System.Windows.Forms.DataGridView();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblGaragemAberta = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblVeiculosCadastrados = new System.Windows.Forms.Label();
            this.adicionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowCards.SuspendLayout();
            this.pnlCardVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCardVagas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCardEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlCardVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlCardFaturamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculosCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            this.adicionaisToolStripMenuItem});
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
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
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
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
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
            this.flowCards.Controls.Add(this.pnlCardVagas);
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
            // pnlCardVeiculos
            // 
            this.pnlCardVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardVeiculos.Controls.Add(this.pictureBox1);
            this.pnlCardVeiculos.Controls.Add(this.label2);
            this.pnlCardVeiculos.Controls.Add(this.lblTotalVeiculos);
            this.pnlCardVeiculos.Controls.Add(this.lblVeiculosNoPatio);
            this.pnlCardVeiculos.Location = new System.Drawing.Point(15, 15);
            this.pnlCardVeiculos.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardVeiculos.Name = "pnlCardVeiculos";
            this.pnlCardVeiculos.Size = new System.Drawing.Size(230, 110);
            this.pnlCardVeiculos.TabIndex = 0;
            this.pnlCardVeiculos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardVeiculos_Paint);
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
            // pnlCardVagas
            // 
            this.pnlCardVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardVagas.Controls.Add(this.panel4);
            this.pnlCardVagas.Controls.Add(this.pictureBox2);
            this.pnlCardVagas.Controls.Add(this.lblVagas);
            this.pnlCardVagas.Controls.Add(this.label3);
            this.pnlCardVagas.Controls.Add(this.lblVagasDisponiveis);
            this.pnlCardVagas.Location = new System.Drawing.Point(265, 15);
            this.pnlCardVagas.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardVagas.Name = "pnlCardVagas";
            this.pnlCardVagas.Size = new System.Drawing.Size(230, 110);
            this.pnlCardVagas.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel4.Location = new System.Drawing.Point(1, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 4);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.ForeColor = System.Drawing.Color.White;
            this.lblVagas.Location = new System.Drawing.Point(92, 9);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(48, 20);
            this.lblVagas.TabIndex = 3;
            this.lblVagas.Text = "Vagas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            // 
            // lblVagasDisponiveis
            // 
            this.lblVagasDisponiveis.AutoSize = true;
            this.lblVagasDisponiveis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagasDisponiveis.ForeColor = System.Drawing.Color.White;
            this.lblVagasDisponiveis.Location = new System.Drawing.Point(53, 89);
            this.lblVagasDisponiveis.Name = "lblVagasDisponiveis";
            this.lblVagasDisponiveis.Size = new System.Drawing.Size(128, 20);
            this.lblVagasDisponiveis.TabIndex = 0;
            this.lblVagasDisponiveis.Text = "Vagas Disponiveis";
            // 
            // pnlCardEstoque
            // 
            this.pnlCardEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardEstoque.Controls.Add(this.panel5);
            this.pnlCardEstoque.Controls.Add(this.pictureBox3);
            this.pnlCardEstoque.Controls.Add(this.lblEstoque);
            this.pnlCardEstoque.Controls.Add(this.label6);
            this.pnlCardEstoque.Controls.Add(this.lblEstoqueAtivo);
            this.pnlCardEstoque.Location = new System.Drawing.Point(515, 15);
            this.pnlCardEstoque.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardEstoque.Name = "pnlCardEstoque";
            this.pnlCardEstoque.Size = new System.Drawing.Size(230, 110);
            this.pnlCardEstoque.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "0";
            // 
            // lblEstoqueAtivo
            // 
            this.lblEstoqueAtivo.AutoSize = true;
            this.lblEstoqueAtivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueAtivo.ForeColor = System.Drawing.Color.White;
            this.lblEstoqueAtivo.Location = new System.Drawing.Point(53, 89);
            this.lblEstoqueAtivo.Name = "lblEstoqueAtivo";
            this.lblEstoqueAtivo.Size = new System.Drawing.Size(136, 20);
            this.lblEstoqueAtivo.TabIndex = 0;
            this.lblEstoqueAtivo.Text = "Estoque Disponível";
            // 
            // pnlCardVendas
            // 
            this.pnlCardVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCardVendas.Controls.Add(this.panel2);
            this.pnlCardVendas.Controls.Add(this.pictureBox4);
            this.pnlCardVendas.Controls.Add(this.lblVendas);
            this.pnlCardVendas.Controls.Add(this.label4);
            this.pnlCardVendas.Controls.Add(this.lblVendasRealizadas);
            this.pnlCardVendas.Location = new System.Drawing.Point(765, 15);
            this.pnlCardVendas.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardVendas.Name = "pnlCardVendas";
            this.pnlCardVendas.Size = new System.Drawing.Size(230, 110);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "0";
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
            this.pnlCardFaturamento.Controls.Add(this.lblCifrao);
            this.pnlCardFaturamento.Controls.Add(this.panel7);
            this.pnlCardFaturamento.Controls.Add(this.pictureBox5);
            this.pnlCardFaturamento.Controls.Add(this.label1);
            this.pnlCardFaturamento.Controls.Add(this.label5);
            this.pnlCardFaturamento.Controls.Add(this.lblReceitaFaturada);
            this.pnlCardFaturamento.Location = new System.Drawing.Point(1015, 15);
            this.pnlCardFaturamento.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCardFaturamento.Name = "pnlCardFaturamento";
            this.pnlCardFaturamento.Size = new System.Drawing.Size(466, 110);
            this.pnlCardFaturamento.TabIndex = 4;
            // 
            // lblCifrao
            // 
            this.lblCifrao.AutoSize = true;
            this.lblCifrao.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblCifrao.ForeColor = System.Drawing.Color.White;
            this.lblCifrao.Location = new System.Drawing.Point(89, 30);
            this.lblCifrao.Name = "lblCifrao";
            this.lblCifrao.Size = new System.Drawing.Size(58, 46);
            this.lblCifrao.TabIndex = 7;
            this.lblCifrao.Text = "R$";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "0,00";
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
            this.panel1.Location = new System.Drawing.Point(16, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 4);
            this.panel1.TabIndex = 2;
            // 
            // grdVeiculosCadastrados
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdVeiculosCadastrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVeiculosCadastrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdVeiculosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVeiculosCadastrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdVeiculosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVeiculosCadastrados.Location = new System.Drawing.Point(16, 259);
            this.grdVeiculosCadastrados.Name = "grdVeiculosCadastrados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVeiculosCadastrados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVeiculosCadastrados.RowHeadersWidth = 51;
            this.grdVeiculosCadastrados.RowTemplate.Height = 24;
            this.grdVeiculosCadastrados.Size = new System.Drawing.Size(979, 564);
            this.grdVeiculosCadastrados.TabIndex = 3;
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
            // adicionaisToolStripMenuItem
            // 
            this.adicionaisToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.adicionaisToolStripMenuItem.Name = "adicionaisToolStripMenuItem";
            this.adicionaisToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.adicionaisToolStripMenuItem.Text = "Adicionais";
            this.adicionaisToolStripMenuItem.Click += new System.EventHandler(this.adicionaisToolStripMenuItem_Click);
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
            this.Controls.Add(this.grdVeiculosCadastrados);
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
            this.pnlCardVeiculos.ResumeLayout(false);
            this.pnlCardVeiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCardVagas.ResumeLayout(false);
            this.pnlCardVagas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCardEstoque.ResumeLayout(false);
            this.pnlCardEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlCardVendas.ResumeLayout(false);
            this.pnlCardVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlCardFaturamento.ResumeLayout(false);
            this.pnlCardFaturamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculosCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.Panel pnlCardVeiculos;
        private System.Windows.Forms.Label lblVeiculosNoPatio;
        private System.Windows.Forms.Label lblTotalVeiculos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCardVagas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVagasDisponiveis;
        private System.Windows.Forms.Panel pnlCardEstoque;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstoqueAtivo;
        private System.Windows.Forms.Panel pnlCardVendas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendasRealizadas;
        private System.Windows.Forms.Panel pnlCardFaturamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReceitaFaturada;
        private System.Windows.Forms.DataGridView grdVeiculosCadastrados;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblGaragemAberta;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblVeiculosCadastrados;
        private System.Windows.Forms.Label lblCifrao;
        private System.Windows.Forms.ToolStripMenuItem adicionaisToolStripMenuItem;
    }
}