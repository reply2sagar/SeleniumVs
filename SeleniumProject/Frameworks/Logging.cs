using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class Logging
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        [TestCategory("smoke")]
        public void TestMethod1()
        {
           
            log.Info("Understanding logging framework");
            log.Warn("Warning");
            //Application settings
            Console.WriteLine("Browser name is -> " + Settings1.Default["browser"]);

            Settings1.Default["browser"] = "Firefox";
            Settings1.Default.Save();

            //Environment variables
            Console.WriteLine("Path -> " + Environment.GetEnvironmentVariable("PATH"));

        }
    }
}
