using OOP3;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();
        IKrediManager esnafKrediManager = new EsnafKredisiManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService smsLoggerService = new SmsLoggerService();

        List<ILoggerService> loggerlar = new List<ILoggerService>() {smsLoggerService, databaseLoggerService};

        BasvuruManager basvuruManager = new BasvuruManager();

        basvuruManager.BasvuruYap(esnafKrediManager, loggerlar);

        List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}