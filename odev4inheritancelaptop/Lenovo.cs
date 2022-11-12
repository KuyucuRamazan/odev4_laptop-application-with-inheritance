using System;

namespace odev4inheritancelaptop
{
    internal class Lenovo : Laptop
    {
        internal override float KarCarpani { get; set; } = 1.13f;
        internal Lenovo(Islemci islemci, Anakart anakart, Ram ram, Disk disk, Ekran ekran):base(anakart,islemci,disk,ekran,ram)
        {
           
        }
    }
}




