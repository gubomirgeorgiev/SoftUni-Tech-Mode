using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string lowerCaseOutput = "";
            string upperCaseOutput = "";
            string mixedCaseOutput = "";
            foreach (string item in input)
            {
                if (item.All(char.IsLower))
                {
                    lowerCaseOutput +=" "+ item + ",";
                }
                else if (item.All(char.IsUpper))
                {
                    upperCaseOutput += " "+ item + ",";
                }
                else
                {
                    mixedCaseOutput += " "+ item + ",";
                }
            }
            lowerCaseOutput=lowerCaseOutput.TrimEnd(',');
            upperCaseOutput=upperCaseOutput.TrimEnd(',');
            mixedCaseOutput=mixedCaseOutput.TrimEnd(',');
            Console.WriteLine("Lower-case:" + lowerCaseOutput);
            Console.WriteLine("Mixed-case:" + mixedCaseOutput);
            Console.WriteLine("Upper-case:" + upperCaseOutput);
        }
    }
}
