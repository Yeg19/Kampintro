
string kategoriEtiketi = "Kategori";
bool giris = false;
int ogrSayi = 32000;
double faizOrani = 1.69;
double dolarDun = 33.10;
double dolarBugun = 35;

if (dolarBugun > dolarDun)
{
    Console.WriteLine("Dolar Artmış");
}
else if (dolarBugun < dolarDun)
{
    Console.WriteLine("Dolar Azalmış");
}
else
{
    Console.WriteLine("Dolar Değişmemiş");
}


if (giris == true)
{
    Console.WriteLine("Profilim");
}
else
{
    Console.WriteLine("Kayıt Ol");
}
Console.WriteLine(kategoriEtiketi);

