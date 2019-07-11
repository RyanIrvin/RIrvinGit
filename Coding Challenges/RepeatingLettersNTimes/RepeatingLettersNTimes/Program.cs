using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingLettersNTimes
{
    /*
     Create a function that repeats each character in a string n times.

     Examples
     Repeat("mice", 5) ➞ "mmmmmiiiiiccccceeeee"
     
     Repeat("hello", 3) ➞ "hhheeellllllooo"
     
     Repeat("stop", 1) ➞ "stop"
    */

    class Program
    {
        static void Main(string[] args)
        {
            string myString = "eMoneyAdvisor";
            int timesToRepeat = 3;

            Console.WriteLine(Repeat(myString, timesToRepeat));

            Console.ReadKey();
        }

        public static string Repeat(string str, int num)
        {
            StringBuilder newString = new StringBuilder();

            foreach (char letter in str)
            {
                newString.Append(letter, num);
            }

            return newString.ToString();
        }
    }
}

