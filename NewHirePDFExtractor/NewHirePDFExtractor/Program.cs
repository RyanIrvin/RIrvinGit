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
            DirectoryInfo folderLocation = new DirectoryInfo(@"C:\Users\Ryan\Downloads\7-29\");
            List<FileInfo> Files = new List<FileInfo>(folderLocation.GetFiles("*.pdf"));
            Regex regexAlphanumeric = new Regex("[^ a-zA-z0-9]");
            string csvFile = "Test.csv";

            foreach (FileInfo file in Files)
            {
                PdfReader reader = new PdfReader($"{folderLocation}{file}");

                //Pulls PDF field values from their field names
                string fullName = regexAlphanumeric.Replace(reader.AcroFields.GetField("New Hire Full Name"), "").Trim();
                string managerName = regexAlphanumeric.Replace(reader.AcroFields.GetField("Manager Name"), "").Trim();
                string title = regexAlphanumeric.Replace(reader.AcroFields.GetField("Title"), "").Trim();
                string seatLocation = reader.AcroFields.GetField("Location");

                bool missingCubeNumber = String.IsNullOrEmpty(reader.AcroFields.GetField("Floor  Cube"));
                bool isContractor = reader.AcroFields.GetField("Contractor Agency").Equals("On");

                tempString.Append($"{fullName}, {title}, {managerName}, {seatLocation}, ");

                if(missingCubeNumber) //Check if seating location has been provided on Onboard Form
                    tempString.Append("NEED CUBE NUMBER");
                else
                    tempString.Append($"{reader.AcroFields.GetField("Floor  Cube")}");

                if(isContractor) //Check if new hire is a contractor or EMA employee
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;  //debuging
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
