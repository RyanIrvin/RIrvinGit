using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationLock
{
    class Program
    {
        //Calculate the minimum number of turns it can take to move from one combination to another
        //Assumes a standard 10 digit rotation lock as found on a briefcase
        
        static void Main(string[] args)
        {
            string currentCode = "6890";
            string targetCode = "1103";

            Console.WriteLine(MinTurns(currentCode, targetCode).ToString());
            Console.ReadKey();
        }

        public static int MinTurns(string current, string target)
        {
            int result = 0;

            for (int i = 0; i < current.Length; i++)
            {
                int num1 = (int)current[i];
                int num2 = (int)target[i];

                if (Math.Abs(num1 - num2) > 5)
                    result += 10 - Math.Abs(num1 - num2);
                else
                    result += Math.Abs(num1 - num2);
            }

            return result;
        }
    }
}
