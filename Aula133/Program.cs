using System.Globalization;
using Aula133.Entities;

Console.Write("Enter the name of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.Write("Common, used or imported (c/u/i) ? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (type == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime mDate = DateTime.Parse(Console.ReadLine());
        Product product = new UsedProduct(name, price, mDate);
        products.Add(product);
    }
    else if (type == 'i')
    {
        Console.Write("Customs fee: ");
        double cfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Product product = new ImportedProduct(name, price, cfee);
        products.Add(product);
    }
    else
    {
        Product product = new Product(name, price);
        products.Add(product);
    }
}

Console.WriteLine();
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}