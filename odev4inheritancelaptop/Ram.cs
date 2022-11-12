using System;

namespace odev4inheritancelaptop
{
    internal class Ram
    {
        internal float Fiyat { get; private protected set; }
        internal float VeriyoluHizi { get; private set; }
        internal Ram(float fiyat, float veriyoluhizi)
        {
            Fiyat = fiyat;
            VeriyoluHizi= veriyoluhizi;
        }
        public override string ToString()
        {
            return String.Format("Veriyolu Hizi: {0}", VeriyoluHizi);
        }
    }
}




