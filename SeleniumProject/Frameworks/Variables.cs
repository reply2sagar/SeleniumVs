using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class Variables
    {
       
        [TestMethod]
        public void TestMethod1()
        {

            //Application settings
            Console.WriteLine("Browser name is -> " + Settings1.Default["browser"]);

            Settings1.Default["browser"] = "Firefox";
            Settings1.Default.Save();

            //Environment variables
            Console.WriteLine("Path -> " + Environment.GetEnvironmentVariable("PATH"));

        }
    }
}
