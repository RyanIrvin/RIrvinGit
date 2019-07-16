using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace SimpleBankParser
{
    class Program
    {
        static string URL = "https://signin.simple.com/";
        static CookieContainer cookies = new CookieContainer();

        static void Main(string[] args)
        {
            StreamReader credentials = new StreamReader(@"C:\Users\Ryan\Desktop\Credentials.txt");
            string[] splitCreds = credentials.ReadLine().ToString().Split(',');

            string username = splitCreds[0]; //username for bank login
            string password = HttpUtility.UrlEncode(splitCreds[1]); //password for bank login

            string csrfToken = GetAuthToken(username, password);
            string response = SubmitLogin(csrfToken, username, password);
            string message = GetMFAMessage(response);
            Console.WriteLine(message);

            if(message.Contains("We just sent a code to your currently registered phone number to verify."))
            {
                Console.WriteLine("Pin Code: ");
                string pinCode = Console.ReadLine();

                SubmitMfa(csrfToken,GetToken(response),GetPartialToken(response), pinCode);
            }

            Console.ReadKey();
        }

        private static string GetToken(string response)
        {
            return Regex.Match(response, @"(?<=value="").* (?= "" name=""token"")").ToString();
        }

        private static string GetPartialToken(string response)
        {
            return Regex.Match(response, @"(?<=value="").* (?= "" name=""partial_auth_token"")").ToString();
        }

        private static string SubmitMfa(string csrfToken,string token, string partialToken, string pinCode)
        {
            string postData = $"_csrf={csrfToken}%3D&pin={pinCode}&token{token}&partial_auth_token{partialToken}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.CookieContainer = cookies;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = bytes.Length;

            using (Stream requestStream = request.GetRequestStream())
                requestStream.Write(bytes, 0, bytes.Length);

            string result;
            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }

        private static string GetMFAMessage(string loginResponse)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(loginResponse);
            return doc.DocumentNode.SelectSingleNode(@".//*[@id=""signin""]//p")?.InnerText.Trim();
        }

        private static string SubmitLogin(string token, string username, string password)
        { 
            string postData = $"_csrf={token}%3D&username={username}&password={password}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.CookieContainer = cookies;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = bytes.Length;

            using (Stream requestStream = request.GetRequestStream())
                requestStream.Write(bytes, 0, bytes.Length);

            string result;
            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }

        private static string GetAuthToken(string username, string password)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.CookieContainer = cookies;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return Regex.Match(html, @"(?<=_csrf"" content="").*(?==)").ToString();
        }
    }
}
