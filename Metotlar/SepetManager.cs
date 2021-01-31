using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi:  " + product.Aciklama+ " " + product.Adi);
            Console.WriteLine("Kalan ürün adedi: " + product.StokAdedi);
            Console.WriteLine("Sepete gitmek için tıklayın");
            Console.WriteLine("***************************");

        }
         public void Ekle2(string Adi, string Aciklama, double Fiyat)
        {
            Console.WriteLine("Tebrikler. Ürününüz eklendi.  " + Adi );
        }
    }
}
