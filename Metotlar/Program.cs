using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Tarla Çileği";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("-----------------Metodlar----------------------");

            //class çağırma  örneği 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Güzel armut", 12,10);
            sepetManager.Ekle2("Armut", "Güzel armut", 12,9);
            sepetManager.Ekle2("Armut", "Güzel armut", 12,5);
        }
    }
}
