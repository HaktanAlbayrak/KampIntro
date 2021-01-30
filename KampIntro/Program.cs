using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarları butonu");
            //}
            //
            //{
            //Console.WriteLine("Giriş Yap butonu");
            //}

            //Console.WriteLine(kategoriEtiketi);

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }
        }
    }
}
