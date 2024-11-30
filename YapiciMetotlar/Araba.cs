using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba(int _kapiSayisi, string _arabaModel,string arabaRengi)
        {
            this.kapiSayisi = _kapiSayisi;
            this.arabaModel = _arabaModel;
            this.arabaRengi = arabaRengi;
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor Çalışıyor..");
        }

        public void kapilariKitle()
        {
            Console.WriteLine("Kapilar Kitleniyor..");
        }
    }
}
