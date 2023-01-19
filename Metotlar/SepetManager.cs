using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete eklendi! " + "/" +  urun.Adi + "/"+ urun.Aciklama + "/" +
                "7" + urun.Fiyati);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Süper. Sepete eklendi! " + urunAdi +"  " + aciklama + "  "+ fiyat + "  "+ stokadedi);
        }
    }
}
