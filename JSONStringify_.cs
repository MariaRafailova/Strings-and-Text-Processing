using System;
using System.Collections.Generic;
using System.Linq;

namespace JSONStringify_
{
    public class Students
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    public class JSONStringify_
    {
        static void Main()
        {
            var students = new List<Students>();

            var input = Console.ReadLine();

            while (input != "stringify")
            {
                var parts = input.Split(new[] { ' ', '-', '>', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var name = parts[0];
                var age = int.Parse(parts[1]);
                var grades = parts
                    .Skip(2)
                    .Select(int.Parse)
                    .ToArray();

                Students newStudent = new Students();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                students.Add(newStudent);

                input = Console.ReadLine();
            }

            Console.WriteLine(
                "[" +
                string.Join(",", students.Select(x=>
                $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ", x.Grades)}]}}"))
                + "]"
                );
        }
    }
}
