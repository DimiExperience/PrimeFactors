using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number");
            var input = Console.ReadLine();
            int broj;
            List<int> factors = null;
            if (int.TryParse(input, out broj))
            {
                factors = PrimeUtils.GetFactors(broj);
            }

            foreach (var factor in factors)
            {
                Console.WriteLine(factor);
            }

            Console.WriteLine();



        }
    }
}
