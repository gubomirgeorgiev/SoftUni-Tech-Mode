using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public decimal[] Grades { get; set; }

        public decimal Average
        {
            get { return Grades.Average(); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> array = File.ReadAllText("../../input.txt")
                .Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                .ToList();
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            for (int inputFromFile = 0; inputFromFile < array.Count; inputFromFile++)
            {
                
                int strudentResults = int.Parse(array[inputFromFile][0]);
                List<Student> grades = new List<Student>();
                for (int i = 0; i < strudentResults; i++)
                {
                    grades.Add(GetStudent(array[inputFromFile][i + 1]));
                }
                grades = grades.Where(g => g.Average >= 5).OrderBy(x => x.Name).ToList();
                Dictionary<string, List<decimal>> output = new Dictionary<string, List<decimal>>();
                foreach (Student name in grades)
                {
                    if (!output.ContainsKey(name.Name))
                    {
                        output[name.Name] = new List<decimal>();
                        output[name.Name].Add(name.Average);
                    }
                    else
                    {
                        output[name.Name].Add(name.Average);
                        List<decimal> orderGrades = output[name.Name].OrderByDescending(x => x).ToList();
                        output[name.Name].Clear();
                        output[name.Name] = new List<decimal>();
                        foreach (decimal grade in orderGrades)
                        {
                            output[name.Name].Add(grade);
                        }
                        output[name.Name].OrderByDescending(g => g);
                    }
                }

                foreach (string student in output.Keys)
                {
                    foreach (double studentGrade in output[student])
                    {
                        File.AppendAllText(outputPath, ($"{student} -> {studentGrade:F2}") + Environment.NewLine);
                    }
                }
                File.AppendAllText(outputPath, Environment.NewLine);
            }
        }
        static Student GetStudent(string line)
        {
            string input = line;
            Student newStrudent = new Student
            {
                Name = input.Split(' ').First(),
                Grades = input.Split(' ').Skip(1).Select(decimal.Parse).ToArray()
            };
            return newStrudent;
        }
    }        
}
