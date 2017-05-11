using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibSeq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a;
                Console.WriteLine(a);
                int c = a;
                a = b;
                b = b + c;
            }
            Console.WriteLine(sum);
            Console.ReadLine(); 
         }
    }
}
