using System;

namespace odev4inheritancelaptop
{
    internal class Anakart
    {
        internal float Fiyat { get; set; }
        internal string EkranKarti { get; private set; }
        internal bool EkranKartiPaylasimlimi { get; private set; }


        public Anakart(float fiyat, string ekranKarti, bool ekranKartiPaylasimlimi)
        {
            Fiyat = fiyat;
            EkranKarti = ekranKarti;
            EkranKartiPaylasimlimi = ekranKartiPaylasimlimi;
        }


        public override string ToString()
        {
            return String.Format("Ekran Karti: {0}, Ekran karti paylasimli mi?: {1}", EkranKarti, EkranKartiPaylasimlimi ? "Paylaşımlı" : "Harici");

        }
    }
}




