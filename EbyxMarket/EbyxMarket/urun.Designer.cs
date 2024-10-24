
namespace EbyxMarket
{
    partial class urun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urunid = new System.Windows.Forms.TextBox();
            this.urun_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urun_marka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urun_stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urun_fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(257, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(364, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(471, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(578, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(685, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(85, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunid
            // 
            this.urunid.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.urunid.Location = new System.Drawing.Point(226, 205);
            this.urunid.Multiline = true;
            this.urunid.Name = "urunid";
            this.urunid.Size = new System.Drawing.Size(111, 25);
            this.urunid.TabIndex = 7;
            this.urunid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // urun_ad
            // 
            this.urun_ad.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.urun_ad.Location = new System.Drawing.Point(226, 246);
            this.urun_ad.Multiline = true;
            this.urun_ad.Name = "urun_ad";
            this.urun_ad.Size = new System.Drawing.Size(111, 25);
            this.urun_ad.TabIndex = 9;
            this.urun_ad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Ad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // urun_marka
            // 
            this.urun_marka.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.urun_marka.Location = new System.Drawing.Point(226, 286);
            this.urun_marka.Multiline = true;
            this.urun_marka.Name = "urun_marka";
            this.urun_marka.Size = new System.Drawing.Size(111, 25);
            this.urun_marka.TabIndex = 11;
            this.urun_marka.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Marka :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // urun_stok
            // 
            this.urun_stok.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.urun_stok.Location = new System.Drawing.Point(568, 246);
            this.urun_stok.Multiline = true;
            this.urun_stok.Name = "urun_stok";
            this.urun_stok.Size = new System.Drawing.Size(111, 25);
            this.urun_stok.TabIndex = 15;
            this.urun_stok.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(427, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Stok :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.urun_fiyat.Location = new System.Drawing.Point(568, 287);
            this.urun_fiyat.Multiline = true;
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.Size = new System.Drawing.Size(111, 25);
            this.urun_fiyat.TabIndex = 17;
            this.urun_fiyat.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(427, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Fiyat :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(427, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ürün Kategori :";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(568, 209);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKategori.TabIndex = 19;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urun_fiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.urun_stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urun_marka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urun_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urunid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "urun";
            this.Text = "urun";
            this.Load += new System.EventHandler(this.urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunid;
        private System.Windows.Forms.TextBox urun_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urun_marka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urun_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urun_fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKategori;
    }
}