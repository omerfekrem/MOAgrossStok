using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOAgrossStok
{
    public partial class ciroRaporlama : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader reader;
        DataSet ds;
        string deger;
        int kasiyerID = 0;
        int secili_id = 0;
        //SqlConnection baglanti = new SqlConnection(@"Data Source=192.168.1.3, 1433;Initial Catalog=stokTakibi;User ID=test; Password=test");   
        SqlConnection baglanti = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("ConnectionInfo"));

        public ciroRaporlama()
        {
            InitializeComponent();

            gosterBtn.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
            comboboxDoldur();
        }

        private void ciroRaporlama_Load(object sender, EventArgs e)
        {
            this.ayrintiDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tumuRB.Checked = true;
            uyariLbl.ForeColor = Color.Blue;
            uyariLbl.Text = "Kendim Belirleyeceğim seçeneğini seçtiğinizde filtreleme için," + Environment.NewLine + "tarihleri ayarladıktan sonra Göster butonuna basmalısınız.";
            satisDG.RowHeadersVisible = false;
            satisDG.AutoGenerateColumns = false;
            satisDG.AllowUserToAddRows = false;
            //ayrintiGridDoldur();
            ayrintiDG.RowHeadersVisible = false;
            ayrintiDG.AllowUserToAddRows = false;
            satisGridDoldur();
            datagridHeaderText();
        }

        private void stokYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Urunler"] == null)
            {
                Urunler urunEkran = new Urunler();
                urunEkran.Show();
            }
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["satisEkran"] == null)
            {
                satisEkran satis = new satisEkran();
                satis.Show();
            }
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StokYonetimi"] == null)
            {
                stokYonetimi stokYonetimi = new stokYonetimi();
                stokYonetimi.Show();
            }
        }
        void satisGridDoldur()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            DataTable tbl = new DataTable();
            SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id
GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX), s.satis_tarihi, 103), k.kasiyer_adi", baglanti);
            tbl.Load(kmt.ExecuteReader());
            satisDG.DataSource = tbl;

        }

        void datagridHeaderText()
        {
            ayrintiDG.Columns[0].HeaderText = "Barkod";
            ayrintiDG.Columns[1].HeaderText = "Ürün İsmi";
            ayrintiDG.Columns[2].HeaderText = "Ürün Miktarı";
            ayrintiDG.Columns[3].HeaderText = "Birim Fiyatı";
            ayrintiDG.Columns[4].HeaderText = "Toplam Fiyatı";
        }


        private void yeniDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satisDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.satisDG.MultiSelect = false;
        }

        private void satisDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ayrintiDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ayrintiDG.MultiSelect = false;
        }


        private void yeniDG_SelectionChanged(object sender, EventArgs e)
        {
            if (satisDG.SelectedRows.Count < 1)
                return;
            secili_id = Convert.ToInt32(satisDG.SelectedRows[0].Cells[0].Value);
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("select Urunler.barkod,Urunler.urun_ismi,Satislar.urun_miktari,Urunler.urun_fiyat,Urunler.urun_fiyat*Satislar.urun_miktari as toplam_fiyat from Satislar INNER JOIN Urunler ON Satislar.urun_id=Urunler.urun_id WHERE alisveris_id=0" + secili_id, baglanti);
            adptr.Fill(tbl);
            ayrintiDG.DataSource = tbl;
            baglanti.Close();

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            kayıtSil(secili_id);
        }
        void kayıtSil(int numara)
        {
            DialogResult secenek = MessageBox.Show("Satışı iptal etmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                baglanti.Open();
                string sorgu = @"UPDATE Urunler SET stok_adet = stok_adet + satilanlar.um FROM ( select urun_id as uid, urun_miktari as um from Satislar WHERE alisveris_id =@aid) satilanlar WHERE urun_id = satilanlar.uid ";
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@aid", secili_id);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                string sorgu2 = @"DELETE FROM Satislar WHERE alisveris_id=" + secili_id;
                cmd = new SqlCommand(sorgu2, baglanti);
                cmd.Parameters.AddWithValue("@aid", secili_id);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış başarıyla iptal edildi! Ürünler stoklara geri eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                satisGridDoldur();
            }
            else if (secenek == DialogResult.No)
            {

            }
           
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            satisGridDoldur();
        }
        int urunIdBul(string barkod)
        {
            var id = 0;
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select urun_id from Urunler WHERE barkod = '" + barkod + "'", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                try
                {
                    id = Convert.ToInt32(read["urun_id"]);
                }
                catch
                {
                    id = 0;
                }
            }
            baglanti.Close();
            return id;
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Satışı silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                baglanti.Open();
                string sorgu = @"DELETE FROM Satislar WHERE alisveris_id=" + secili_id;
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@aid", secili_id);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış başarıyla silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                satisGridDoldur();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }



        private void tumuRB_CheckedChanged(object sender, EventArgs e)
        {
            if (tumuRB.Checked)
            {
                satisGridDoldur();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                double a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }
        }

        private void bugunRB_CheckedChanged(object sender, EventArgs e)
        {
            if (bugunRB.Checked)
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id
where convert(date,satis_tarihi,103) = convert(date, getdate(), 103)
GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi", baglanti);
                tbl.Load(kmt.ExecuteReader());
                satisDG.DataSource = tbl;
                baglanti.Close();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar where convert(date,satis_tarihi,103) = convert(date, getdate(), 103)";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                double a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }

        }

        private void buhaftaRB_CheckedChanged(object sender, EventArgs e)
        {
            if (buhaftaRB.Checked)
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id
where satis_tarihi>dateadd(day,-7,getdate())
GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi order by satis_tarihi desc", baglanti);
                tbl.Load(kmt.ExecuteReader());
                satisDG.DataSource = tbl;
                baglanti.Close();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar where satis_tarihi>dateadd(day,-7,getdate())";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                double a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }
        }

        private void buayRB_CheckedChanged(object sender, EventArgs e)
        {
            if (buayRB.Checked)
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id
where satis_tarihi>dateadd(day,-30,getdate())
GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi order by satis_tarihi desc", baglanti);
                tbl.Load(kmt.ExecuteReader());
                satisDG.DataSource = tbl;
                baglanti.Close();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar where satis_tarihi>dateadd(day,-30,getdate())";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                double a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }
        }

        private void kendimRB_CheckedChanged(object sender, EventArgs e)
        {
            gosterBtn.Enabled = kendimRB.Checked;
            dateTimePicker1.Enabled = kendimRB.Checked;
            dateTimePicker2.Enabled = kendimRB.Checked;
            dateTimePicker1_ValueChanged(sender, e);
            ((DataTable)satisDG.DataSource).Rows.Clear();
            ((DataTable)ayrintiDG.DataSource).Rows.Clear();
            label5.Text = "Liste Toplamı : " + "0" + " " + "TL";
        }

        private void gosterBtn_Click(object sender, EventArgs e)
        {
            if (kendimRB.Checked)
            {
                var d1 = "";
                var d2 = "";
                d1 += dateTimePicker1.Value.Year + "-";
                d1 += dateTimePicker1.Value.Month + "-";
                d1 += dateTimePicker1.Value.Day;
                d2 += dateTimePicker2.Value.Year + "-";
                d2 += dateTimePicker2.Value.Month + "-";
                d2 += dateTimePicker2.Value.Day;
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id
where satis_tarihi BETWEEN '" + d1 + "' AND '" + d2 + @"'
GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi order by satis_tarihi desc", baglanti);
                tbl.Load(kmt.ExecuteReader());
                satisDG.DataSource = tbl;
                baglanti.Close();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar where convert(date,satis_tarihi,103)   BETWEEN '" + d1 + "' AND '" + d2 + @"'";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                var val = cmd.ExecuteScalar();
                if (val == null || val == DBNull.Value)
                    return;
                double a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker2.Value;
            if (dateTimePicker1.Value > selectedDate)
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden eski olamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker1.Value;
            if (dateTimePicker2.Value < selectedDate)
                dateTimePicker2.Value = selectedDate;
        }
        void comboboxDoldur()
        {
            baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select * from Kasiyer", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kasiyer_adi"]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            kasiyerID = Convert.ToInt32(comboBox1.SelectedIndex);
            kasiyerID++;
            if(kasiyerID==0)
            {
                ((DataTable)satisDG.DataSource).Rows.Clear();
                ((DataTable)ayrintiDG.DataSource).Rows.Clear();
                label5.Text = "Liste Toplamı : " + "0" + " " + "TL";
            }
            else
            {
                double a = 0;
                ((DataTable)ayrintiDG.DataSource).Rows.Clear();
                label5.Text = "Liste Toplamı : " + "0" + " " + "TL";
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id WHERE s.kasiyer_id='" + kasiyerID + "' GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi", baglanti);
                tbl.Load(kmt.ExecuteReader());
                satisDG.DataSource = tbl;
                baglanti.Close();
                baglanti.Open();
                string sorgu = "SELECT SUM(toplam_fiyat) as toplam_fiyat FROM Satislar where kasiyer_id="+kasiyerID;
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                a = Convert.ToDouble(cmd.ExecuteScalar());
                label5.Text = "Liste Toplamı : " + a + " " + "TL";
                baglanti.Close();
            }
            
        }

        private void kasiyerRB_CheckedChanged(object sender, EventArgs e)
        {
            if(kasiyerRB.Checked)
            {
                comboBox1.Enabled = kasiyerRB.Checked;
               
            }
            else { comboBox1.Enabled = false; comboBox1.SelectedItem = null;  }
        }

       
        private void aramaText_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            DataTable tbl = new DataTable();
            SqlCommand kmt = new SqlCommand(@"select s.alisveris_id,CONVERT(NVARCHAR(MAX),s.satis_tarihi,103) as satis_tarihi,k.kasiyer_adi,SUM(s.toplam_fiyat) as toplam_fiyat from Satislar s 
LEFT JOIN Kasiyer k ON s.kasiyer_id = k.kasiyer_id Where kasiyer_adi like '" + aramaText.Text + "%' OR alisveris_id like '" + aramaText.Text + "%'  GROUP BY s.alisveris_id, CONVERT(NVARCHAR(MAX),s.satis_tarihi,103),k.kasiyer_adi;", baglanti);
            tbl.Load(kmt.ExecuteReader());
            satisDG.DataSource = tbl;
            baglanti.Close();
            baglanti.Open();
            label5.Text = "Liste Toplamı : " + "-" + " " + "TL";
            baglanti.Close();
        }
    }
}
