namespace MOAgrossStok
{
    partial class satisEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisEkran));
            this.kasiyerAS = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kasiyerAdSoyad = new System.Windows.Forms.ComboBox();
            this.barkod = new System.Windows.Forms.TextBox();
            this.urunMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunEkle = new System.Windows.Forms.Button();
            this.urunSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urunFiyat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.satisDG = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDG)).BeginInit();
            this.SuspendLayout();
            // 
            // kasiyerAS
            // 
            this.kasiyerAS.AutoSize = true;
            this.kasiyerAS.Location = new System.Drawing.Point(12, 36);
            this.kasiyerAS.Name = "kasiyerAS";
            this.kasiyerAS.Size = new System.Drawing.Size(94, 13);
            this.kasiyerAS.TabIndex = 5;
            this.kasiyerAS.Text = "Kasiyer Adı Soyadı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.stokYönetimiToolStripMenuItem,
            this.ciroRaporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources._50x50satis;
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources._50x50;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ürünlerToolStripMenuItem.Text = "Stok Yönetimi";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // stokYönetimiToolStripMenuItem
            // 
            this.stokYönetimiToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources.urunicon;
            this.stokYönetimiToolStripMenuItem.Name = "stokYönetimiToolStripMenuItem";
            this.stokYönetimiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.stokYönetimiToolStripMenuItem.Text = "Ürünler";
            this.stokYönetimiToolStripMenuItem.Click += new System.EventHandler(this.stokYönetimiToolStripMenuItem_Click);
            // 
            // ciroRaporlamaToolStripMenuItem
            // 
            this.ciroRaporlamaToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources.unnamed;
            this.ciroRaporlamaToolStripMenuItem.Name = "ciroRaporlamaToolStripMenuItem";
            this.ciroRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ciroRaporlamaToolStripMenuItem.Text = "Ciro Raporlama";
            this.ciroRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.ciroRaporlamaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Barkod";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // kasiyerAdSoyad
            // 
            this.kasiyerAdSoyad.FormattingEnabled = true;
            this.kasiyerAdSoyad.Location = new System.Drawing.Point(15, 52);
            this.kasiyerAdSoyad.Name = "kasiyerAdSoyad";
            this.kasiyerAdSoyad.Size = new System.Drawing.Size(121, 21);
            this.kasiyerAdSoyad.TabIndex = 10;
            this.kasiyerAdSoyad.SelectedIndexChanged += new System.EventHandler(this.kasiyerAdSoyad_SelectedIndexChanged);
            // 
            // barkod
            // 
            this.barkod.Location = new System.Drawing.Point(15, 103);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(121, 20);
            this.barkod.TabIndex = 11;
            this.barkod.TextChanged += new System.EventHandler(this.barkod_TextChanged);
            this.barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barkod_KeyPress);
            // 
            // urunMiktar
            // 
            this.urunMiktar.Location = new System.Drawing.Point(156, 103);
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.Size = new System.Drawing.Size(100, 20);
            this.urunMiktar.TabIndex = 12;
            this.urunMiktar.TextChanged += new System.EventHandler(this.urunMiktar_TextChanged);
            this.urunMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Miktar";
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(280, 101);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(75, 23);
            this.urunEkle.TabIndex = 14;
            this.urunEkle.Text = "Ürün Ekle";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(361, 101);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(125, 23);
            this.urunSil.TabIndex = 15;
            this.urunSil.Text = "Seçili Ürünü Çıkart";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.urunFiyat);
            this.panel1.Location = new System.Drawing.Point(488, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 64);
            this.panel1.TabIndex = 19;
            // 
            // urunFiyat
            // 
            this.urunFiyat.AutoSize = true;
            this.urunFiyat.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunFiyat.Location = new System.Drawing.Point(12, 8);
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Size = new System.Drawing.Size(108, 49);
            this.urunFiyat.TabIndex = 0;
            this.urunFiyat.Text = "0 TL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Satış İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Satış Tamamla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // satisDG
            // 
            this.satisDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.satisDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.satisDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisDG.Location = new System.Drawing.Point(15, 130);
            this.satisDG.Name = "satisDG";
            this.satisDG.ReadOnly = true;
            this.satisDG.Size = new System.Drawing.Size(731, 369);
            this.satisDG.TabIndex = 22;
            this.satisDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.satisDG_CellClick);
            // 
            // satisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 579);
            this.Controls.Add(this.satisDG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urunSil);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urunMiktar);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.kasiyerAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasiyerAS);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "satisEkran";
            this.Text = "Satış Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.satisEkran_FormClosed);
            this.Load += new System.EventHandler(this.satisEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kasiyerAS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroRaporlamaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox kasiyerAdSoyad;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.TextBox urunMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.Button urunSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label urunFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView satisDG;
    }
}