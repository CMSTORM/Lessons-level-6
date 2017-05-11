using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ComplicatedFactorials
{
    class Factiorials
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger result1 = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            for (int i = 1; i <= number1; i++)
            {
                result1 *= i;
            }
            Console.WriteLine("N! = {0}" , result);
            Console.WriteLine("K! = {0}" , result1);
            BigInteger multiply = result * result1;
            
            BigInteger result2 = 1;
            for (int i = number1 ; i <=number ; i++)
            {
                result2 *= i;
            }
            BigInteger lastRestult = (result * result1) / result2;
            Console.WriteLine("({0}-{1})! = {2}" , number , number1 , result2);
            Console.WriteLine("{0}! * {1}! / ({2}-{3})! = {4}", number , number1 , number, number1 , lastRestult);
            Console.ReadLine();
        }
    }
}
