using System;

namespace odev4inheritancelaptop
{
    internal abstract class Laptop
    {
        internal virtual float KarCarpani { get; set; } = 1;

        internal float Fiyat { get; private protected set; }

        private Ram _ram;
        internal Ram Ram
        {
            get => _ram;
            set
            {
                _ram = value;
                if (_ram != null)
                {
                    Fiyat += _ram.Fiyat * (KarCarpani);
                }
                _ram = value;
            }
        }

        private Anakart _anakart;
        internal Anakart Anakart
        {
            get => _anakart;
            set
            {
                _anakart = value;

                if (_anakart != null)
                {
                    Fiyat += _anakart.Fiyat * (KarCarpani);
                }
                _anakart = value;
            }
        }

        private Islemci _islemci;
        internal Islemci Islemci
        {
            get => _islemci;
            set
            {
                _islemci = value;

                if (_islemci != null)
                {
                    Fiyat += _islemci.Fiyat * (KarCarpani);
                }
                _islemci = value;
            }
        }
        private Disk _disk;
        internal Disk Disk
        {
            get => _disk;
            set
            {
                _disk = value;
                if (_disk != null)
                {
                    Fiyat += _disk.Fiyat * (KarCarpani);
                }
                _disk = value;
            }
        }
        private Ekran _ekran;
        internal Ekran Ekran
        {
            get => _ekran;
            set
            {
                _ekran = value;
                if (_ekran != null)
                {
                    Fiyat += _ekran.Fiyat * (KarCarpani);
                }
                _ekran = value;
            }
        }
        protected Laptop(Anakart anakart, Islemci islemci, Disk disk, Ekran ekran, Ram ram)
        {
            Anakart = anakart;
            Islemci = islemci;
            Ekran = ekran;
            Disk = disk;
            Ram = ram;
        
        }

        internal void ozellikgir()
        {
            //Console.WriteLine("fiyat; {0}\nEkran; {1}\nAnakart; {2}\nIslemci; {3}\nDisk; {4}\nRam; {5}"),
            //    Fiyat, Ekran.Adi, Anakart., Islemci, Disk, _ram == null ? "Yok" : _ram.ToString());
        }
    }
}




