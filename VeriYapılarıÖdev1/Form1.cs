using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapılarıÖdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleQueue sq = new SimpleQueue(5);
        PriorityQueue pq = new PriorityQueue(5);

        public void ArabaEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Araba a = new Araba();
                a.SurucuAdı = "Driver " + Convert.ToInt16(i + i);
                a.ArabaNo = i + 1;
                a.IslemSuresi = rnd.Next(10, 300);

                Araba a2 = new Araba();
                a2.SurucuAdı = "Driver " + Convert.ToInt16(i + i);
                a2.ArabaNo = a.ArabaNo;
                a2.IslemSuresi = a.IslemSuresi;

                sq.Insert(a);
                pq.Insert(a2);

                MessageBox.Show("işlem süresi: " + a.IslemSuresi.ToString());
            }
        }
        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            ArabaEkle();

            MessageBox.Show("Başarı ile eklenmiştir...");
            btnKuyruk.Visible = true;
            btnOncelikGoster.Visible = true;
        }

        private void btnKuyruk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sq.getElements());
        }

        private void btnOncelikGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pq.getElements());
            btnKıyasla.Visible = true;
            btnKazanc.Visible = true;
        }
        public void Hesapla(List<Araba> a, List<Araba> b)
        {
            string temp = "";
            foreach (Araba x in sq.arabalar)
            {
                foreach (Araba y in pq.arabalar)
                {
                    if (x.IslemSuresi == y.IslemSuresi)
                    {
                        if (x.Beklemesuresi > y.Beklemesuresi)
                        {
                            temp += "\nBasit kuyruk: " +
                                "\nSürücü: " + x.SurucuAdı +
                                "\nAraba No: " + x.ArabaNo.ToString() +
                                "\nİşlem Süresi:" + x.IslemSuresi.ToString() + "\nSıra No:" + x.SiraNo.ToString() + Environment.NewLine;
                        }
                        else if (x.Beklemesuresi < y.Beklemesuresi)
                        {
                            temp += "\nÖncelikli kuyruk: "
                                + "\nSürücü:" + y.SurucuAdı +
                                "\nAraba No: " + y.ArabaNo.ToString() +
                                "\nİşlem Süresi: " + y.IslemSuresi.ToString() + "\nSıra No:" + y.SiraNo.ToString() + Environment.NewLine;
                        }
                        else
                        {
                            temp += "\n İkisinde de eşit işlem süresi: " + x.IslemSuresi.ToString()
                                   + " \nİşlemsüresi eşit araba no1:" + x.ArabaNo.ToString() + "\nİşlemsüresi eşit araba no2:" + y.ArabaNo.ToString() + Environment.NewLine;
                        }
                    }
                }


            }

            MessageBox.Show(temp);
        }

        private void btnKıyasla_Click(object sender, EventArgs e)
        {
            Hesapla(sq.arabalar, pq.arabalar);
        }
        public void Kazanc(List<Araba> x, List<Araba> y)
        {
            string str = "";
            int fark = 0;
            int yuzde = 0;
            foreach (Araba a in sq.arabalar)
            {
                if (sq.OrtalamaHesapla() > a.Beklemesuresi)
                {
                    fark = sq.OrtalamaHesapla() - a.Beklemesuresi;
                    yuzde = ((fark * 100) / a.Beklemesuresi);
                    str += "\n KUYRUKTA KAZANÇ \nSürücü Adı: " + a.SurucuAdı.ToString() + "\nAraba no: " + a.ArabaNo.ToString() + "\n Bekleme suresi: " + a.Beklemesuresi.ToString() + "\n ortalama: " + sq.OrtalamaHesapla().ToString() + " \nfark: " + fark.ToString() + "\n yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
                else
                {
                    fark = a.Beklemesuresi - sq.OrtalamaHesapla();
                    yuzde = ((fark * 100) / a.Beklemesuresi);
                    str += "\n KUYRUKTA KAYIP \nSürücü Adı: " + a.SurucuAdı.ToString() + "\nAraba no: " + a.ArabaNo.ToString() + " \n Bekleme suresi: " + a.Beklemesuresi.ToString() + " \nortalama: " + sq.OrtalamaHesapla().ToString() + " \nfark: " + fark.ToString() + "\n yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
            }
            MessageBox.Show(str);

        }

        private void btnKazanc_Click(object sender, EventArgs e)
        {
            Kazanc(sq.arabalar, pq.arabalar);
        }
    }
}
