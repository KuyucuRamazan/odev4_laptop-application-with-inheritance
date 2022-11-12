using System;

namespace odev4inheritancelaptop
{
    internal class Asus : Laptop
    {
        internal override float KarCarpani { get; set; } = 1.09f;
        internal Asus(Islemci islemci, Anakart anakart, Ram ram, Disk disk, Ekran ekran):base(anakart,islemci,disk,ekran,ram)
        {
           
        }
    }
}




