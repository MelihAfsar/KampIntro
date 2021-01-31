using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C";
            kurs2.Egitmen = "Buket Doğan";
            kurs2.IzlenmeOrani = 100;
            Console.WriteLine("Hello World!");

            
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach ( Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
                Console.WriteLine("İzlenme oranı: " + kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
