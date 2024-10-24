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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }
        ebyxMarket1Entities vt = new ebyxMarket1Entities();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunid.Text = "";
            urun_ad.Text = "";
            urun_marka.Text = "";
            urun_stok.Text = "";
            urun_fiyat.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler = vt.TBLUruns.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLUrun ekle = new TBLUrun();
            ekle.urunAd = urun_ad.Text;
            ekle.urunMarka = urun_marka.Text;
            ekle.urunStok = Convert.ToInt32(urun_stok.Text);
            ekle.kategoriAd = int.Parse(comboBoxKategori.SelectedValue.ToString());
            ekle.urunFiyat = decimal.Parse(urun_fiyat.Text);
            vt.TBLUruns.Add(ekle);
            vt.SaveChanges();
            MessageBox.Show("Ürün Eklendi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(urunid.Text);
            var urun = vt.TBLUruns.Find(x);
            vt.TBLUruns.Remove(urun);
            vt.SaveChanges();
            MessageBox.Show("Silme İşlemi Tamamlandı.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(urunid.Text);
            var urun = vt.TBLUruns.Find(x);
            urun.urunAd = urun_ad.Text;
            urun.urunMarka = urun_marka.Text;
            urun.urunStok = int.Parse(urun_stok.Text);
            urun.urunFiyat = decimal.Parse(urun_fiyat.Text);
            urun.kategoriAd = int.Parse(comboBoxKategori.SelectedValue.ToString());

            vt.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı.");

        }

        private void urun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from k in vt.TBLKategoris
                               select new
                               {
                                   k.kategoriID,
                                   k.kategoriAd
                               }).ToList();
            comboBoxKategori.ValueMember = "kategoriID";
            comboBoxKategori.DisplayMember = "kategoriAd";
            comboBoxKategori.DataSource = kategoriler;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            urunid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            urun_ad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            urun_marka.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            urun_stok.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            urun_fiyat.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
