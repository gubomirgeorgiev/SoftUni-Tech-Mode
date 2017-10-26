using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; private set; }
        public List<DateTime> DatesAttend { get; set; }

        public String GetComments
        {
            get
            {
                return Comments.LastOrDefault();
            }
            set
            {
                Comments.Add(value);
            }
    }

        class Program
        {
            static void Main(string[] args)
            {
                string firstInput = Console.ReadLine();
                List<Student> student = new List<Student>();
                while (firstInput != "end of dates")
                {
                    string nameFromFirstInput = firstInput.Split(' ').First();
                    string dateString = firstInput.Split(' ').Skip(1).First();
                    string[] dates = dateString.Split(',').ToArray();
                    student.Add(GetStudentAttends(nameFromFirstInput, dates));
                    firstInput = Console.ReadLine();
                }
                string secondInput = Console.ReadLine();
                while (secondInput != "end of comments")
                {
                    string nameFromSecondInput = secondInput.Split('-').First();
                    string comment = secondInput.Split('-').Skip(1).First();
                    if (student.Select(x => x.Name).Contains(nameFromSecondInput))
                    {
                        student.Where(x => x.Name == nameFromSecondInput).FirstOrDefault().GetComments = comment;
                    }
                    secondInput = Console.ReadLine();
                }

                GetTheResultPrintedOut(student);
            }
        }
        private static void GetTheResultPrintedOut(List<Student> input)
        {
            foreach (var output in input)
            {
                Console.WriteLine(output.Name);
                Console.WriteLine("Comments:");
                if (output.Comments != null)
                {
                    Console.WriteLine("- " + string.Join("", output.Comments));
                }
                Console.WriteLine("Dates attended:");
                if (output.DatesAttend != null)
                {
                    foreach (DateTime dateFormated in output.DatesAttend)
                    {
                        Console.WriteLine($"-- {dateFormated:dd/MM/yyyy}");
                    }
                }
            }
        }

        private static Student GetStudentAttends(string name, string[] dates)
        {
            string[] orderedDates = dates.OrderBy(x => x).ToArray();
            Student nameAndDate = new Student
            {
                Name = name,
                DatesAttend = new List<DateTime>(orderedDates.Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)))
            };
            return nameAndDate;
        }
    }
}