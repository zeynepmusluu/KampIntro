using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //metodlar tekrar tekrar kullanma şansı verir.
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi); 
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
