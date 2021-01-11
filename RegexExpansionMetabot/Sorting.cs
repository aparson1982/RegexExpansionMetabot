using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpansionMetabot
{
    public class Sorting
    {
        
        internal static IEnumerable<KeyValuePair<string, int>> Source(string words, string delimiter)
        {
            try
            {
                
                string[] wordsArray = words.Split(delimiter.ToCharArray()[0]);

                IEnumerable<KeyValuePair<string, int>> source = wordsArray.SelectMany(c => c.Split(delimiter.ToCharArray()[0]))
                .GroupBy(c => c, StringComparer.InvariantCultureIgnoreCase)
                .Select(c => new KeyValuePair<string, int>(c.Key, c.Count()))
                .OrderByDescending(c => c.Value);

                return source;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
        
        /// <summary>
        /// Grabs the most commonly used word in a string separated by a delimiter.
        /// </summary>
        /// <param name="Words"></param>
        /// <param name="Delimiter"></param>
        /// <returns></returns>
        public static string MostCommon(string Words, string Delimiter)
        {
            string str = string.Empty;
            try
            {
                str = Source(Words, Delimiter).First().Key;
                //string[] wordsArray = words.Split(delimiter.ToCharArray()[0]);
                //Dictionary<String, int> stringDictionary = new Dictionary<string, int>();

                //for (int i = 0; i < wordsArray.Length; i++)
                //{
                //    if (stringDictionary.ContainsKey(wordsArray[i]))
                //    {
                //        stringDictionary[wordsArray[i]] = stringDictionary[wordsArray[i]] + 1;
                //    }
                //    else
                //    {
                //        stringDictionary.Add(wordsArray[i], 1);
                //    }
                //}

                //string key = "";
                //int value = 0;

                //foreach (KeyValuePair<string, int> kvp in stringDictionary)
                //{
                //    if (kvp.Value > value)
                //    {
                //        value = kvp.Value;
                //        key = kvp.Key;
                //    }
                //}

                //str = key;
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  Words = " + Words + "  Delimiter = " + Delimiter + Environment.NewLine;
            }
            return str;
        }


        public static string LesserCommon(string Words, string Delimiter)
        {
            string str = string.Empty;
            try
            {
                IDictionary<string, int> sourceDictionary = Source(Words,Delimiter).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                IDictionary<string, int> filteredDictionary = sourceDictionary;

                filteredDictionary.Remove(sourceDictionary.First());

                foreach (KeyValuePair<string,int>kvp in filteredDictionary)
                {
                    if (kvp.Value <= Source(Words,Delimiter).First().Value)
                    {
                        str += string.Concat(kvp.Key, Delimiter);
                    }
                }
                str = str.TrimEnd(Delimiter.ToCharArray()[0]);

                if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                {
                    str = str.Trim();
                }

            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine +
                    "Parameters:  Words = " + Words + "  Delimiter = " + Delimiter + Environment.NewLine;
            }
            return str;
        }


        public static string SortNumerical(string numberList, char delimiter, bool isAscending = true )
        {
            string str = string.Empty;
            try
            {
                List<double> numericalList = numberList.Trim().Split(delimiter).Select(x => double.Parse(x)).ToList();

                if (isAscending == true)
                {
                    numericalList.Sort();
                }
                else
                {
                    numericalList = numericalList.OrderByDescending(x => x).ToList();
                }
                str = string.Join(delimiter.ToString(), numericalList);
            }
            catch (Exception e)
            {
                str = "Message:  " + e.Message + Environment.NewLine +
                    "Source:  " + e.Source + Environment.NewLine +
                    "StackTrace:  " + e.StackTrace + Environment.NewLine +
                    "Inner Exception:  " + e.InnerException + Environment.NewLine;
            }
            return str;
        }
    }
}
