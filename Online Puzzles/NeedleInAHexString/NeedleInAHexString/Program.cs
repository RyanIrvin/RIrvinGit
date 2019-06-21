using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedleInAHexString
{
    class Program
    {
        /*
        Find the index of a string within a hex encoded string.

        You will be given a string which needs to be found in another string which has previously been tranlated into hex. You will need to return the first index of the needle within the hex encoded string.
        
        Examples
        FirstIndex("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world") ➞ 6
        
        FirstIndex("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world") ➞ 8
        
        FirstIndex("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored") ➞ 0
        */

        static void Main(string[] args)
        {
            string myHexString = "65 6d 6f 6e 65 79 20 61 64 76 69 73 6f 72";
            string needle = "advisor";

            Console.WriteLine(FirstIndex(myHexString, needle));
            Console.ReadKey();
        }

        public static int FirstIndex(string hexString, string needle)
        {
            StringBuilder convertedString = new StringBuilder();

            foreach (char letter in needle)
            {
                string hexValue = Convert.ToInt32(letter).ToString("X");
                convertedString.Append(hexValue.ToLower() + " "); 
            }

            convertedString.Length--; //removes the last space added from the for loop
            int index = hexString.IndexOf(convertedString.ToString());

            return index / 3;
        }
    }
}
