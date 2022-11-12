using System;

namespace odev4inheritancelaptop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Laptop dell = new Dell(new Islemci(), new Anakart(), new Ram(), new Disk(disktype.SSD), new Ekran());

            //Console.WriteLine("Dell");
            //dell.ozellikgir(dell);

            //dell._ram = new Ram();
            //Console.WriteLine("Dell");
            //dell.ozellikgir(dell._ram);

            //Laptop lenovo = new Lenovo(new Islemci(), new Anakart(), new Ram(), new Disk(), new Ekran());

            //Console.WriteLine("Lenovo");
            //lenovo.ozellikgir(lenovo.Ekran);

            //lenovo._ram = new Ram();
            //Console.WriteLine("Lenovo");
            //lenovo.ozellikgir(lenovo._ram);

            Laptop asus = new Asus(new Islemci("Intel",5,IslemciSerisi.I7), new Anakart(10,"GForce",false), new Ram(8,2.5f), new Disk(12,Disktipi.SDD,500,300), new Ekran(10,"Samsung",17.3f));
            Console.WriteLine(asus.ToString());

            Laptop dell = new Dell(new Islemci("Intel", 5, IslemciSerisi.I7), new Anakart(10, "GForce", false), new Ram(8, 2.5f), new Disk(12, Disktipi.SDD, 500, 300), new Ekran(10, "Samsung", 17.3f));
            Console.WriteLine(asus.ToString());

            Laptop lenovo = new Lenovo(new Islemci("Intel", 5, IslemciSerisi.I7), new Anakart(10, "GForce", false), new Ram(8, 2.5f), new Disk(12, Disktipi.SDD, 500, 300), new Ekran(10, "Samsung", 17.3f));
            Console.WriteLine(asus.ToString());

            Laptop sony = new Sony(new Islemci("Intel", 5, IslemciSerisi.I7), new Anakart(10, "GForce", false), new Ram(8, 2.5f), new Disk(12, Disktipi.SDD, 500, 300), new Ekran(10, "Samsung", 17.3f));
            Console.WriteLine(asus.ToString());


            //Console.WriteLine("Lenovo");
            //asus.ozellikgir(asus.Islemci);

            //asus._ram = new Ram();
            //Console.WriteLine("Asus");
            //asus.ozellikgir(asus._ram);

            //Laptop sony = new Sony(new Islemci(Islemciserisi.I5), new Anakart(), new Ram(), new Disk(), new Ekran());

            //Console.WriteLine("Sony");
            //sony.ozellikgir(sony.Islemci);

            //sony._ram = new Ram();
            //Console.WriteLine("Sony");
            //sony.ozellikgir(sony._ram);

        }
    }
}




