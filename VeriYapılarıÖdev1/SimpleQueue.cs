using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdev1
{
    public class SimpleQueue
    {
        public List<Araba> arabalar = new List<Araba>();
        //Üye Değişkenleri
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        //Constructor
        public SimpleQueue(int size)
        {
            this.size = size;//Private değişkene erişim sağlandı.
            Queue = new object[size];
        }

        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
            {
                throw new Exception("Queue dolu.");
            }

            if (front == -1)
            {
                front = 0;
            }

            Queue[++rear] = o;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue boş.");
            }

            object temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;
            return temp;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public int OrtalamaHesapla()
        {
            int Ortalama = 0;
            while (!IsEmpty())
            {
                Araba a = new Araba();
                a = (Araba)Remove();
                BeklemeSuresi += a.IslemSuresi;//Ortalama işlem hesabı için bekleme ve işlem süresi toplandı.
                a.Beklemesuresi = BeklemeSuresi;
                ToplamBekleme += a.Beklemesuresi;
                arabalar.Add(a);
            }
            Ortalama = ToplamBekleme / 5;//Ortalama bulunması için araba sayısına bölündü.
            return Ortalama;
        }
        public string getElements()
        {
            OrtalamaHesapla();
            string temp = "";
            int i = 0;
            foreach (Araba a in arabalar)//Listede gerekli arama yapıldı.
            {
                a.SiraNo = i + 1;
                if (a.SiraNo <= 5)
                {
                    temp += "\nSürücü Adı:" + a.SurucuAdı + " \nAraba No: " + a.ArabaNo.ToString() + " \nIslem Süresi: " + a.IslemSuresi.ToString() + " \nBekleme Suresi: " + a.Beklemesuresi.ToString() + "\nSıra No:" + a.SiraNo.ToString() + Environment.NewLine;
                    i++;
                }
            }
            temp += " \nOrtalama işlem Tamamlanma Süresi: " + OrtalamaHesapla().ToString();
            return temp;
        }
    }
}
