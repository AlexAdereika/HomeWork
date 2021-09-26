using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW4_TextParse
{
    class WorkWithText
    {

        public static List<string> ParseOnSentense(string path)
        {
            var fileLines = File.ReadAllLines(path, Encoding.UTF8);
            List<string> listOfSentence = fileLines
              .Where(s => !string.IsNullOrWhiteSpace(s))
              .SelectMany(l => Regex.Split(l, @"(?<=[\.!\?])\s+"))
              .ToList();

            return listOfSentence;

        }

        public static void writeToDoc(string path, IEnumerable<string> content)
        {
            try
            {
                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    foreach (var item in content)
                    {
                        sw.WriteLine(item);
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        

    }
}





