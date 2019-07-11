using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTextToNumber
{
    class Program
    {

        static void Main(string[] args)
        {


            string number = "1-800-GET-HELP";

            Console.WriteLine(ConvertNumber(number));
            Console.ReadKey();
        }

        static string ConvertNumber(string number)
        {

            Dictionary<string, string> numberDictionary = new Dictionary<string, string>
            {
                { "ABCabc", "2" },
                { "DEFdef", "3" },
                { "GHIghi", "4" },
                { "JKLjkl", "5" },
                { "MNOmno", "6" },
                { "PQRSpqrs", "7" },
                { "TUVtuv", "8" },
                { "WXYZwxyz", "9" }
            };

            StringBuilder convertedString = new StringBuilder();

            foreach (char digit in number)
            {
                if (Char.IsDigit(digit) || !Char.IsLetterOrDigit(digit))
                    convertedString.Append(digit);
                else
                    foreach (KeyValuePair<string,string> item in numberDictionary)
                        if(item.Key.Contains(digit))
                            convertedString.Append(item.Value);
            }

            return convertedString.ToString();
        }
    }
}
