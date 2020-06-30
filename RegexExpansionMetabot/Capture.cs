using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExpansionMetabot
{
    public class Capture
    {
        public static string Regextract(string pattern, string word)
        {
            string str = string.Empty;
            try
            {
                Match match = Regex.Match(word, pattern, RegexOptions.IgnoreCase);
                str = match.Value;
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  pattern = " + pattern + "  word = " + word + Environment.NewLine;
            }
            return str;
        }
    }
}
