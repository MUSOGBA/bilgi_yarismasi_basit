using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, yanlis = 0, dogru = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            label4.Text = BtnB.Text;

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            if (label4.Text == label2.Text)
            {
                dogru++;
                Lbldogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnC.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                Lbldogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnD.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                Lbldogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnA.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                Lbldogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            Lblsorusayisi.Text = soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            if (soruno == 1)
            {
                richTextBox1.Text = "TÜRKİYENİN EN BÜYÜK BARAJI AŞAĞIDAKİLERDEN HANGİSİDİR?";

                BtnA.Text = "DERİNER BARAJI";
                BtnB.Text = "ATATÜRK BARAJI";
                BtnC.Text = "FIRAT BARAJI";
                BtnD.Text = "KEBAN BARAJI";
                label2.Text = "DERİNER BARAJI";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "TÜRKİYENİN YÜZÖLÇÜMÜ OLARAK EN BÜYÜK İLİ AŞAĞIDAKİLERDEN HANGİSİDİR?";

                BtnA.Text = "ANKARA";
                BtnB.Text = "İSTANBUL";
                BtnC.Text = "KONYA";
                BtnD.Text = "VAN";
                label2.Text = "KONYA";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "TÜRKİYENİN EN YÜKSEK DAĞI AŞAĞIDAKİLERDEN HANGİSİDİR?";

                BtnA.Text = "BEY";
                BtnB.Text = "CİLO";
                BtnC.Text = "KAÇKAR";
                BtnD.Text = "AĞRI";
                label2.Text = "AĞRI";
                BtnSonraki.Text = "SONUÇLAR";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru Sayısı ="+dogru+ "\n" + "Yanlış Sayısı: "+yanlis);
            }
        }

    }
}