using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndBiggest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            {
                numbers[0] = int.Parse(Console.ReadLine());
                numbers[1] = int.Parse(Console.ReadLine());
                numbers[2] = int.Parse(Console.ReadLine());
                numbers[3] = int.Parse(Console.ReadLine());
                numbers[4] = int.Parse(Console.ReadLine());
              
            }
            int biggest  = 0;
            int smallest = 0;
            foreach (int Bignum in numbers)
                {
                 if (Bignum > biggest)
                    {
                        biggest = Bignum;
                    }
                }
            smallest = biggest;
            foreach (int smallnum in numbers)
            {
                
                if (smallest > smallnum)
                {
                    smallest = smallnum;
                }
            }

            Console.WriteLine("Biggest is: " + biggest);
            Console.WriteLine("The smallest is: " + smallest);
        }
    }
}
