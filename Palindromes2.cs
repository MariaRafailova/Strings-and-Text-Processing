using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes2
{
    public class Palindromes2
    {
        public static void Main(string[] args)
        {
            var palindrome = new List<string>();

            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string word in input)
            {
                if (IsPalindrome(word) && !palindrome.Contains(word))
                {                    
                    palindrome.Add(word);
                }
            }

            var result = palindrome
                .OrderBy(x => x)
                .ToList();                          

            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min >= max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
