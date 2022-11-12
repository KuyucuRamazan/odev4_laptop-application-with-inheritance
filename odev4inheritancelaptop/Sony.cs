using System;

namespace odev4inheritancelaptop
{
    internal class Sony : Laptop
    {
        internal override float KarCarpani { get; set; } = 1.1f;
        internal Sony(Islemci islemci, Anakart anakart, Ram ram, Disk disk, Ekran ekran):base(anakart,islemci,disk,ekran,ram)
        {
           
        }
    }
}




