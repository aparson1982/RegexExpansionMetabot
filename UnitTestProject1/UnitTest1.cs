using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexExpansionMetabot;
using FileAndFolderHelper;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(Capture.Regextract(@"(?<=\*).*?[NSns](?=\*)", "*NS*HSRP_20201021_152228.xlsx"));
        }

        [TestMethod]
        public void TestIsMatch()
        {
            Console.WriteLine(Matching.isMatch(@"^[Rr]\d{5}|\d{7}", "R20380"));
        }

        [TestMethod]
        public void TestMatch()
        {
            Console.WriteLine(Matching.isMatch(@"HSRP(?=\d)/gi", "HSRP20201021_152228.xlsx"));
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

        [TestMethod]
        public void TestRemoveLastChar()
        {
            //Console.WriteLine(StringOperations.TrimLastCharacter("\"1\",\"2\","));
            //string textFileString = TextFileOperations.ConvertTextFileToString(@"C:\Users\rparso2\Downloads\GoogleDriveTest\OPDJ000321 (1) (1) - Copy.csv");
            //Console.WriteLine(textFileString);
            //Console.WriteLine(StringOperations.RemoveEndingCharactersExt(textFileString,", ", true));
            //string literal = @"Ziem'S Carpet Workroom, Inc. \"" ";
            //Console.WriteLine(StringOperations.ToLiteral(literal, "Csharp"));

            Console.WriteLine(Sorting.SortNumerical("5.1, 1.01, 1.02, 5.11, 3, 8, 10, 11, 010, 12",',', true));

            //Console.WriteLine(StringOperations.RemoveStartingCharactersExt(literal, "\""));
        }
    }
}
