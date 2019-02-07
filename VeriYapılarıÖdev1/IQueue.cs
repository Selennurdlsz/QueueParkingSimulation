using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdev1
{
    public interface IQueue
    {
        void Insert(object o);
        object Remove();
        object Peek();
        Boolean IsEmpty();
        string getElements();
        int OrtalamaHesapla();
    }
}
