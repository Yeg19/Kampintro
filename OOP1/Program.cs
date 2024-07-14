using OOP1;

class program
{
    static void Main(string[] args)
    {
        Product product = new Product();
        product.Id = 1;
        product.CategoryId = 2;
        product.ProductName = "Masa";
        product.UnitPrice = 500;
        product.UnitsInStock = 3;

        Product product1 = new Product { Id=2, CategoryId=5, ProductName="Kalem", UnitsInStock=10, UnitPrice=120};
        
        ProductManager productManager = new ProductManager();
        productManager.Add(product);
        Console.WriteLine(product.ProductName);
    }
}