using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyVowels
{
    /*Create a function that takes a string and returns the number (count) of vowels contained within it.

        Examples
        CountVowels("Celebration") ➞ 5
        
        CountVowels("Palm") ➞ 1
        
        CountVowels("Prediction") ➞ 4
        Notes
        a, e, i, o, u are considered vowles (not y).
        All test cases are one word and only contain letters.
    */

    class Program
    {
        static void Main(string[] args)
        {
            string str = "My test string at eMoney Advisor";

            Console.WriteLine(CountVowels(str));
            Console.ReadKey();
        }

        public static int CountVowels(string str)
        {
            string vowels = "aeiou";
            int vowelCount = 0;

            return str.Count(letter => vowels.Contains(letter));
            //Rewritten as a LINQ Lambda expression

            /*
            foreach (char letter in str)
                if (vowels.Contains(letter.ToString()))
                    vowelCount++;

            return vowelCount;
            */
        }
    }
}
