using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        { 
            //int,decimal,float,double,bool=değer tip
            // array,class, interface=referans tip

            //DEĞER TİPLERDE DEĞERE ATILIYOR REFERANS TİPLERDE İSE ADRESE ATILIYOR.


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            sayi1 ??? //65

            int[] sayilar1= new[] { 10, 20, 30 };
            int[] sayilar2 = new[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1=??? 999

        }
    }
}
