namespace MOAgrossStok
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.urunlerDG = new System.Windows.Forms.DataGridView();
            this.aramaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunlerDG
            // 
            this.urunlerDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.urunlerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDG.Location = new System.Drawing.Point(12, 112);
            this.urunlerDG.Name = "urunlerDG";
            this.urunlerDG.ReadOnly = true;
            this.urunlerDG.Size = new System.Drawing.Size(303, 380);
            this.urunlerDG.TabIndex = 0;
            this.urunlerDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDG_CellClick);
            // 
            // aramaText
            // 
            this.aramaText.Location = new System.Drawing.Point(64, 52);
            this.aramaText.Name = "aramaText";
            this.aramaText.Size = new System.Drawing.Size(282, 20);
            this.aramaText.TabIndex = 3;
            this.aramaText.TextChanged += new System.EventHandler(this.aramaText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama : ";
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
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.ciroRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.ciroRaporlamaToolStripMenuItem_Click);
            // 
            // urunSayisi
            // 
            this.urunSayisi.AutoSize = true;
            this.urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSayisi.Location = new System.Drawing.Point(12, 86);
            this.urunSayisi.Name = "urunSayisi";
            this.urunSayisi.Size = new System.Drawing.Size(128, 13);
            this.urunSayisi.TabIndex = 34;
            this.urunSayisi.Text = "Toplam Ürün Sayısı : ";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 506);
            this.Controls.Add(this.urunSayisi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.aramaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunlerDG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urunler";
            this.Text = "Ürünler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Urunler_FormClosed);
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView urunlerDG;
        private System.Windows.Forms.TextBox aramaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroRaporlamaToolStripMenuItem;
        private System.Windows.Forms.Label urunSayisi;
    }
}