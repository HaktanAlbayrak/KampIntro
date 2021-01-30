using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Urun1 = new Product();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Product Urun2 = new Product();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] Urunler = new Product[] { Urun1,Urun2 };

            foreach (Product urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------------------");

            }

            Console.WriteLine("-------------------Metotlar------------------");


            //instance - Örnek
            //encapsulation - Kapsülleme(Özetleme)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
            +


            //Console.WriteLine("Hello World!");
        }
    }
}




//Don't repeat yourself. - DRY - Clean Code - Best Practice