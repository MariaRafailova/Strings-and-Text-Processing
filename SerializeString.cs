using System;
using System.Collections.Generic;

namespace SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var countLetters = new List<char>();

            foreach (var letter in input)
            {
                List<int> indexes = new List<int>();

                int index = -1;

                if (!countLetters.Contains(letter))
                {
                    while (true)
                    {
                        index = input.IndexOf(letter, index + 1);

                        if (index < 0)
                        {
                            break;
                        }

                        indexes.Add(index);
                    }

                    Console.WriteLine($"{letter}:{string.Join("/", indexes)}");
                                        
                    countLetters.Add(letter);                  
                }          

            } 
        }
    }
}
