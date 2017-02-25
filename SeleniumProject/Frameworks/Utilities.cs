using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class Utilities
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Killing processes
            foreach (var process in Process.GetProcessesByName("firefox"))
            {
                process.Kill();
            }

            //Generating random numbers and strings for test data
            Console.WriteLine("8 digit random number -> " + getRandomDigits(8));

            Console.WriteLine("random String of 8 chars -> " + getRandomStrings(8));


            //Extracting information from strings
            string text = "Paid amt 655 and transaction id is 892";
            Regex pattern = new Regex(@"Paid amt (?<amt>\d+) and transaction id is (?<tranid>\d+)");
            Match match = pattern.Match(text);
            int paidAmt = int.Parse(match.Groups["amt"].Value);
            int transactionId = int.Parse(match.Groups["tranid"].Value);
            Console.WriteLine("Paid Amt is " + paidAmt);
            Console.WriteLine("Transaction id " + transactionId);

            //Date and time
           //print current system time and date
           Console.WriteLine(DateTime.Now);

            //convert the string to date
            DateTime d = new DateTime();
            d = DateTime.Parse("09-jan-1986");

            //convert the string to date using parseexact method
            d = DateTime.ParseExact("09/01/1986", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


            //Get future date and Change the date format in c#
            Console.WriteLine(d.Add(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy"));

            //Get past date and Change the date format in c#
            Console.WriteLine(d.Add(TimeSpan.FromDays(-1)).ToString("dd/MM/yyyy"));

        }

        private string getRandomStrings(int length)
        {
            const string charSet = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz*";
            char[] myString = new char[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                myString[i] = charSet[random.Next(0, charSet.Length)];
            }

            return new string(myString);
        }

        public String getRandomDigits(int length) {
            Random random = new Random();
            StringBuilder digits = new StringBuilder("");
           
            for (int i = 1; i <=length; i++)
            {
                digits.Append(random.Next(0, 9).ToString());
            }
            return digits.ToString();
        }


        [TestMethod]
        public void TestStrings()
        {
            //To find the length of the string
            Console.WriteLine("Length of sagar -> " + "sagar".Length);

            //To find the n characters from the left side
            Console.WriteLine("Left 3 char of sagar -> " + "sagar".Substring(0, 3));

            //To find the last n characters of the string 
            Console.WriteLine("Last 2 char of sagar -> " + "sagar".Substring("sagar".Length - 2, 2));

            //To convert the string to upper case
            Console.WriteLine("String - sagar salunke in upper case is -> " + "sagar salunke".ToUpper());

            //To convert the string to lower case
            Console.WriteLine("String - SAGAR SALUNKE in lower case is -> " + "SAGAR SALUNKE".ToLower());

            //To check if the string starts with specified sub string
            Console.WriteLine("String - sagar salunke starts with sagar? -> " + "sagar salunke".StartsWith("sagar"));

            //How to replace the string with other string
            Console.WriteLine("sagar salunke replaced by ganesh salunke -> " + "sagar salunke".Replace("sagar", "ganesh"));

            //padding the string from right 
            Console.WriteLine("sagar padded by 10* -> " + "sagar".PadRight(10, '*'));

            //Check if the given substring exists in string
            Console.WriteLine("sagar salunke contains sagar?" + "sagar salunke".Contains("sagar"));

            //check for the equality of the string
            Console.WriteLine("Result of comparison of sa with Sa -> " + "sa".Equals("Sa", StringComparison.OrdinalIgnoreCase));


            //join 2 string in array
            String[] p = { "sachin", "tendulkar" };
            Console.WriteLine("String after joining -> " + String.Join(" ", p));

            //find the index of character any character say a
            Console.WriteLine("Index of a in sadffa -> " + "sadffa".IndexOf('a'));

            //convert the string to array
            char[] ar = "sagar".ToCharArray();
            Console.WriteLine("String converted to array - sagar -> " + ar[2]);

            //split the string by any character say *
            String[] s = "sa*gar".Split('*');
            Console.WriteLine("sa*gar splitted with * ->" + s[0]);
        }

    }
}
