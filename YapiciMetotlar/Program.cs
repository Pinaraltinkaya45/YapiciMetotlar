using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba(4, "BMW", "Kırmızı");

            Console.WriteLine("Arabanın Kapi Sayisi: " + a1.kapiSayisi);
            Console.WriteLine("Arabanın modeli: " + a1.arabaModel);
            Console.WriteLine("Arabanın rengi : " + a1.arabaRengi);

            a1.motorCalistir();
            a1.kapilariKitle();


            Console.ReadLine();

        }
    }
}
