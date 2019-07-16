using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4ck3rSp34k
{
    class Program
    {
        /*
         * Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.

            Examples
            HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
            
            HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
            
            HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
            Notes
            In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
        */

        static void Main(string[] args)
        {

            string str = "eMoney Advisor";
            StringBuilder sbString = new StringBuilder();
            Dictionary<char, char> conversion = new Dictionary<char, char> { { 's', '5' }, { 'a', '4' }, { 'e', '3' }, { 'i', '1' }, { 'o', '0' } };

            foreach (char letter in str)
                if (conversion.Keys.Contains(char.ToLower(letter)))
                    sbString.Append(conversion[char.ToLower(letter)]);
                else
                    sbString.Append(letter);

            Console.WriteLine(sbString.ToString());
            Console.ReadKey();
        }
    }
}
