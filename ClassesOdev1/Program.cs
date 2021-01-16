using System;
class Products
{
    public string Product { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Envanter { get; set; }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Products List \n");

        Products product1 = new Products();
        product1.Product = "Smart Phone";
        product1.Category = "Technology";
        product1.Price = 999.9;
        product1.Envanter = 158;

        Products product2 = new Products();
        product2.Product = "Carpet";
        product2.Category = "House";
        product2.Price = 50.75;
        product2.Envanter = 500;

        Products product3 = new Products();
        product3.Product = "Charging Cable";
        product3.Category = "Aksesuar";
        product3.Price = 4.25;
        product3.Envanter = 2500;

        Products[] products = new Products[] { product1, product2, product3, };


        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Product : " + products[i].Product);
            Console.WriteLine("Category : " + products[i].Category);
            Console.WriteLine("Price : " + products[i].Price + "$");
            Console.WriteLine("Envanter : " + products[i].Envanter);
            Console.WriteLine("\n");
        }

        Console.WriteLine("=========================\n");

        foreach (var product in products)
        {
            Console.WriteLine("Product : " + product.Product);
            Console.WriteLine("Category : " + product.Category);
            Console.WriteLine("Price : " + product.Price + "$");
            Console.WriteLine("Envanter : " + product.Envanter);
            Console.WriteLine("\n");
        }

        Console.WriteLine("==========================\n");

        int k = 0;
        while (k < products.Length)
        {
            Console.WriteLine("Product : " + products[k].Product);
            Console.WriteLine("Category : " + products[k].Category);
            Console.WriteLine("Price : " + products[k].Price + "$");
            Console.WriteLine("Envanter : " + products[k].Envanter);
            Console.WriteLine("\n");
            k++;
        }
    }
}
