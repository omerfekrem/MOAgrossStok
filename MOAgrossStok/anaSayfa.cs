using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOAgrossStok
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void satisBtn_Click(object sender, EventArgs e)
        {
            satisEkran satisEkran = new satisEkran();
            satisEkran.Show();
           
        }

        private void urunlerBtn_Click(object sender, EventArgs e)
        {
            stokYonetimi urunEkran = new stokYonetimi();
            urunEkran.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                Urunler urunler = new Urunler();
                urunler.Show();
            
        }

        private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                ciroRaporlama ciroRaporlama = new ciroRaporlama();
                ciroRaporlama.Show();

        }
    }
}
