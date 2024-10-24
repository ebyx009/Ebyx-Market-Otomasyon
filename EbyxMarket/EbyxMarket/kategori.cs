using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbyxMarket
{
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        ebyxMarket1Entities vt = new ebyxMarket1Entities();
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler = vt.TBLKategoris.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLKategori t = new TBLKategori();
            t.kategoriAd = textBox2.Text;
            vt.TBLKategoris.Add(t);
            vt.SaveChanges();
            MessageBox.Show("Ekleme Yapıldı.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox1.Text);
            var ktgr = vt.TBLKategoris.Find(sil);
            vt.TBLKategoris.Remove(ktgr);
            vt.SaveChanges();
            MessageBox.Show("Silme İşlemi Tamamlandı.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int guncelle = Convert.ToInt32(textBox1.Text);
            var ktgr = vt.TBLKategoris.Find(guncelle);
            ktgr.kategoriAd = textBox2.Text;
            vt.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı.");

        }
    }
}
