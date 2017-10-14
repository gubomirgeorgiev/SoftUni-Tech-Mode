using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var appendList = (string.Join("", Regex.Split(Console.ReadLine(), @"\s+"))).ToArray();
            List<string> output = new List<string>();
            string add = "";
            for(int i =0; i < appendList.Length; i++)
            {
                if (appendList[i] != '|')
                {
                    add += appendList[i]+" ";
                }
                else if (appendList[i] == '|')
                {
                    output.Add(add.TrimEnd());
                    add = "";
                }
            }
            output.Add(add.TrimEnd());
            output.Reverse();
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
