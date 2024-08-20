using Perfomance_de_produtos.Entities;
using Perfomance_de_produtos.Services;
using System.Globalization;

namespace Perfomance_de_produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                int x = int.Parse(Console.ReadLine());
                list.Add(new Product(name,price));
            }

            CalculationServices calculationServices = new CalculationServices();
            Product max = calculationServices.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}