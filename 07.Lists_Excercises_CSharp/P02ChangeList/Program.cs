using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 999;
            var output = "";
            for (int i =0; i < counter; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Delete")
                {
                    inputArray.RemoveAll(item => item == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    inputArray.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else
                {
                    if (command[0] == "Odd")
                    {
                        for (int j = 0; j < inputArray.Count; j++)
                        {
                            if (inputArray[j] % 2 != 0)
                            {
                                output += string.Join(" ", inputArray[j])+" ";
                            }
                        }  
                    }
                    else
                    {
                        for (int p = 0; p < inputArray.Count; p++)
                        {
                            if (inputArray[p] % 2 == 0)
                            {
                                output += string.Join(" ", inputArray[p])+ " ";
                            }
                        }
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(output.Trim());
        }
    }
}
