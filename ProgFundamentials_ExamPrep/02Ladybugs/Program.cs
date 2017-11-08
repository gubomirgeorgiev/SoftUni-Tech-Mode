using System;
using System.Linq;

namespace _02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new int[int.Parse(Console.ReadLine())];
            var indexesPopulatedWithLadibugs = Console.ReadLine()
                .Split().Select(long.Parse).ToArray();
            for (int index = 0; index < indexesPopulatedWithLadibugs.Length; index++)
            {
                if (indexesPopulatedWithLadibugs.Contains(index))
                {
                    field[indexesPopulatedWithLadibugs[index]] = 1;
                }
            }
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                if (command.Length != 3)
                {
                    command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                int ladybugIndex = int.Parse(command[0]);
                long flyLenght = long.Parse(command[2]);
                if(field.Length<= ladybugIndex||ladybugIndex < 0)
                {
                    command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else if (field[ladybugIndex] == 0)
                {
                    command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else if (field[ladybugIndex] == 1&& flyLenght!=0)
                {
                    long index = GetLadibuxNextIndex(ladybugIndex, command[1], flyLenght, field);
                    field[ladybugIndex] = 0;
                    if (index < 0 || index > field.Length)
                    {
                        command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        field[index] = 1;
                    }
                }
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", field.Select(x => x)));
        }

        private static long GetLadibuxNextIndex(long index, string directory, long lenght, int[] arr)
        {
            long ladybugFlyingIndex = -1;
            long nextIndex = index;
            bool findIndexToLand = false;
            if (directory == "left")
            {
                while (!findIndexToLand)
                {
                    if(nextIndex >= 0 && nextIndex < arr.Length)
                    {
                        if (arr[nextIndex] == 0)
                        {
                            findIndexToLand = true;
                            ladybugFlyingIndex = nextIndex;
                        }
                        else
                        {
                            nextIndex -= lenght;
                        }
                    }
                    else
                    {
                        findIndexToLand = true;
                    }
                } 
            }
            else
            {
                nextIndex += lenght;
                while (!findIndexToLand)
                {
                    if (nextIndex >= 0 && nextIndex < arr.Length)
                    {
                        if (arr[nextIndex] == 0)
                        {
                            findIndexToLand = true;
                            ladybugFlyingIndex = nextIndex;
                        }
                        else
                        {
                            nextIndex += lenght;
                        }
                    }
                    else
                    {
                        findIndexToLand = true;
                    }
                }
            }
            return ladybugFlyingIndex;
        }
    }
}

