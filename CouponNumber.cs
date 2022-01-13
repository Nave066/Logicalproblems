using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalproblems
{
    class CouponNumber
    {
        public static void couponNumberProblem()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmniopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random=new Random();
            Console.WriteLine("How many tickets you want to generate");
            int getNumber = Convert.ToInt32(Console.ReadLine());
            while(getNumber > 0)
            {
                for(int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = characters[random.Next(characters.Length)];
                }
                var finalString=new String(stringChars);
                Console.WriteLine(finalString);
                getNumber=getNumber - 1;
            }
        }
    }
}
