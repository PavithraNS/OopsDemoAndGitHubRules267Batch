using OopsDemoAndGitHubRules267Batch.ClassAndObjectConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemoAndGitHubRules267Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPS Demo");
            Car car = new Car();
            Console.WriteLine("Please enter car name");
            car.name = Console.ReadLine();
            Console.WriteLine("Please enter the price of {0}",car.name);
            //double price = double.Parse(Console.ReadLine());
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price of the {0} is {1}", car.name, car.Price(price));
            Console.ReadLine();
        }
    }
}
