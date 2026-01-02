namespace GaragemDesktop
{
    partial class frmPesquisarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVeiculo));
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelecioneModelo = new System.Windows.Forms.ComboBox();
            this.cbSelecioneMarca = new System.Windows.Forms.ComboBox();
            this.lblSelecioneModelo = new System.Windows.Forms.Label();
            this.lblSelecioneMarca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResultado
            // 
            this.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(237, 344);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.RowTemplate.Height = 24;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(1030, 389);
            this.grdResultado.TabIndex = 1045;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBemVindo.Location = new System.Drawing.Point(587, 24);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(406, 53);
            this.lblBemVindo.TabIndex = 1031;
            this.lblBemVindo.Text = "PESQUISA DE VEÍCULOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(567, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 35);
            this.label1.TabIndex = 1032;
            this.label1.Text = "GERENCIE SUAS MARCAS COM RAPIDEZ";
            // 
            // cbSelecioneModelo
            // 
            this.cbSelecioneModelo.BackColor = System.Drawing.Color.Maroon;
            this.cbSelecioneModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSelecioneModelo.FormattingEnabled = true;
            this.cbSelecioneModelo.Location = new System.Drawing.Point(1016, 165);
            this.cbSelecioneModelo.Name = "cbSelecioneModelo";
            this.cbSelecioneModelo.Size = new System.Drawing.Size(227, 37);
            this.cbSelecioneModelo.TabIndex = 1095;
            // 
            // cbSelecioneMarca
            // 
            this.cbSelecioneMarca.BackColor = System.Drawing.Color.Maroon;
            this.cbSelecioneMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSelecioneMarca.FormattingEnabled = true;
            this.cbSelecioneMarca.Location = new System.Drawing.Point(519, 166);
            this.cbSelecioneMarca.Name = "cbSelecioneMarca";
            this.cbSelecioneMarca.Size = new System.Drawing.Size(227, 37);
            this.cbSelecioneMarca.TabIndex = 1096;
            // 
            // lblSelecioneModelo
            // 
            this.lblSelecioneModelo.AutoSize = true;
            this.lblSelecioneModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneModelo.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecioneModelo.Location = new System.Drawing.Point(779, 171);
            this.lblSelecioneModelo.Name = "lblSelecioneModelo";
            this.lblSelecioneModelo.Size = new System.Drawing.Size(208, 28);
            this.lblSelecioneModelo.TabIndex = 1099;
            this.lblSelecioneModelo.Text = "SELECIONE O MODELO:";
            // 
            // lblSelecioneMarca
            // 
            this.lblSelecioneMarca.AutoSize = true;
            this.lblSelecioneMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneMarca.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecioneMarca.Location = new System.Drawing.Point(287, 171);
            this.lblSelecioneMarca.Name = "lblSelecioneMarca";
            this.lblSelecioneMarca.Size = new System.Drawing.Size(198, 28);
            this.lblSelecioneMarca.TabIndex = 1100;
            this.lblSelecioneMarca.Text = "SELECIONE A MARCA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(256, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 28);
            this.label5.TabIndex = 1100;
            this.label5.Text = "VEICULOS ENCONTRADOS:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1030;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(685, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1122;
            this.pictureBox3.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(684, 250);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 45);
            this.btnPesquisar.TabIndex = 1123;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPesquisarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1419, 807);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbSelecioneModelo);
            this.Controls.Add(this.cbSelecioneMarca);
            this.Controls.Add(this.lblSelecioneModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSelecioneMarca);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmPesquisarVeiculo";
            this.Text = "frmPesquisarVeiculo";
            this.Load += new System.EventHandler(this.frmPesquisarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbSelecioneModelo;
        private System.Windows.Forms.ComboBox cbSelecioneMarca;
        private System.Windows.Forms.Label lblSelecioneModelo;
        private System.Windows.Forms.Label lblSelecioneMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPesquisar;
    }
}