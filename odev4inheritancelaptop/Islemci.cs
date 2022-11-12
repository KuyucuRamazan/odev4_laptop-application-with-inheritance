using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4inheritancelaptop
{
    internal class Islemci
    {
        public float Fiyat { get; set; }
        public string Marka { get; set; }
        public IslemciSerisi IslemciSerisi { get; set; }

        public Islemci(string marka, float fiyat, IslemciSerisi islemciSerisi)
        {
            Marka = marka;
            Fiyat = fiyat;
            IslemciSerisi = islemciSerisi;
        }


    }
}
