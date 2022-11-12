using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4inheritancelaptop
{
    internal class Ekran
    {
        internal float Fiyat { get; private set; }
        internal string Adi { get; private set; }
        internal float Boyut { get; private set; }

        internal Ekran(float fiyat, string adi, float boyut)
        {
            Fiyat = fiyat;
            Adi = adi;
            Boyut = boyut;
        }
        public override string ToString()
        {
            return String.Format("Adi: {0}, Boyut: {1}", Adi, Boyut);
        }
    }
}
