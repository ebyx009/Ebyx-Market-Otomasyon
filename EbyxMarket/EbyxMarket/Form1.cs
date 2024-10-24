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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ebyxMarket1Entities db = new ebyxMarket1Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLKullanicis where x.kullaniciAd == textBox1.Text && x.kullaniciSifre == textBox2.Text select x;
            if (sorgu.Any())
            {
                Islemler fr = new Islemler();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
