using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDescendant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Cases
            int test = 11211230; //false
            int test2 = 1122; //true

            Console.WriteLine(PalindromeDescendant(test2));
            Console.ReadKey();
        }

        public static bool PalindromeDescendant(int num)
        {

            if (isPalindrome(num.ToString()))
            {
                return true;
            }

            string numString = GetDescendant(num.ToString());

            if (isPalindrome(numString) || isPalindrome(GetDescendant(numString)))
                return true;
            else
                return false;
        }

        public static string GetDescendant(string value)
        {
            StringBuilder sbNumString = new StringBuilder();
            int tempNum;

                for (int i = 0; i < value.Length; i += 2)
                {
                    tempNum = 0;
                    tempNum += Int32.Parse(value[i].ToString()) + Int32.Parse(value[i + 1].ToString());

                    sbNumString.Append(tempNum);
                }

                return sbNumString.ToString();
        }

        public static bool isPalindrome(string value)
        {
            for (int i = 0, j = value.Length - 1; i < value.Length - 1; i++, j--)
            {
                if (!value[i].Equals(value[j]))
                    return false;
            }
            return true;
        }
    }
}
