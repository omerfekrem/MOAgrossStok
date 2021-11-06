namespace MOAgrossStok
{
    partial class anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.urunlerBtn = new System.Windows.Forms.Button();
            this.satisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = global::MOAgrossStok.Properties.Resources.unnamed;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(176, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ciro Raporlama";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::MOAgrossStok.Properties.Resources.urunicon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(12, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ürünler";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // urunlerBtn
            // 
            this.urunlerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerBtn.Image = global::MOAgrossStok.Properties.Resources._50x50;
            this.urunlerBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.urunlerBtn.Location = new System.Drawing.Point(176, 27);
            this.urunlerBtn.Name = "urunlerBtn";
            this.urunlerBtn.Size = new System.Drawing.Size(158, 84);
            this.urunlerBtn.TabIndex = 1;
            this.urunlerBtn.Text = "Stok Yönetimi";
            this.urunlerBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.urunlerBtn.UseVisualStyleBackColor = true;
            this.urunlerBtn.Click += new System.EventHandler(this.urunlerBtn_Click);
            // 
            // satisBtn
            // 
            this.satisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisBtn.Image = global::MOAgrossStok.Properties.Resources._50x50satis;
            this.satisBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisBtn.Location = new System.Drawing.Point(12, 27);
            this.satisBtn.Name = "satisBtn";
            this.satisBtn.Size = new System.Drawing.Size(158, 84);
            this.satisBtn.TabIndex = 0;
            this.satisBtn.Text = "Satış Ekranı";
            this.satisBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satisBtn.UseVisualStyleBackColor = true;
            this.satisBtn.Click += new System.EventHandler(this.satisBtn_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 216);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.urunlerBtn);
            this.Controls.Add(this.satisBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anasayfa";
            this.Text = "MOA Gross Anasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anasayfa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button satisBtn;
        private System.Windows.Forms.Button urunlerBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

