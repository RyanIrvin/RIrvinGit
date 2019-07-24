using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewHirePDFExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder tempString = new StringBuilder();
            DirectoryInfo folderLocation = new DirectoryInfo(@"C:\Users\rirvin\Downloads\7-29\");
            List<FileInfo> Files = new List<FileInfo>(folderLocation.GetFiles("*.pdf"));
            Regex regexAlphanumeric = new Regex("[^ a-zA-z0-9]");
            string csvFile = "Test.csv";

            foreach (FileInfo file in Files)
            {
                PdfReader reader = new PdfReader($"{folderLocation}{file}");

                string fullName = regexAlphanumeric.Replace(reader.AcroFields.GetField("New Hire Full Name"), "").Trim();
                string managerName = regexAlphanumeric.Replace(reader.AcroFields.GetField("Manager Name"), "").Trim();
                string title = regexAlphanumeric.Replace(reader.AcroFields.GetField("Title"), "").Trim();
                string seatLocation = reader.AcroFields.GetField("Location");
                bool missingCubeNumber = String.IsNullOrEmpty(reader.AcroFields.GetField("Floor  Cube"));// ? "NEED CUBE NUMBER" : $"***{reader.AcroFields.GetField("Floor  Cube")}***";

                bool isContractor = reader.AcroFields.GetField("Contractor Agency").Equals("On");

                Console.Write($"\n{fullName}, {managerName}, {title}, {seatLocation}, ");

                tempString.Append($"{fullName}, {managerName}, {title}, {seatLocation}, ");

                if(missingCubeNumber)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("NEED CUBE NUMBER");
                    Console.ResetColor();

                    tempString.Append("NEED CUBE NUMBER");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{reader.AcroFields.GetField("Floor  Cube")}");
                    Console.ResetColor();

                    tempString.Append($"{reader.AcroFields.GetField("Floor  Cube")}");
                }

                if(isContractor)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($", *CONTRACTOR: {reader.AcroFields.GetField("2")}*");
                    Console.ResetColor();

                    tempString.Append($", *CONTRACTOR: {reader.AcroFields.GetField("2")}*");
                }

                List<string> contentData = new List<string>();
                contentData.Add(tempString.ToString());
                tempString.Clear();

                File.AppendAllLines($"{folderLocation}{csvFile}", contentData);

            }

            Console.ReadKey();
        }
    }
}
