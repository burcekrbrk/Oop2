using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();   //İhtiyacKrediManager yerine IkrediManager de dense aynı sonuç olur.
            IKrediManager tasitKrediManager = new TasitKrediManager();          //TasitKrediManager yerine IkredManager denebilir.
            IKrediManager konutKrediManager = new KonutKrediManager();         //KonutKrediManager yerine IkrediManager denebilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            System.Collections.Generic.List<IKrediManager> krediler = new System.Collections.Generic.List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
