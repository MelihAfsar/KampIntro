using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Cıkar(int sayi1,int sayi2)
        {
            int cıkarma = sayi1 - sayi2;
            Console.WriteLine("Çıkarma sonucu:  " + cıkarma );
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpma sonucu: " + carpma);
        }
    }
}
