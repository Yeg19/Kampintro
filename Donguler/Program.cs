string[] kurslar = new string[] {"Yazilim Geliştirici" , "Java" , "Python" , "C#" };

for (int i = 1; i < 10; i=i+2)
{
    Console.WriteLine(i);
}

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}