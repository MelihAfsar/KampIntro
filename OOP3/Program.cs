using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


            IKrediManager tasıtKrediManager = new TasıtKrediManager();
          

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            
            ILoggerService fileLogerService = new FileLoggerService();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, dataBaseLoggerService);
            Console.WriteLine("------------------------------------------------");
            basvuruManager.BasvuruYap(tasıtKrediManager, fileLogerService);
            Console.WriteLine("------------------------------------------------");
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);
            Console.WriteLine("------------------------------------------------");

            // basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
