using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15 ;
            product1.Aciklama = "Amasya";
            product1.StokAdedi = 152;

            Product product2 = new Product();
            product2.Adi = "Muz";
            product2.Fiyati = 20;
            product2.Aciklama = "İthal";
            product2.StokAdedi = 822;

            Product product3 = new Product();
            product3.Adi = "Karpuz";
            product3.Fiyati = 5;
            product3.Aciklama = "Diyarbakır";
            product3.StokAdedi = 546;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine("Adı:       " + product.Adi);
                Console.WriteLine("Özelliği:  " + product.Aciklama);
                Console.WriteLine("Fiyatı:    " + product.Fiyati);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("---------------Metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

            sepetManager.Ekle2("Armut","Yeşil Armut",12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);







        }
    }
}
