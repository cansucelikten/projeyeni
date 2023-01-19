using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici";
            string kurs2 = "Program geliştirici";
            string kurs3 = "Java";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            //array=dizi 
            string[] kurslar = new string[] { "Yazılım geliştirici", "Program geliştirici", "Java", "dil" };
           // string[] kurslar = new string[] { kurs1, kurs2, kurs3,}; şeklindede yazılabilir.

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("sayfa sonu-- footer");
            Console.ReadKey();



        }
    }
}
