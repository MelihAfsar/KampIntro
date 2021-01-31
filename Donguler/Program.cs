using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 ="Matematik";
            string kurs2 ="Fizik";
            string kurs3 ="Kimya";
            string kurs4 = "BMG";

            string[] kurslar = new string[] { "Matematik", "Fizik", "Kimya","BMG","Lineer Cebir" };

            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("*********************");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
