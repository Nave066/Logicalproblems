using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalproblems
{
    internal class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            int number, sum = 0, tempVar;
            Console.Write("enter the Number :");
            number = Convert.ToInt32(Console.ReadLine());
            tempVar = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == tempVar)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
