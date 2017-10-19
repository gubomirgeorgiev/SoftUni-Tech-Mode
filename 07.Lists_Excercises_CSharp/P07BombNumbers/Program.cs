using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool[] output = new bool[inputList.Count];
            int[] bombArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombPowDecreased = bombArray[1];
            int bombPowDecreasedSec = bombArray[1];
            int sum = 0;
            for (int i=0; i < inputList.Count; i++)
            {
                if (bombArray[0] == inputList[i])
                {
                    if (i+ bombArray[1]> inputList .Count-1&& i - bombArray[1] >= 0&& output[i] == false)
                    {
                        bombPowDecreased = Math.Abs((inputList.Count - i)-i);
                        for (int firstIf = i - bombArray[1]; firstIf <= inputList.Count - 1; firstIf++)
                        {
                            output[firstIf] = true;
                        }
                    }
                    else if (i- bombArray[1] < 0 && i + bombArray[1] <= inputList.Count - 1 && output[i] == false)
                    {
                        for (int secondIf = 0; secondIf <= i + bombArray[1]; secondIf++)
                        {
                            output[secondIf] = true;
                        }
                    }
                    else if (i - bombArray[1] < 0 && i + bombArray[1] > inputList.Count - 1 && output[i] == false)
                    {
                        sum = 0;
                    }
                    else
                    {
                        if (output[i] == false)
                        {
                            if (inputList.Count== bombArray[1]+1)
                            {
                                sum = 0;
                            }
                            else
                            {
                                for (int elseIf = i - bombArray[1]; elseIf <= i + bombArray[1]; elseIf++)
                                {
                                    output[elseIf] = true;
                                }
                            }
                        }
                    }
                }
            }
            for  (int counter=0; counter< inputList.Count; counter++)
            {
                if (output[counter] == false)
                {
                    sum += inputList[counter];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
