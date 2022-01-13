using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalproblems
{
    internal class Primenumber
    {
        public static void findPrimeNumber()
        {
            int inputNumber, iteration, m = 0, flag = 0;
            Console.WriteLine("Enter the Number to check prime: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            m = inputNumber / 2;
            for(iteration=2;iteration<=m;iteration++)
            {
                if(inputNumber%iteration==0)
                {
                    Console.WriteLine("Entered Number is not a prime");
                    flag = 1;
                    break;
                }
                if (flag == 0)
                {
                    Console.WriteLine("Entered Number is a prime");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
