using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeyeni
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int orenciSayisi = 3200 ;
            double faizOrani = 1.45 ;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35 ;
            double dolarBugun = 7.35;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirişYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }

            Console.WriteLine(kategoriEtiketi);



            Console.ReadKey();








        }
    }
}
