using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var namesGrades = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()
                .Split().ToArray();
            var grades = new List<double>();

            for (int j = 1; j < line.Length; j++)
            {
                var grade = double.Parse(line[j]);
                grades.Add(grade);
            }

            var student = new Student()
            {
                Name = line[0],
                Grades = grades
            };

            namesGrades.Add(student);            
        }

        var orderedNamesGrades = namesGrades.Where(x => x.AverageGrade >= 5.00).OrderByDescending(student => student.AverageGrade).OrderBy(student => student.Name);

        foreach (var item in orderedNamesGrades)
        {
            Console.WriteLine("{0} -> {1:f2}", item.Name, item.AverageGrade);   
        }
    }
}

