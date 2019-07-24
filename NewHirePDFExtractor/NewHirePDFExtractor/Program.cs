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
            DirectoryInfo folderLocation = new DirectoryInfo(@"C:\Users\Ryan\Desktop\NewHirePDFs");
            List<FileInfo> Files = new List<FileInfo>(folderLocation.GetFiles("*.pdf"));
            Regex regexAlphanumeric = new Regex("[^ a-zA-z0-9]");

            foreach (FileInfo file in Files)
            {
                PdfReader reader = new PdfReader($"{folderLocation}\\{file}");

                string fullName = regexAlphanumeric.Replace(reader.AcroFields.GetField("New Hire Full Name"), "").Trim();
                string managerName = regexAlphanumeric.Replace(reader.AcroFields.GetField("Manager Name"), "").Trim();
                string title = regexAlphanumeric.Replace(reader.AcroFields.GetField("Title"), "").Trim();
                string seatLocation = String.IsNullOrEmpty(reader.AcroFields.GetField("Location")) ? reader.AcroFields.GetField("Location").Trim() : "NEED LOCATION";


                Console.WriteLine($"{fullName}, {managerName}, {title}, {seatLocation}");
            }

            Console.ReadKey();
        }
    }
}
