using System;

namespace odev4inheritancelaptop
{
    internal class Disk
    {
        internal float Fiyat { get; private set; }
        internal Disktipi Disktipi { get; private set; }
        internal int OkumaHizi { get; private set; }
        internal int YazmaHizi { get; private set; }
        internal Disk(float fiyat, Disktipi diskTipi, int okumaHizi, int yazmaHizi)
        {
            Fiyat = fiyat;
            Disktipi = diskTipi;
            OkumaHizi = okumaHizi;
            YazmaHizi = yazmaHizi;
        }
        public override string ToString()
        {
            return String.Format("Tipi: {0}, Okuma hizi: {1}MB/s, Yazma hizi: {2} MB/s, Fiyat : {3}", Disktipi, OkumaHizi, YazmaHizi,Fiyat);
        }
    }
}




