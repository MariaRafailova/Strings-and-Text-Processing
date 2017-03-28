using System;
using System.Text;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(Reverse(input));
        }

        public static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
