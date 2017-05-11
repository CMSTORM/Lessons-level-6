using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class Catalan
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result2N = 1;
            BigInteger resultn = 1;
            BigInteger resultSum = 1;

            BigInteger sequence = 1;

            for (int s = 1; s <=n ; s++)
            {
                for (int i = 1; i < s*2; i++)
                {
                    result2N *= i;
                }
                for (int k = 1; k <= s+1; k++)
                {
                    resultSum *= k;
                }
                for (int j = 1; j <= s; j++)
                {
                    resultn *= j;
                }
                sequence = result2N / (resultSum * resultn);
                Console.WriteLine(sequence);
             }

        }
    }
}
