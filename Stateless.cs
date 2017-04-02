using System;

namespace Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var result = string.Empty;

            while (first != "collapse")
            {
                while (second.Length != 0)
                {
                    while (first.Contains(second))
                    {
                        int index = first.IndexOf(second);
                        var length = second.Length;
                        result = first.Remove(index, length);
                        first = result;                        
                    }

                    second = second
                       .Remove(second.Length - 1, 1)
                       .ToString();
                    if (second.Length != 0)
                    {
                        second = second
                            .Remove(0, 1)
                            .ToString();
                    }
                }

                if (first.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(result);
                }

                first = Console.ReadLine();
                second = Console.ReadLine();
            }

        }
    }
}
