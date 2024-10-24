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
    public partial class calisan : Form
    {
        public calisan()
        {
            InitializeComponent();
        }
        ebyxMarket1Entities vt = new ebyxMarket1Entities();
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler = vt.TBLCalisans.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLCalisan ekle = new TBLCalisan();
            ekle.calisanAd = textBox2.Text;
            ekle.calisanSoyad = textBox3.Text;
            ekle.calisanYas = Convert.ToInt32(textBox4.Text);
            ekle.calisanTelNo = Convert.ToInt32(textBox5.Text);
            ekle.calisanKonum = textBox6.Text;
            vt.TBLCalisans.Add(ekle);
            vt.SaveChanges();
            MessageBox.Show("Çalışan Eklendi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urun = vt.TBLCalisans.Find(x);
            vt.TBLCalisans.Remove(urun);
            vt.SaveChanges();
            MessageBox.Show("Silme İşlemi Tamamlandı.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var calisan = vt.TBLCalisans.Find(x);
            calisan.calisanAd = textBox2.Text;
            calisan.calisanSoyad = textBox3.Text;
            calisan.calisanYas = Convert.ToInt32(textBox4.Text);
            calisan.calisanTelNo = Convert.ToInt32(textBox5.Text);
            calisan.calisanKonum = textBox6.Text;
            vt.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı.");

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();

        }
    }
}
