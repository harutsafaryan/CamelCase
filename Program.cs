using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input text: ");
            string text = Console.ReadLine();

            var result = text.Select(x => x)
                        .Where(x => Char.IsUpper(x))
                        .Count();

            Console.WriteLine($"The number of words is: {result}");
            Console.ReadLine();
        }
    }
}
