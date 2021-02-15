using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati =10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " +urun.Fiyati+" : " +urun.Aciklama);
                Console.WriteLine("----------------------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut","Yeşil Armut",15,17);
        }
    }
}
