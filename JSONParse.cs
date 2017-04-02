using System;
using System.Linq;

namespace JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var students = input
              .Remove(input.Length - 1, 1)
              .Remove(0, 1)
              .Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] != ",")
                {
                    var dataStudent = students[i]
                        .Split('[', ']')
                        .ToList();

                    var grades = dataStudent[1]
                        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                    
                    var nameAge = dataStudent[0]
                        .Split(',')
                        .ToList();
               
                    var name = nameAge[0]
                        .Split(new[] { ':', '\"' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var nameFinal = name[1];

                    var age = nameAge[1]
                        .Split(':')
                        .ToList();
                    var ageFinal = age[1];

                    if (grades.Count < 1)
                    {
                        Console.WriteLine($"{nameFinal} : {ageFinal} -> None");
                    }
                    else
                    {
                        Console.WriteLine($"{nameFinal} : {ageFinal} -> {string.Join(", ", grades)}");
                    }
                 
                }
            }

        }
    }
}
