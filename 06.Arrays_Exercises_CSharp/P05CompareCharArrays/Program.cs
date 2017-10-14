using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05CompareCharArrays
{
    class Program
    {
        static void GetArrayArrangedAplphab(char[] arr1, char[] arr2)
        {
            bool alphabetticalyFirst = false;
            bool alphabetticalySecond = false;
            int lenghtCutterOne = arr1.Length;
            int lenghtCutterTwo = arr1.Length;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < lenghtCutterOne; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        alphabetticalyFirst = true;
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        alphabetticalyFirst = true;
                        lenghtCutterOne=0;
                    }
                    else
                    {
                        alphabetticalySecond = true;
                        lenghtCutterOne = 0;
                    }
                }
            }
            else if (arr1.Length < arr2.Length)
            {
                for (int i = 0; i < lenghtCutterOne; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        alphabetticalyFirst = true;
                    }
                    else if (arr1[i]< arr2[i])
                    {
                        alphabetticalyFirst = true;
                        lenghtCutterOne = 0;
                    }
                    else
                    {
                        alphabetticalySecond = true;
                        lenghtCutterOne = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < lenghtCutterTwo; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        alphabetticalySecond = true;
                        lenghtCutterTwo = 0;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        alphabetticalySecond = true;
                        lenghtCutterTwo = 0;
                    }
                    else
                    {
                        alphabetticalyFirst = true;
                        lenghtCutterTwo = 0;
                    }
                }
            }
            if (alphabetticalyFirst)
            {
                Console.Write(arr1);
                Console.WriteLine();
                Console.Write(arr2);
            }
            else if (alphabetticalySecond)
            {
                Console.Write(arr2);
                Console.WriteLine();
                Console.Write(arr1);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[] firstInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            GetArrayArrangedAplphab(firstInput, secondInput);
        }
    }
}
