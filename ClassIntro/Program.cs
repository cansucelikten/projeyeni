using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin demirağ";
            kurs1.izlenmeorani = 68;

            Kurs kurs2=new Kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeorani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "python";
            kurs3.egitmen = "hakan";
            kurs3.izlenmeorani = 80;

            //Console.WriteLine(kurs1.kursAdi +"-- " + kurs1.egitmen + "--"+ kurs1.izlenmeorani);
            //Console.WriteLine(kurs2.kursAdi + "-- " + kurs2.egitmen + "--" + kurs2.izlenmeorani);
            //Console.WriteLine(kurs3.kursAdi + "-- " + kurs3.egitmen + "--" + kurs3.izlenmeorani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + "-- " + kurs.egitmen + "--" + kurs.izlenmeorani);
            }



            Console.ReadKey();

        }

        class Kurs
        {
            public string kursAdi { get; set; }
            public string egitmen { get; set; }
            public int izlenmeorani { get; set; }
        }


    }
}
