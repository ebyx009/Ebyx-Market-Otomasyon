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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }
        ebyxMarket1Entities db = new ebyxMarket1Entities();

        private void button3_Click(object sender, EventArgs e)
        {
            urun fr = new urun();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisan fr = new calisan();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategori fr = new kategori();
            fr.Show();

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
    }
}
