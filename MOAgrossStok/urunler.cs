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
    public partial class Urunler : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        //SqlConnection baglanti = new SqlConnection(@"Data Source=192.168.1.3, 1433;Initial Catalog=stokTakibi;User ID=test; Password=test");   
        SqlConnection baglanti = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("ConnectionInfo"));
        public Urunler()
        {
            InitializeComponent();
            urunlerDG.ClearSelection();
            urunlerDG.RowHeadersVisible = false;
            urunlerDG.AllowUserToAddRows = false;
            toplamUrun();
            griddoldur();
            datagridHeaderText();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StokYonetimi"] == null)
            {
                stokYonetimi stokYonetimi = new stokYonetimi();
                stokYonetimi.Show();
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
        void griddoldur()
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT Urunler.barkod, Urunler.urun_ismi,Kategori.kategori_adi FROM Kategori INNER JOIN Urunler ON Kategori.kategori_id = Urunler.kategori_id", baglanti);
            adptr.Fill(tbl);
            urunlerDG.DataSource = tbl;
            baglanti.Close();
        }
        void datagridHeaderText()
        {
            urunlerDG.Columns[0].HeaderText = "Barkod";
            urunlerDG.Columns[1].HeaderText = "Ürün İsmi";
            urunlerDG.Columns[2].HeaderText = "Kategori";
         
        }

        private void aramaText_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = aramaText.Text;
            cumle = "SELECT Urunler.barkod, Urunler.urun_ismi, Kategori.kategori_adi FROM Kategori INNER JOIN Urunler ON urun_ismi like '" + vara + "%' OR barkod like '" + vara + "%' WHERE Kategori.kategori_id = Urunler.kategori_id";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglanti);
            adptr.Fill(tbl);
            baglanti.Close();
            urunlerDG.DataSource = tbl;
        }

        private void urunlerDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunlerDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.urunlerDG.MultiSelect = false;
        }

        private void Urunler_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ciroRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CiroRaporlama"] == null)
            {
                ciroRaporlama ciroRaporlama = new ciroRaporlama();
                ciroRaporlama.Show();
            }
        }

        private void stokYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Urunler_Load(object sender, EventArgs e)
        {

        }
    }
}
