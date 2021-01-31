
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            Console.WriteLine(kategoriEtiketi + " " + ogrenciSayisi);
            Console.WriteLine(kategoriEtiketi + " " + faizOrani);
            Console.WriteLine(kategoriEtiketi + " " + sistemeGirisYapmismi);

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Sisteme giriş yapılmıştır");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapılmamıştır.");
            }
            
            //değişim
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış oku");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("<->");
            }
            

        }
    }
}
