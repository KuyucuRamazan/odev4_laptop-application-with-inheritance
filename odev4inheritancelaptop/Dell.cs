using System;

namespace odev4inheritancelaptop
{
    internal class Dell : Laptop
    {
        internal override float KarCarpani { get; set; } = 1.1f;
        internal Dell(Islemci islemci, Anakart anakart, Ram ram, Disk disk, Ekran ekran):base(anakart,islemci,disk,ekran,ram)
        {
           
        }
    }
}




