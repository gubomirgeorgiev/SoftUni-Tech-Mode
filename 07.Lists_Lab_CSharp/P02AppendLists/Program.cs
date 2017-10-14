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
            string[] appendList = (string.Join("", Regex.Split(Console.ReadLine(), @"\s+"))).Split('|');
            for (int i = appendList.Length - 1; i>0 ; i--)
            {
                Console.Write(string.Join(" ", appendList[i].ToCharArray())+ " ");
            }
            Console.Write(string.Join(" ", appendList[0].ToCharArray()));
        }
    }
}
