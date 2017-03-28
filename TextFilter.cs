using System;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);               

            var text = Console.ReadLine();       

            foreach (var word in words)
                
            {                
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
