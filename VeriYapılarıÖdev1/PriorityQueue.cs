using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdev1
{
    public class PriorityQueue
    {
        public List<Araba> arabalar = new List<Araba>();
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }
            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                //Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın nerede olduğu belirleniyor
                //Var olan elemanlar kaydırılıyor
                Araba a = (Araba)o;
                for (i = count - 1; i >= 0; i--)
                {
                    if (a.IslemSuresi > ((Araba)Queue[i]).IslemSuresi)//İşlem süresine göre küçükten büyüğe öncelik arandı.
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }

            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }
        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public int OrtalamaHesapla()
        {
            int Ortalama = 0;
            while (!IsEmpty())
            {
                Araba a = new Araba();
                a = (Araba)Remove();
                BeklemeSuresi += a.IslemSuresi;
                a.Beklemesuresi = BeklemeSuresi;
                ToplamBekleme += a.Beklemesuresi;
                arabalar.Add(a);
            }
            Ortalama = ToplamBekleme / 5;
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
