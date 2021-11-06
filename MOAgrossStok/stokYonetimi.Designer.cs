namespace MOAgrossStok
{
    partial class stokYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokYonetimi));
            this.label1 = new System.Windows.Forms.Label();
            this.aramaText = new System.Windows.Forms.TextBox();
            this.barkodText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriCombo = new System.Windows.Forms.ComboBox();
            this.isimUrun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.miktarText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyatText = new System.Windows.Forms.TextBox();
            this.urunBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uyariLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTakibiDataSet = new MOAgrossStok.stokTakibiDataSet();
            this.stokTakibiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new MOAgrossStok.stokTakibiDataSetTableAdapters.UrunlerTableAdapter();
            this.urunlerDG = new System.Windows.Forms.DataGridView();
            this.yenile = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.yeniUrunlbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.stokUyarı = new System.Windows.Forms.Label();
            this.urunSayisi = new System.Windows.Forms.Label();
            this.stokSayisi = new System.Windows.Forms.Label();
            this.kopyalaBtn = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakibiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakibiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama : ";
            // 
            // aramaText
            // 
            this.aramaText.Location = new System.Drawing.Point(67, 55);
            this.aramaText.Name = "aramaText";
            this.aramaText.Size = new System.Drawing.Size(282, 20);
            this.aramaText.TabIndex = 1;
            this.aramaText.TextChanged += new System.EventHandler(this.aramaText_TextChanged);
            // 
            // barkodText
            // 
            this.barkodText.Enabled = false;
            this.barkodText.Location = new System.Drawing.Point(576, 92);
            this.barkodText.Name = "barkodText";
            this.barkodText.Size = new System.Drawing.Size(184, 20);
            this.barkodText.TabIndex = 3;
            this.barkodText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barkodText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategorisi";
            // 
            // kategoriCombo
            // 
            this.kategoriCombo.FormattingEnabled = true;
            this.kategoriCombo.Location = new System.Drawing.Point(576, 131);
            this.kategoriCombo.Name = "kategoriCombo";
            this.kategoriCombo.Size = new System.Drawing.Size(251, 21);
            this.kategoriCombo.TabIndex = 6;
            this.kategoriCombo.SelectedIndexChanged += new System.EventHandler(this.kategoriCombo_SelectedIndexChanged);
            // 
            // isimUrun
            // 
            this.isimUrun.Location = new System.Drawing.Point(576, 178);
            this.isimUrun.Name = "isimUrun";
            this.isimUrun.Size = new System.Drawing.Size(251, 20);
            this.isimUrun.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "İsmi";
            // 
            // miktarText
            // 
            this.miktarText.Location = new System.Drawing.Point(576, 224);
            this.miktarText.Name = "miktarText";
            this.miktarText.Size = new System.Drawing.Size(93, 20);
            this.miktarText.TabIndex = 10;
            this.miktarText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktarText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktarı";
            // 
            // fiyatText
            // 
            this.fiyatText.Location = new System.Drawing.Point(675, 224);
            this.fiyatText.Name = "fiyatText";
            this.fiyatText.Size = new System.Drawing.Size(85, 20);
            this.fiyatText.TabIndex = 12;
            this.fiyatText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyatText_KeyPress);
            // 
            // urunBtn
            // 
            this.urunBtn.Location = new System.Drawing.Point(576, 250);
            this.urunBtn.Name = "urunBtn";
            this.urunBtn.Size = new System.Drawing.Size(62, 23);
            this.urunBtn.TabIndex = 15;
            this.urunBtn.Text = "Ürün Ekle";
            this.urunBtn.UseVisualStyleBackColor = true;
            this.urunBtn.Click += new System.EventHandler(this.urunBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(640, 250);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(86, 23);
            this.silBtn.TabIndex = 16;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(732, 250);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(95, 23);
            this.kaydetBtn.TabIndex = 17;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birim Fiyat";
            // 
            // uyariLabel
            // 
            this.uyariLabel.AutoSize = true;
            this.uyariLabel.Location = new System.Drawing.Point(576, 285);
            this.uyariLabel.Name = "uyariLabel";
            this.uyariLabel.Size = new System.Drawing.Size(35, 13);
            this.uyariLabel.TabIndex = 19;
            this.uyariLabel.Text = "label8";
            this.uyariLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources._50x50satis;
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
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
            this.stokYönetimiToolStripMenuItem.Click += new System.EventHandler(this.stokYönetimiToolStripMenuItem_Click_1);
            // 
            // ciroRaporlamaToolStripMenuItem
            // 
            this.ciroRaporlamaToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources.unnamed;
            this.ciroRaporlamaToolStripMenuItem.Name = "ciroRaporlamaToolStripMenuItem";
            this.ciroRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ciroRaporlamaToolStripMenuItem.Text = "Ciro Raporlama";
            this.ciroRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.ciroRaporlamaToolStripMenuItem_Click);
            // 
            // stokTakibiDataSet
            // 
            this.stokTakibiDataSet.DataSetName = "stokTakibiDataSet";
            this.stokTakibiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokTakibiDataSetBindingSource
            // 
            this.stokTakibiDataSetBindingSource.DataSource = this.stokTakibiDataSet;
            this.stokTakibiDataSetBindingSource.Position = 0;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.stokTakibiDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // urunlerDG
            // 
            this.urunlerDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.urunlerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDG.Location = new System.Drawing.Point(67, 86);
            this.urunlerDG.Name = "urunlerDG";
            this.urunlerDG.ReadOnly = true;
            this.urunlerDG.Size = new System.Drawing.Size(500, 486);
            this.urunlerDG.TabIndex = 26;
            this.urunlerDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDG_CellClick);
            this.urunlerDG.SelectionChanged += new System.EventHandler(this.urunlerDG_SelectionChanged);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(743, 64);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(52, 23);
            this.yenile.TabIndex = 27;
            this.yenile.Text = "Temizle";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(675, 64);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(62, 23);
            this.guncelleBtn.TabIndex = 28;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // yeniUrunlbl
            // 
            this.yeniUrunlbl.AutoSize = true;
            this.yeniUrunlbl.Location = new System.Drawing.Point(573, 42);
            this.yeniUrunlbl.Name = "yeniUrunlbl";
            this.yeniUrunlbl.Size = new System.Drawing.Size(35, 13);
            this.yeniUrunlbl.TabIndex = 29;
            this.yeniUrunlbl.Text = "label8";
            this.yeniUrunlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(576, 347);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 95);
            this.listBox1.TabIndex = 31;
            // 
            // stokUyarı
            // 
            this.stokUyarı.AutoSize = true;
            this.stokUyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokUyarı.Location = new System.Drawing.Point(573, 321);
            this.stokUyarı.Name = "stokUyarı";
            this.stokUyarı.Size = new System.Drawing.Size(251, 17);
            this.stokUyarı.TabIndex = 32;
            this.stokUyarı.Text = "STOKTA BİTMİŞ OLAN ÜRÜNLER";
            // 
            // urunSayisi
            // 
            this.urunSayisi.AutoSize = true;
            this.urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSayisi.Location = new System.Drawing.Point(355, 58);
            this.urunSayisi.Name = "urunSayisi";
            this.urunSayisi.Size = new System.Drawing.Size(128, 13);
            this.urunSayisi.TabIndex = 33;
            this.urunSayisi.Text = "Toplam Ürün Sayısı : ";
            // 
            // stokSayisi
            // 
            this.stokSayisi.AutoSize = true;
            this.stokSayisi.Location = new System.Drawing.Point(573, 447);
            this.stokSayisi.Name = "stokSayisi";
            this.stokSayisi.Size = new System.Drawing.Size(31, 13);
            this.stokSayisi.TabIndex = 35;
            this.stokSayisi.Text = "Uyari";
            // 
            // kopyalaBtn
            // 
            this.kopyalaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kopyalaBtn.Location = new System.Drawing.Point(766, 92);
            this.kopyalaBtn.Name = "kopyalaBtn";
            this.kopyalaBtn.Size = new System.Drawing.Size(61, 21);
            this.kopyalaBtn.TabIndex = 37;
            this.kopyalaBtn.Text = "Kopyala";
            this.kopyalaBtn.UseVisualStyleBackColor = true;
            this.kopyalaBtn.Click += new System.EventHandler(this.kopyalaBtn_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.Image = global::MOAgrossStok.Properties.Resources.yenile;
            this.yenileBtn.Location = new System.Drawing.Point(798, 64);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(29, 23);
            this.yenileBtn.TabIndex = 36;
            this.yenileBtn.UseVisualStyleBackColor = true;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(64, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mavi : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(108, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Renkli Uyarı Stokta Azalan Ürünleri Gösterir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(573, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "STOKTA AZALAN ÜRÜNLER";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(576, 495);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(241, 95);
            this.listBox2.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 593);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Uyari";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(125, 593);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Renkli Uyarı Stokta Biten Ürünleri Gösterir.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(64, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Kırmızı : ";
            // 
            // stokYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 636);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kopyalaBtn);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.stokSayisi);
            this.Controls.Add(this.urunSayisi);
            this.Controls.Add(this.stokUyarı);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.yeniUrunlbl);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.urunlerDG);
            this.Controls.Add(this.uyariLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.urunBtn);
            this.Controls.Add(this.fiyatText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.miktarText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isimUrun);
            this.Controls.Add(this.kategoriCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodText);
            this.Controls.Add(this.aramaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stokYonetimi";
            this.Text = "Stok Yönetimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Urunler_FormClosed);
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakibiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakibiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aramaText;
        private System.Windows.Forms.TextBox barkodText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kategoriCombo;
        private System.Windows.Forms.TextBox isimUrun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miktarText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiyatText;
        private System.Windows.Forms.Button urunBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uyariLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroRaporlamaToolStripMenuItem;
        private System.Windows.Forms.BindingSource stokTakibiDataSetBindingSource;
        private stokTakibiDataSet stokTakibiDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private stokTakibiDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridView urunlerDG;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label yeniUrunlbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label stokUyarı;
        private System.Windows.Forms.Label urunSayisi;
        private System.Windows.Forms.Label stokSayisi;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.Button kopyalaBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}