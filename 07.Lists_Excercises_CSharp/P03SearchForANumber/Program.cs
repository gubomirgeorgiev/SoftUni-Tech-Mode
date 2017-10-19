using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> takenNums = inputList.Take(inputArray[0]).ToList();
            takenNums.RemoveRange(0,inputArray[1]);
            bool numExistance = false;
            foreach (int num in takenNums)
            {
                if (inputArray[2] == num)
                {
                    numExistance = true;
                }
            }
            if (numExistance)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
