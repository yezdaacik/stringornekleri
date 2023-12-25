using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_örnekleri_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucuk_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam {lblMesaj.Text.Length} karakter vardır");                           
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"Merhaba Dünya, Ben {txtMesaj.Text}!";
        }

        private void btnBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "Merhaba Dünya, ";
            string mesaj2 = "Ben Yezda";

            string yeniMesaj = String.Concat(mesaj1, mesaj2);
            lblMesaj.Text = yeniMesaj;
        }

        private void btnSiraGetir_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;

            MessageBox.Show($"6. sıradaki harf {mesaj[5]}");
        }

        private void btnKacis_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba \rben \"Yezda\".";
            lblMesaj.Text = mesaj;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "Yezda";
            string isim2 = "Yezda";
            string isim3 = "Nursevim";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum1 :{durum1} --> durum2 :{durum2} \rdurum3 : {durum3} --> durum4 :{durum4}";
            MessageBox.Show(mesaj);
        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 200;

            string mesaj = $"{a} * {b} = {c}";

            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = "Ravza";
            string isim2 = "Ravza";
            string isim3 = "Sema";
            string isim4 = "Ayşe";
            string isim5 = "ravza";

            int sonuc1 = String.Compare(isim1, isim2);
            int sonuc2 = String.Compare(isim1, isim3);
            int sonuc3 = String.Compare(isim1, isim4);
            int sonuc4 = String.Compare(isim1, isim5);
            int sonuc5 = String.Compare(isim1, isim2, true);

            MessageBox.Show($"Sonuç :{sonuc1}");
            MessageBox.Show($"Sonuç :{sonuc2}");
            MessageBox.Show($"Sonuç :{sonuc3}");
            MessageBox.Show($"Sonuç :{sonuc4}");
            MessageBox.Show($"Sonuç :{sonuc5}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4);

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text} ...... {durum}");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("dünya", txtMesaj.Text);
            lblMesaj.Text = mesaj;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = lblMesaj.Text.Split(' ').ToList();
        }
    }
}
