using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW4_TextParse
{
    class Program
    {

        static void Main(string[] args)
        {
            const string pathToRead = @"sample.txt";
            const string pathToWrite1 = @"Worlds.txt";
            const string pathToWrite2 = @"SentenseAndLeter.txt";

            var listOfSentence = WorkWithText.ParseOnSentense(pathToRead);

            var largestSentenceByChar = listOfSentence //наибольшее по длинне символов предложение
               .OrderByDescending(v => v.Count(c => c == ' '))
               .First();

            var smallSentenceByWorlds = listOfSentence.OrderBy(t => t.Count(c => c == ' ')).First(); // наименьшее по длинне символов предложение


            char[] separators = new char[] { ' ', '.', ',', '"', '!', '?', '(', ')', ';', '-', ':', ':','=','#','*', '_', '[', ']',
                '+', '\\', '\'', '/', '|', '&', '$', '~', '%', '\'' };
            var listOfWorlds = listOfSentence
                .ConvertAll(d => d.ToLower())
                .OrderBy(k => k)
                .SelectMany(w => w.Split(separators, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));

            var worldsInGroup = listOfWorlds
                .Where(x => !double.TryParse(x, out double i))
                .GroupBy(g => g)
                .ToDictionary(g => g.Key, y => y.Count())
                .OrderBy(k => k.Key)
                .SkipWhile(wg => wg.Key[0] != 'a');

            var letter = listOfWorlds
                .SelectMany(l => l)
                .GroupBy(g => g)
                .OrderByDescending(gr => gr.Count())
                .First().Key
                .ToString();

            var marks = listOfSentence
                .SelectMany(s => s)
                .Where(c => ",.-\":;?!".Contains(c));


            WorkWithText.writeToDoc(pathToWrite1, worldsInGroup.Select(wg => $"{wg.Key} : {wg.Value}"));
            WorkWithText.writeToDoc(pathToWrite2, new string[] { largestSentenceByChar, smallSentenceByWorlds, letter });

        }

    }
}
