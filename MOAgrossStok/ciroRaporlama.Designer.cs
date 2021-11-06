namespace MOAgrossStok
{
    partial class ciroRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciroRaporlama));
            this.ayrintiDG = new System.Windows.Forms.DataGridView();
            this.tumuRB = new System.Windows.Forms.RadioButton();
            this.bugunRB = new System.Windows.Forms.RadioButton();
            this.buhaftaRB = new System.Windows.Forms.RadioButton();
            this.buayRB = new System.Windows.Forms.RadioButton();
            this.kendimRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gosterBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kasiyerRB = new System.Windows.Forms.RadioButton();
            this.satisDG = new System.Windows.Forms.DataGridView();
            this.alisveris_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasiyer_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aramaText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ayrintiDG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ayrintiDG
            // 
            this.ayrintiDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ayrintiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ayrintiDG.Location = new System.Drawing.Point(6, 421);
            this.ayrintiDG.Name = "ayrintiDG";
            this.ayrintiDG.ReadOnly = true;
            this.ayrintiDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ayrintiDG.Size = new System.Drawing.Size(686, 285);
            this.ayrintiDG.TabIndex = 0;
            this.ayrintiDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.satisDG_CellClick);
            // 
            // tumuRB
            // 
            this.tumuRB.AutoSize = true;
            this.tumuRB.Location = new System.Drawing.Point(6, 28);
            this.tumuRB.Name = "tumuRB";
            this.tumuRB.Size = new System.Drawing.Size(52, 17);
            this.tumuRB.TabIndex = 1;
            this.tumuRB.TabStop = true;
            this.tumuRB.Text = "Tümü";
            this.tumuRB.UseVisualStyleBackColor = true;
            this.tumuRB.CheckedChanged += new System.EventHandler(this.tumuRB_CheckedChanged);
            // 
            // bugunRB
            // 
            this.bugunRB.AutoSize = true;
            this.bugunRB.Location = new System.Drawing.Point(6, 51);
            this.bugunRB.Name = "bugunRB";
            this.bugunRB.Size = new System.Drawing.Size(105, 17);
            this.bugunRB.TabIndex = 2;
            this.bugunRB.TabStop = true;
            this.bugunRB.Text = "Bugünkü Satışlar";
            this.bugunRB.UseVisualStyleBackColor = true;
            this.bugunRB.CheckedChanged += new System.EventHandler(this.bugunRB_CheckedChanged);
            // 
            // buhaftaRB
            // 
            this.buhaftaRB.AutoSize = true;
            this.buhaftaRB.Location = new System.Drawing.Point(6, 74);
            this.buhaftaRB.Name = "buhaftaRB";
            this.buhaftaRB.Size = new System.Drawing.Size(112, 17);
            this.buhaftaRB.TabIndex = 3;
            this.buhaftaRB.TabStop = true;
            this.buhaftaRB.Text = "Bu Haftaki Satışlar";
            this.buhaftaRB.UseVisualStyleBackColor = true;
            this.buhaftaRB.CheckedChanged += new System.EventHandler(this.buhaftaRB_CheckedChanged);
            // 
            // buayRB
            // 
            this.buayRB.AutoSize = true;
            this.buayRB.Location = new System.Drawing.Point(6, 98);
            this.buayRB.Name = "buayRB";
            this.buayRB.Size = new System.Drawing.Size(98, 17);
            this.buayRB.TabIndex = 4;
            this.buayRB.TabStop = true;
            this.buayRB.Text = "Bu Ayki Satışlar";
            this.buayRB.UseVisualStyleBackColor = true;
            this.buayRB.CheckedChanged += new System.EventHandler(this.buayRB_CheckedChanged);
            // 
            // kendimRB
            // 
            this.kendimRB.AutoSize = true;
            this.kendimRB.Location = new System.Drawing.Point(6, 122);
            this.kendimRB.Name = "kendimRB";
            this.kendimRB.Size = new System.Drawing.Size(126, 17);
            this.kendimRB.TabIndex = 5;
            this.kendimRB.TabStop = true;
            this.kendimRB.Text = "Kendim Belirleyeyim : ";
            this.kendimRB.UseVisualStyleBackColor = true;
            this.kendimRB.CheckedChanged += new System.EventHandler(this.kendimRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 180);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // gosterBtn
            // 
            this.gosterBtn.Location = new System.Drawing.Point(186, 178);
            this.gosterBtn.Name = "gosterBtn";
            this.gosterBtn.Size = new System.Drawing.Size(60, 23);
            this.gosterBtn.TabIndex = 10;
            this.gosterBtn.Text = "Göster";
            this.gosterBtn.UseVisualStyleBackColor = true;
            this.gosterBtn.Click += new System.EventHandler(this.gosterBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kasiyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Satışlar";
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(87, 367);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 23);
            this.silBtn.TabIndex = 14;
            this.silBtn.Text = "İptal Et";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(6, 367);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(75, 23);
            this.iptalBtn.TabIndex = 15;
            this.iptalBtn.Text = "Sil";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(168, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Liste Toplamı : 0";
            // 
            // uyariLbl
            // 
            this.uyariLbl.AutoSize = true;
            this.uyariLbl.Location = new System.Drawing.Point(8, 291);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(558, 13);
            this.uyariLbl.TabIndex = 17;
            this.uyariLbl.Text = "Kendim Belirleyeceğim seçeneğini seçtiğinizde filtreleme için, tarihleri ayarladı" +
    "ktan sonra Göster butonuna basmalısınız.";
            this.uyariLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 22;
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
            this.stokYönetimiToolStripMenuItem.Click += new System.EventHandler(this.stokYönetimiToolStripMenuItem_Click);
            // 
            // ciroRaporlamaToolStripMenuItem
            // 
            this.ciroRaporlamaToolStripMenuItem.Image = global::MOAgrossStok.Properties.Resources.unnamed;
            this.ciroRaporlamaToolStripMenuItem.Name = "ciroRaporlamaToolStripMenuItem";
            this.ciroRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ciroRaporlamaToolStripMenuItem.Text = "Ciro Raporlama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kasiyerRB);
            this.groupBox1.Controls.Add(this.tumuRB);
            this.groupBox1.Controls.Add(this.bugunRB);
            this.groupBox1.Controls.Add(this.buhaftaRB);
            this.groupBox1.Controls.Add(this.uyariLbl);
            this.groupBox1.Controls.Add(this.buayRB);
            this.groupBox1.Controls.Add(this.kendimRB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.gosterBtn);
            this.groupBox1.Location = new System.Drawing.Point(717, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 343);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // kasiyerRB
            // 
            this.kasiyerRB.AutoSize = true;
            this.kasiyerRB.Location = new System.Drawing.Point(6, 212);
            this.kasiyerRB.Name = "kasiyerRB";
            this.kasiyerRB.Size = new System.Drawing.Size(124, 17);
            this.kasiyerRB.TabIndex = 18;
            this.kasiyerRB.TabStop = true;
            this.kasiyerRB.Text = "Kasiyere Göre Filtrele";
            this.kasiyerRB.UseVisualStyleBackColor = true;
            this.kasiyerRB.CheckedChanged += new System.EventHandler(this.kasiyerRB_CheckedChanged);
            // 
            // satisDG
            // 
            this.satisDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.satisDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alisveris_id,
            this.satis_tarihi,
            this.kasiyer_adi,
            this.toplam_fiyat});
            this.satisDG.Location = new System.Drawing.Point(6, 40);
            this.satisDG.Name = "satisDG";
            this.satisDG.ReadOnly = true;
            this.satisDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.satisDG.Size = new System.Drawing.Size(686, 314);
            this.satisDG.TabIndex = 24;
            this.satisDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yeniDG_CellClick);
            this.satisDG.SelectionChanged += new System.EventHandler(this.yeniDG_SelectionChanged);
            // 
            // alisveris_id
            // 
            this.alisveris_id.DataPropertyName = "alisveris_id";
            this.alisveris_id.HeaderText = "Alışveriş ID";
            this.alisveris_id.Name = "alisveris_id";
            this.alisveris_id.ReadOnly = true;
            // 
            // satis_tarihi
            // 
            this.satis_tarihi.DataPropertyName = "satis_tarihi";
            this.satis_tarihi.HeaderText = "Satış Tarihi";
            this.satis_tarihi.Name = "satis_tarihi";
            this.satis_tarihi.ReadOnly = true;
            this.satis_tarihi.Width = 182;
            // 
            // kasiyer_adi
            // 
            this.kasiyer_adi.DataPropertyName = "kasiyer_adi";
            this.kasiyer_adi.HeaderText = "Kasiyer";
            this.kasiyer_adi.Name = "kasiyer_adi";
            this.kasiyer_adi.ReadOnly = true;
            this.kasiyer_adi.Width = 200;
            // 
            // toplam_fiyat
            // 
            this.toplam_fiyat.DataPropertyName = "toplam_fiyat";
            this.toplam_fiyat.HeaderText = "Toplam Fiyat";
            this.toplam_fiyat.Name = "toplam_fiyat";
            this.toplam_fiyat.ReadOnly = true;
            this.toplam_fiyat.Width = 200;
            // 
            // aramaText
            // 
            this.aramaText.Location = new System.Drawing.Point(772, 36);
            this.aramaText.Name = "aramaText";
            this.aramaText.Size = new System.Drawing.Size(254, 20);
            this.aramaText.TabIndex = 25;
            this.aramaText.TextChanged += new System.EventHandler(this.aramaText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Arama : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yenileBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.satisDG);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ayrintiDG);
            this.groupBox2.Controls.Add(this.silBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.iptalBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 729);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listeler";
            // 
            // yenileBtn
            // 
            this.yenileBtn.Image = global::MOAgrossStok.Properties.Resources.yenile;
            this.yenileBtn.Location = new System.Drawing.Point(663, 11);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(29, 23);
            this.yenileBtn.TabIndex = 37;
            this.yenileBtn.UseVisualStyleBackColor = true;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ayrıntılar";
            // 
            // ciroRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aramaText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ciroRaporlama";
            this.Text = "Ciro Raporlama";
            this.Load += new System.EventHandler(this.ciroRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayrintiDG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ayrintiDG;
        private System.Windows.Forms.RadioButton tumuRB;
        private System.Windows.Forms.RadioButton bugunRB;
        private System.Windows.Forms.RadioButton buhaftaRB;
        private System.Windows.Forms.RadioButton buayRB;
        private System.Windows.Forms.RadioButton kendimRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button gosterBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uyariLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroRaporlamaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView satisDG;
        private System.Windows.Forms.TextBox aramaText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.RadioButton kasiyerRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisveris_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasiyer_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_fiyat;
    }
}