using System;

namespace Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var parts = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var sentence = parts[0].Trim();

                var elements = parts[1]
                    .Trim()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var placeholder = "{" + i + "}";

                    sentence = sentence.Replace(placeholder, elements[i]);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
