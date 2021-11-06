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
    public partial class satisEkran : Form
    {
        string deger;
        double toplamFiyat = 0;
        double toplam = 0;
        Dictionary<int, int> sepetListesi = new Dictionary<int, int>();


        public satisEkran()
        {
            InitializeComponent();
        }
        ErrorProvider provider = new ErrorProvider();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        //SqlConnection baglanti = new SqlConnection(@"Data Source=192.168.1.3, 1433;Initial Catalog=stokTakibi;User ID=test; Password=test");   
        SqlConnection baglanti = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("ConnectionInfo"));
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void satisEkran_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
            satisDG.RowHeadersVisible = false;
            urunMiktar.Enabled = false;
            barkod.Enabled = false;
            satisDG.ClearSelection();
            satisDG.Columns.Add("Column1", "Barkod");
            satisDG.Columns.Add("Column2", "Ürün İsmi");
            satisDG.Columns.Add("Column3", "Ürün Miktar");
            satisDG.Columns.Add("Column4", "Birim Fiyat");
            satisDG.Columns.Add("Column5", "Fiyat");

        }
        void comboboxDoldur()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select * From Kasiyer", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                kasiyerAdSoyad.Items.Add(read["kasiyer_adi"]);
            }
            baglanti.Close();
        }
        int alisverisIdUret()
        {
            var id = 0;
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select MAX(alisveris_id) as id From Satislar", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                try
                {
                    id = Convert.ToInt32(read["id"]);
                }
                catch
                {
                    id = 0;
                }
            }
            baglanti.Close();
            return ++id;
        }
        int kasiyerIdBul(string kasiyerAdi)
        {
            var id = 0;
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select kasiyer_id from Kasiyer WHERE kasiyer_adi = '" + kasiyerAdi + "'", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                try
                {
                    id = Convert.ToInt32(read["kasiyer_id"]);
                }
                catch
                {
                    id = 0;
                }
            }
            baglanti.Close();
            return id;
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
        int? urunMiktarBul(string barkod)
        {
            int? miktar = null;
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            SqlCommand comboDoldur = new SqlCommand("Select stok_adet from Urunler WHERE barkod = '" + barkod + "'", baglanti);
            SqlDataReader read = comboDoldur.ExecuteReader();
            while (read.Read())
            {
                try
                {
                    miktar = Convert.ToInt32(read["stok_adet"]);
                }
                catch
                {
                    return null;
                }
            }
            baglanti.Close();
            return miktar;
        }


        private void urunEkle_Click(object sender, EventArgs e)
        {
            var alisverisId = alisverisIdUret();

            try
            {
                if (string.IsNullOrEmpty(barkod.Text.Trim()))
                {
                    provider.SetError(barkod, "Bu Alan Boş Geçilemez");
                    return;
                }
                else if (string.IsNullOrEmpty(urunMiktar.Text.Trim()))
                {
                    provider.SetError(urunMiktar, "Bu Alan Boş Geçilemez");
                }
                int a = Convert.ToInt32(urunMiktar.Text);
                var barkodInt = Convert.ToInt32(barkod.Text.Trim());
                var urunMiktari = urunMiktarBul(barkod.Text.Trim());
                if (!urunMiktari.HasValue)
                    throw new Exception("Böyle bir ürün bulunamadı!");

                if (sepetListesi.ContainsKey(barkodInt))
                {
                    urunMiktari = urunMiktari - sepetListesi[barkodInt];
                }


                if (Convert.ToInt32(urunMiktar.Text) > urunMiktari)
                    throw new Exception("Girdiğiniz ürün miktarı kadar ürün stoklarımızda bulunmamaktadır!" + " " + urunMiktari + " " + "adet ürün stoklarda bulunmaktadır.");

                if (urunMiktari <= 5)
                    MessageBox.Show("Girdiğiniz üründe 5 veya daha az stok kalmıştır lütfen stoklarınızı güncelleyin.","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);



                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DataTable tbl = new DataTable();
                string vara, cumle;
                vara = barkod.Text;
                cumle = "SELECT barkod,urun_ismi, urun_fiyat FROM Urunler WHERE barkod = '" + vara + "'";
                SqlCommand cmd = new SqlCommand(cumle, baglanti);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.HasRows)
                {
                    satisDG.AllowUserToAddRows = false;
                    while (reader.Read())
                    {
                        double urunToplam = Convert.ToInt32(urunMiktar.Text) * Convert.ToDouble(reader["urun_fiyat"]);
                        satisDG.Rows.Add(
                         Convert.ToInt32(reader["barkod"]),
                         reader["urun_ismi"],
                         urunMiktar.Text,
                         reader["urun_fiyat"],
                         urunToplam
                        );
                        toplam += urunToplam;
                        if (sepetListesi.ContainsKey(barkodInt))
                            sepetListesi[barkodInt] = sepetListesi[barkodInt] + Convert.ToInt32(urunMiktar.Text);
                        else
                            sepetListesi.Add(barkodInt, Convert.ToInt32(urunMiktar.Text));
                         urunFiyat.Text = toplam.ToString() + " TL";
                        MessageBox.Show("Ürün eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            urunMiktar.Clear();
            barkod.Clear();
            barkod.Focus();

        }

        private void satisEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StokYonetimi"] == null)
            {
                stokYonetimi stokYonetimi = new stokYonetimi();
                stokYonetimi.Show();
            }


        }
        void textTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void barkod_TextChanged(object sender, EventArgs e)
        {
            urunMiktar.Enabled = true;
            if (barkod.Text == "")
            {
                urunMiktar.Enabled = false;
                urunMiktar.Clear();
            }

            provider.Clear();
        }

        private void kasiyerAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            barkod.Enabled = true;
        }

        private void barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunMiktar_TextChanged(object sender, EventArgs e)
        {
            provider.Clear();
        }

        private void satisDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satisDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.satisDG.MultiSelect = false;
            deger = satisDG.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Satışı onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                toplam = 0;
                urunFiyat.Text = toplam.ToString() + " TL";
                var aid = alisverisIdUret();
                var dataRows = satisDG.Rows;
                if (dataRows.Count < 1) return;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                foreach (DataGridViewRow item in dataRows)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Satislar]
           ([alisveris_id]
           ,[kasiyer_id]
           ,[satis_tarihi]
           ,[urun_id]
           ,[urun_miktari]
           ,[toplam_fiyat])
     VALUES
           (" + aid + @"
           ," + kasiyerIdBul(kasiyerAdSoyad.SelectedItem.ToString()) + @"
           ,GETDATE()
           ," + urunIdBul(item.Cells[0].Value.ToString().Replace(",", ".")) + @"
           ," + item.Cells[2].Value.ToString().Replace(",", ".") + @"
           ," + item.Cells[4].Value.ToString().Replace(",", ".") + ")";

                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();
                    cmd.ExecuteNonQuery();
                }
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();



                //aid

                string sorgu = @"UPDATE Urunler SET stok_adet = stok_adet - satilanlar.um FROM ( select urun_id as uid, urun_miktari as um from Satislar WHERE alisveris_id =@aid) satilanlar WHERE urun_id = satilanlar.uid ";
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@aid", aid);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış tamamlandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                satisDG.Rows.Clear();
            }
            else if (secenek == DialogResult.No)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Satışı iptal etmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                barkod.Text = "";
                satisDG.Rows.Clear();
                toplam = 0;
                urunFiyat.Text = toplam.ToString() + " TL";
                sepetListesi.Clear();
                MessageBox.Show("Satış iptal edildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow theRowView in satisDG.SelectedRows)
            {
                if (toplam != 0)
                {
                    toplam = toplam - Convert.ToDouble(deger);
                    urunFiyat.Text = toplam.ToString() + " TL";
                }
                satisDG.Rows.Remove(theRowView);
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
    }
}
