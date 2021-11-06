using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace MOAgrossStok
{
    public partial class stokYonetimi : Form
    {
        public stokYonetimi()
        {
            InitializeComponent();
        }
        ArrayList stokList = new ArrayList();
        ArrayList kritikList = new ArrayList();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        int kategoriID;
        //SqlConnection baglanti = new SqlConnection(@"Data Source=192.168.1.3, 1433;Initial Catalog=stokTakibi;User ID=test; Password=test");   
        SqlConnection baglanti = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("ConnectionInfo"));
        
        private void Urunler_Load(object sender, EventArgs e)
        {
            griddoldur();
            comboboxDoldur();
            urunlerDG.ClearSelection();
            datagridHeaderText();
            stokKontrol();
            stokKontrolKritik();
            kontrolKritik();
            labelDoldur();
            pasiflestir();
            toplamUrun();
            stokUyari();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void kontrolSifir()
        {
            foreach (DataGridViewRow element in urunlerDG.Rows)
            {
                if (Convert.ToInt32(element.Cells["stok_adet"].Value) == 0)
                {
                    element.Cells["stok_adet"].Style.BackColor = Color.Red;
                }
                urunlerDG.AllowUserToAddRows = false;
            }
        }
        public void kontrolKritik()
        {
            foreach (DataGridViewRow element in urunlerDG.Rows)
            {
                if (Convert.ToInt32(element.Cells["stok_adet"].Value) <= 5 && Convert.ToInt32(element.Cells["stok_adet"].Value) != 0)
                {
                    element.Cells["stok_adet"].Style.BackColor = Color.Aqua;
                }
                urunlerDG.AllowUserToAddRows = false;
            }
        }
        
        void griddoldur()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT Urunler.barkod, Urunler.urun_ismi, Urunler.stok_adet,Kategori.kategori_adi,Urunler.urun_fiyat FROM Kategori INNER JOIN Urunler ON Kategori.kategori_id = Urunler.kategori_id", baglanti);
            adptr.Fill(tbl);
            urunlerDG.DataSource = tbl;
            baglanti.Close();
            kontrolSifir();
            kontrolKritik();
        }

        void textDoldur()
        {
            barkodText.Text = urunlerDG.CurrentRow.Cells[0].Value.ToString();
            isimUrun.Text = urunlerDG.CurrentRow.Cells[1].Value.ToString();
            miktarText.Text = urunlerDG.CurrentRow.Cells[2].Value.ToString();
            kategoriCombo.Text = urunlerDG.CurrentRow.Cells[3].Value.ToString();
            fiyatText.Text = urunlerDG.CurrentRow.Cells[4].Value.ToString();
            barkodText.Enabled = false;
        }

        private void Urunler_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        void datagridHeaderText()
        {
            //gelen ilk verimin başlığı
            urunlerDG.Columns[0].HeaderText = "Barkod";
            //gelen ikinci verimin başlığı
            urunlerDG.Columns[1].HeaderText = "Ürün İsmi";
            //gelen üçüncü verimin başlığı
            urunlerDG.Columns[2].HeaderText = "Stok Adet";
            //gelen dördüncü verimin başlığı
            urunlerDG.Columns[3].HeaderText = "Kategori";
            //gelen beşinci verimin başlığı
            urunlerDG.Columns[4].HeaderText = "Birim Fiyat";
        }
        void comboboxDoldur()
        {
            baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select * from Kategori",baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while(read.Read())
            {
                kategoriCombo.Items.Add(read["kategori_adi"]);
            }
            baglanti.Close();
        }

        private void urunlerDG_SelectionChanged(object sender, EventArgs e)
        {
            textDoldur();
            pasiflestir();
        }
        private void yenile_Click(object sender, EventArgs e)
        {
            textTemizle();
            kaydetBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void fiyatText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void urunBtn_Click(object sender, EventArgs e)
        {
            String f = fiyatText.Text;
            var fiyat = f.Replace(",", ".");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler (barkod,urun_ismi,stok_adet,kategori_id,urun_fiyat) values ('" + barkodText.Text + "','" + isimUrun.Text + "','" + miktarText.Text + "','" + kategoriID + "','" + fiyat + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            textTemizle();
            barkodText.Enabled = false;
            stokKontrol();
            stokKontrolKritik();
            pasiflestir();
            MessageBox.Show("Ürün başarıyla eklendi!", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void kategoriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriID = Convert.ToInt32(kategoriCombo.SelectedIndex);
            kategoriID++;
        }
        void textTemizle()
        {
            kategoriCombo.ResetText();
            barkodText.Enabled = true;
            aktiflestir();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void aramaText_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = aramaText.Text;
            cumle = "SELECT Urunler.barkod, Urunler.urun_ismi, Urunler.stok_adet,Kategori.kategori_adi,Urunler.urun_fiyat FROM Kategori INNER JOIN Urunler ON urun_ismi like '" + vara + "%' OR barkod like '" + vara + "%' OR Kategori.kategori_adi like '" + vara + "%' WHERE Kategori.kategori_id = Urunler.kategori_id";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglanti);
            adptr.Fill(tbl);
            baglanti.Close();
            urunlerDG.DataSource = tbl;
            kontrolSifir();
            kontrolKritik();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            aktiflestir();
            urunBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void urunlerDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunlerDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.urunlerDG.MultiSelect = false;
            pasiflestir();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Update Urunler Set urun_ismi=@urunismi,stok_adet=@stokadet,kategori_id=@kategori,urun_fiyat=@urunfiyat Where barkod=@barkodNumara";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@urunismi", isimUrun.Text);
            cmd.Parameters.AddWithValue("@stokadet", Convert.ToInt32(miktarText.Text));
            cmd.Parameters.AddWithValue("@kategori", kategoriID);
            cmd.Parameters.AddWithValue("@urunfiyat", double.Parse(fiyatText.Text));
            cmd.Parameters.AddWithValue("@barkodNumara", barkodText.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
             griddoldur();
            silBtn.Enabled = true;
                stokKontrol();
            stokKontrolKritik();
            MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
        }
        void pasiflestir()
        {
            fiyatText.Enabled = false;
            kategoriCombo.Enabled = false;
            miktarText.Enabled = false;
            isimUrun.Enabled = false;
            fiyatText.Enabled = false;
            kaydetBtn.Enabled = false;
            urunBtn.Enabled = false;
            urunlerDG.RowHeadersVisible = false;
        }
        void aktiflestir()
        {
            fiyatText.Enabled = true;
            kategoriCombo.Enabled = true;
            miktarText.Enabled = true;
            isimUrun.Enabled = true;
            kaydetBtn.Enabled = true;
            fiyatText.Enabled = true;
            silBtn.Enabled = true;
            urunBtn.Enabled = true;
        }
        void stokKontrol()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand com = new SqlCommand("SELECT urun_ismi FROM Urunler WHERE stok_adet = '0'", baglanti);
            SqlDataReader dr = com.ExecuteReader();
            listBox1.Items.Clear();
             stokList.Clear();
            while (dr.Read())
            {
                stokList.Add(dr["urun_ismi"].ToString());
            }
            baglanti.Close();
            foreach (object eleman in stokList)
            {
                if (!listBox1.Items.Contains(eleman))
                {
                     listBox1.Items.Add(eleman);
                }
            }
            int kayitSayisi = -1;
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) From Urunler WHERE stok_adet='0'", baglanti);
                baglanti.Open();
                kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                 labelDoldur();
            baglanti.Close();
            if(kayitSayisi<1)
            {
                listBox1.Items.Clear();
                stokSayisi.Text = "Stokta bulunmayan " + listBox1.Items.Count.ToString() + " ürün var.";
            }
        }
        void stokKontrolKritik()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand com = new SqlCommand("SELECT urun_ismi FROM Urunler WHERE stok_adet <=5 And stok_adet>0", baglanti);
            SqlDataReader dr = com.ExecuteReader();
            listBox2.Items.Clear();
            kritikList.Clear();
            while (dr.Read())
            {
                kritikList.Add(dr["urun_ismi"].ToString());
            }
            baglanti.Close();
            foreach (object eleman in kritikList)
            {
                if (!listBox2.Items.Contains(eleman))
                {
                    listBox2.Items.Add(eleman);
                }
            }
            int kayitSayisi = -1;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) From Urunler WHERE stok_adet='0'", baglanti);
            baglanti.Open();
            kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            labelDoldur();
            baglanti.Close();
            if (kayitSayisi < 1)
            {
                listBox1.Items.Clear();
                label10.Text = "Stokta Azalan " + listBox1.Items.Count.ToString() + " ürün var.";
            }
        }
        void toplamUrun()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From Urunler";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            urunSayisi.Text = "Toplam Ürün Sayısı : " + dt.Rows.Count.ToString();
            urunSayisi.ForeColor = Color.Black;
            
        }
        void labelDoldur()
        {
            stokSayisi.ForeColor = Color.Blue;
            stokSayisi.Text = "Stokta bulunmayan " + listBox1.Items.Count.ToString() + " ürün var.";
            label10.ForeColor = Color.Blue;
            label10.Text = "Stokta azalan " + listBox2.Items.Count.ToString() + " ürün var.";
            stokUyarı.ForeColor = Color.Red;
            yeniUrunlbl.Text = "Yeni ürün eklemek için önce temizle butonuna basınız.";
            yeniUrunlbl.ForeColor = Color.Blue;
            uyariLabel.ForeColor = Color.Blue;
            uyariLabel.Text = "Varolan bir ürünün barkod numarasını değiştiremezsiniz" + Environment.NewLine + "ancak yeni ürün olarak ekleyebilirsiniz.";
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            griddoldur();
            stokKontrol();
            stokKontrolKritik();
        }
        void stokUyari()
        {
            if (listBox1.Items.Count > 0 && listBox2.Items.Count > 0)
            {
                MessageBox.Show("Stokta bulunmayan ve azalan ürünler var lütfen kontrol edin.", "STOK UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Stokta bulunmayan ürünler var lütfen kontrol edin.", "STOK UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBox2.Items.Count>0)
            {
                MessageBox.Show("Stokta azalan ürünler var lütfen kontrol edin.", "STOK UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void miktarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musun?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                kayıtSil(Convert.ToInt32(barkodText.Text));
            }
            else if(secenek == DialogResult.No)
            {

            }
        }
        void kayıtSil(int numara)
        {
            string sql = "DELETE FROM Urunler WHERE barkod=@barkodNumara";
            cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@barkodNumara", barkodText.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Ürün başarıyla silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barkodText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void kopyalaBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(barkodText.Text);
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Satis"] == null)
            {
                satisEkran satis = new satisEkran();
                satis.Show();
            }
        }

        private void stokYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Urunler"] == null)
            {
                Urunler urunEkran = new Urunler();
                urunEkran.Show();
            }
        }

        private void ciroRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CiroRaporlama"] == null)
            {
                ciroRaporlama ciroRaporlama = new ciroRaporlama();
                ciroRaporlama.Show();
            }
        }

        private void stokYönetimiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["Urunler"] == null)
            {
                Urunler urunEkran = new Urunler();
                urunEkran.Show();
            }
        }
    }
    }
