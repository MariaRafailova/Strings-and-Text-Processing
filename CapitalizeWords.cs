using System;
using System.Collections.Generic;
using System.Linq;

namespace CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            var result = new List<string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var words = input
                    .Split(new[] { ' ', '.', '!', '?', ',', '-', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                foreach (var word in words)
                {
                    var firstLetter = word[0].ToString().ToUpper();

                    var otherLetters = word.ToLower().Remove(0, 1);

                    var newWord = firstLetter + otherLetters;

                    result.Add(newWord);                    
                }

                Console.WriteLine(string.Join(", ", result));

                result.Clear();

                input = Console.ReadLine();
            }

        }
    }
}
