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

    if (type == 'c')
    {
        Console.Write("Common, used or imported (c/u/i) ? ");
    }
    else if (type == 'i')
    {

    }
    else
    {

    }


}