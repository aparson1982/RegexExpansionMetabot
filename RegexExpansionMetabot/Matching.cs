using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpansionMetabot
{
    public class Matching
    {

        public static string isMatch(string pattern, string inputString)
        {
            string str = string.Empty;
            try
            {
                bool match = Regex.IsMatch(inputString, pattern, RegexOptions.IgnoreCase);
                if (match == true)
                {
                    str = "True";
                }
                else
                {
                    str = "False";
                }
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  pattern = " + pattern + "  inputString = " + inputString + Environment.NewLine;
            }
            return str;
        }
    }
}
