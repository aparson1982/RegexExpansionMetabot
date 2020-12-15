using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpansionMetabot
{
    public class StringOperations
    {
        /// <summary>
        /// Removes all ending characters from the specified input character.  EX:  "Hello!World!!!!!!" Would become Hello!World
        /// </summary>
        /// <param name="InputString"></param>
        /// <param name="CharacterToTrim"></param>
        /// <returns></returns>
        public static string RemoveEndingCharacters(string InputString, char CharacterToTrim)
        {
            string str = string.Empty;
            try
            {
                str = InputString.TrimEnd(CharacterToTrim);
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  InputString = " + InputString + "  CharacterToTrim = " + CharacterToTrim.ToString() + Environment.NewLine;
            }
            return str;
        }

        public static string RemoveEndingCharactersExt(string InputString, string ListOfCharactersToTrim, bool RemoveNewLine = false)
        {
            string str = string.Empty;
            try
            {
                List<char> charList = new List<char>();
                charList.AddRange(ListOfCharactersToTrim);
                if (RemoveNewLine == true)
                {
                    charList.AddRange(Environment.NewLine);
                }
                Char[] chararray = charList.ToArray();
                str = InputString.TrimEnd(chararray);
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  InputString = " + InputString + "  CharacterToTrim = " + ListOfCharactersToTrim.ToString() + Environment.NewLine;
            }
            return str;
        }


        public static string TrimLastCharacter(string InputString)
        {
            string str = string.Empty;
            try
            {
                if (String.IsNullOrEmpty(InputString) || string.IsNullOrWhiteSpace(InputString))
                {
                    return InputString;
                }
                else
                {
                    str = InputString.TrimEnd(InputString[InputString.Length - 1]);
                }
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  InputString = " + InputString  + Environment.NewLine;
            }
            return str;
        }
    }
}
