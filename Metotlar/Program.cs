using Metotlar;
class program
{
    static void Main(string[] args)
    {
        Product product = new Product();

        product.Id = 1;
        product.Name = "Elma";
        product.Price = 15;
        product.Description = "Amasya Elması";
        product.Stock = 10;

        Product product1 = new Product();

        product1.Id = 2;
        product1.Name = "Karpuz";
        product1.Price = 80;
        product1.Description = "Diyarbakır Karpuzu";
        product1.Stock = 1;

        Product[] products = new Product[] { product, product1 };

        foreach (Product urun in products)
        {
            Console.WriteLine(urun.Id);
            Console.WriteLine(urun.Name);
            Console.WriteLine(urun.Price);
            Console.WriteLine(urun.Description);
            Console.WriteLine(urun.Stock);
            Console.WriteLine("************************");
        }
        Console.WriteLine("----------Metotlar----------");
        
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(product1);
        sepetManager.Ekle(product);

    }
}