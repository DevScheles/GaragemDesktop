namespace GaragemDesktop
{
    partial class frmSubirOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubirOnline));
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.lblTelasParaGravar = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbSelecioneTela = new System.Windows.Forms.ComboBox();
            this.lblSelecioneTela = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cleanRoundTextBox1 = new GaragemDesktop.CleanRoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResultado
            // 
            this.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(192, 406);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.RowTemplate.Height = 24;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(1012, 317);
            this.grdResultado.TabIndex = 1044;
            this.grdResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellClick);
            // 
            // lblTelasParaGravar
            // 
            this.lblTelasParaGravar.AutoSize = true;
            this.lblTelasParaGravar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelasParaGravar.ForeColor = System.Drawing.Color.White;
            this.lblTelasParaGravar.Location = new System.Drawing.Point(612, 355);
            this.lblTelasParaGravar.Name = "lblTelasParaGravar";
            this.lblTelasParaGravar.Size = new System.Drawing.Size(241, 38);
            this.lblTelasParaGravar.TabIndex = 1033;
            this.lblTelasParaGravar.Text = "Telas Para Gravar:";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBemVindo.Location = new System.Drawing.Point(587, 19);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(265, 53);
            this.lblBemVindo.TabIndex = 1031;
            this.lblBemVindo.Text = "GRAVE OFFLINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(496, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 35);
            this.label1.TabIndex = 1032;
            this.label1.Text = "GERENCIE SEUS ARQUIVOS COM RAPIDEZ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-6, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1030;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(528, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1034;
            this.pictureBox3.TabStop = false;
            // 
            // cbSelecioneTela
            // 
            this.cbSelecioneTela.BackColor = System.Drawing.Color.Maroon;
            this.cbSelecioneTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSelecioneTela.FormattingEnabled = true;
            this.cbSelecioneTela.Location = new System.Drawing.Point(687, 162);
            this.cbSelecioneTela.Name = "cbSelecioneTela";
            this.cbSelecioneTela.Size = new System.Drawing.Size(227, 37);
            this.cbSelecioneTela.TabIndex = 1101;
            // 
            // lblSelecioneTela
            // 
            this.lblSelecioneTela.AutoSize = true;
            this.lblSelecioneTela.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneTela.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneTela.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecioneTela.Location = new System.Drawing.Point(472, 166);
            this.lblSelecioneTela.Name = "lblSelecioneTela";
            this.lblSelecioneTela.Size = new System.Drawing.Size(176, 28);
            this.lblSelecioneTela.TabIndex = 1103;
            this.lblSelecioneTela.Text = "SELECIONE A TELA:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(630, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1119;
            this.pictureBox5.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(630, 260);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 47);
            this.btnAdicionar.TabIndex = 1123;
            this.btnAdicionar.Text = "Subir";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cleanRoundTextBox1
            // 
            this.cleanRoundTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.cleanRoundTextBox1.BackgroundColor = System.Drawing.Color.Maroon;
            this.cleanRoundTextBox1.BorderColor = System.Drawing.Color.Black;
            this.cleanRoundTextBox1.BorderRadius = 20;
            this.cleanRoundTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F);
            this.cleanRoundTextBox1.Location = new System.Drawing.Point(687, 156);
            this.cleanRoundTextBox1.Name = "cleanRoundTextBox1";
            this.cleanRoundTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.cleanRoundTextBox1.Size = new System.Drawing.Size(260, 45);
            this.cleanRoundTextBox1.TabIndex = 1102;
            this.cleanRoundTextBox1.TextColor = System.Drawing.Color.White;
            // 
            // frmSubirOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1337, 754);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbSelecioneTela);
            this.Controls.Add(this.lblSelecioneTela);
            this.Controls.Add(this.cleanRoundTextBox1);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.lblTelasParaGravar);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmSubirOnline";
            this.Text = "frmSubirOnline";
            this.Load += new System.EventHandler(this.frmSubirOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label lblTelasParaGravar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbSelecioneTela;
        private System.Windows.Forms.Label lblSelecioneTela;
        private CleanRoundTextBox cleanRoundTextBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAdicionar;
    }
}