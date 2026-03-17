namespace GaragemDesktop
{
    partial class frmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedor));
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.lblGerenciarVendedor = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblFiltrarPeloNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFiltro = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.ForeColor = System.Drawing.Color.White;
            this.lblAtivo.Location = new System.Drawing.Point(1084, 282);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 21);
            this.lblAtivo.TabIndex = 1071;
            this.lblAtivo.Text = "ATIVO";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(394, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 28);
            this.lblEmail.TabIndex = 1067;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // grdResultado
            // 
            this.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(418, 508);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.RowTemplate.Height = 24;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(1033, 274);
            this.grdResultado.TabIndex = 1066;
            this.grdResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellClick);
            // 
            // lblGerenciarVendedor
            // 
            this.lblGerenciarVendedor.AutoSize = true;
            this.lblGerenciarVendedor.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciarVendedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGerenciarVendedor.Location = new System.Drawing.Point(578, 9);
            this.lblGerenciarVendedor.Name = "lblGerenciarVendedor";
            this.lblGerenciarVendedor.Size = new System.Drawing.Size(393, 53);
            this.lblGerenciarVendedor.TabIndex = 1053;
            this.lblGerenciarVendedor.Text = "GERENCIAR VENDEDOR";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVendedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeVendedor.Location = new System.Drawing.Point(269, 99);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(197, 28);
            this.lblNomeVendedor.TabIndex = 1067;
            this.lblNomeVendedor.Text = "NOME DO VENDEDOR:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefone.Location = new System.Drawing.Point(816, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(101, 28);
            this.lblTelefone.TabIndex = 1067;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPF.Location = new System.Drawing.Point(860, 164);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(51, 28);
            this.lblCPF.TabIndex = 1067;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndereco.Location = new System.Drawing.Point(361, 231);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(110, 28);
            this.lblEndereco.TabIndex = 1067;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblFiltrarPeloNome
            // 
            this.lblFiltrarPeloNome.AutoSize = true;
            this.lblFiltrarPeloNome.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPeloNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltrarPeloNome.Location = new System.Drawing.Point(361, 444);
            this.lblFiltrarPeloNome.Name = "lblFiltrarPeloNome";
            this.lblFiltrarPeloNome.Size = new System.Drawing.Size(190, 28);
            this.lblFiltrarPeloNome.TabIndex = 1074;
            this.lblFiltrarPeloNome.Text = "FILTRAR PELO NOME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1075;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1072;
            this.pictureBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(763, 364);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 47);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(516, 364);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(180, 47);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(269, 364);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 47);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1001, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Maroon;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(484, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 36);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Maroon;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(484, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 36);
            this.txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Maroon;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(484, 228);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(679, 36);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.Maroon;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCpf.ForeColor = System.Drawing.Color.White;
            this.txtCpf.Location = new System.Drawing.Point(936, 156);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(227, 36);
            this.txtCpf.TabIndex = 4;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Maroon;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.Location = new System.Drawing.Point(936, 91);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(227, 36);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeFiltro
            // 
            this.txtNomeFiltro.BackColor = System.Drawing.Color.Maroon;
            this.txtNomeFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFiltro.ForeColor = System.Drawing.Color.White;
            this.txtNomeFiltro.Location = new System.Drawing.Point(587, 440);
            this.txtNomeFiltro.Name = "txtNomeFiltro";
            this.txtNomeFiltro.Size = new System.Drawing.Size(576, 36);
            this.txtNomeFiltro.TabIndex = 10;
            this.txtNomeFiltro.TextChanged += new System.EventHandler(this.txtNomeFiltro_TextChanged);
            // 
            // txtComissao
            // 
            this.txtComissao.BackColor = System.Drawing.Color.Maroon;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.ForeColor = System.Drawing.Color.White;
            this.txtComissao.Location = new System.Drawing.Point(484, 293);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(326, 36);
            this.txtComissao.TabIndex = 1123;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComissao.Location = new System.Drawing.Point(363, 297);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(115, 28);
            this.lblComissao.TabIndex = 1124;
            this.lblComissao.Text = "COMISSÃO:";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Location = new System.Drawing.Point(1145, 284);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(18, 17);
            this.chkStatus.TabIndex = 1126;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1443, 782);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtNomeFiltro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFiltrarPeloNome);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.lblGerenciarVendedor);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label lblGerenciarVendedor;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFiltrarPeloNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNomeFiltro;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.CheckBox chkStatus;
    }
}