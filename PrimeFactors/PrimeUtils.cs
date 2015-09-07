using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    using System.ComponentModel;

    public static class PrimeUtils
    {
        public static List<int> GetFactors(int n)
        {
            var retVal = new List<int>();

            int newN = n;

            while (newN != 1)
            {
                var lowestPrime = GetLowestPrime(newN, out newN);
                retVal.Add(lowestPrime);
            }


            return retVal;
        }

        private static int GetLowestPrime(int n, out int newNumber)
        {
            double koren = Math.Sqrt(n);
            var sqKoren = Convert.ToInt32(Math.Ceiling(koren));

            for (int i = 2; i <= sqKoren; i++)
            {

                if (n % i == 0)
                {

                    newNumber = n / i;
                    return i;

                }


            }

            newNumber = 1;
            return n;
        }
    }
    

}
