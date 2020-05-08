using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexExpansionMetabot;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(Capture.Regextract(@"^[\d]+", "0000448-11-7-2019.xlsx"));
        }
    }
}
