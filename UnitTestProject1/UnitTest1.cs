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

        [TestMethod]
        public void TestIsMatch()
        {
            Console.WriteLine(Matching.isMatch(@"^[\d]+$","131e"));
        }

        [TestMethod]
        public void TestMostCommon()
        {
            Console.WriteLine(Sorting.MostCommon("D-RAIL/SEATTL/STOC|D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK", "|"));
        }

        [TestMethod]
        public void TestLesserCommon()
        {
            Console.WriteLine(Sorting.LesserCommon("D-RAIL/SEATTL/STOC|D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK|D-RAIL/LA/STOCK", "|"));


            //Console.WriteLine(Sorting.LesserCommon("D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.|D-STOCK/L.A.", "|"));
        }
    }
}
