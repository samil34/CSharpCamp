using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Do not repeat yourself - Kendini tekrarlama
            //type safety - tip güvenliği
            //kategoriEtiketi - değer tutucudur, alias takma isim
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
