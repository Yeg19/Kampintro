class Kurs
{
    public string? KursAdi { get; set; }
    public string? Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Yunus";
        kurs1.IzlenmeOrani = 100;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "C";
        kurs3.Egitmen = "Murat";
        kurs3.IzlenmeOrani = 77;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Doruk";
        kurs4.IzlenmeOrani = 97;

        Kurs[] kurslar = new Kurs[] {   kurs1, kurs2, kurs3, kurs4 };  

        foreach (var kurs in kurslar)
        {
            Console.WriteLine("Kurs Adı : " + kurs.KursAdi + " Eğitmen : " + kurs.Egitmen + " İzlenme Oranı : " + kurs.IzlenmeOrani);
        }
    }
}