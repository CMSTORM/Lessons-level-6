using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDevides
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            double deviser=2;
            double factoriel = 1;
            
            for (double i = 1; i <= n; i++)
            {
                factoriel *= i;
                deviser *=2;
                sum += factoriel / deviser;
                if(i==n)Console.Write(sum);
                else Console.Write(sum+" + ");
            }
            Console.WriteLine(" = {0:f5}" , sum);
        }
    }
}
