using System;
using System.Text;

namespace P06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            Console.WriteLine(GetNumbersSum(firstNum, secondNum)); 
        }

        private static StringBuilder GetNumbersSum(string one, string two)
        {
            int num = 0;
            int residual = 0;
            int oneLenght = one.Length;
            int twoLenght = two.Length;
            StringBuilder output = new StringBuilder();
            if (one.Length.CompareTo(two.Length) > 0)
            {
                while (twoLenght-->0)
                {
                    oneLenght--;
                    residual = ((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10)+num;
                    if (residual >= 10)
                    {
                        residual = (((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10) + num) % 10;
                        num = (int)(Math.Floor((double)((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10) + num) / 10);
                    }
                    else
                    {
                        num = (int)Math.Floor((double)(int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) / 10);
                    }
                    output.Insert(0,residual.ToString());
                }
                while (oneLenght-- >0)
                {
                         residual = (int.Parse(one[oneLenght].ToString()) + num)%10;
                        num = (int)Math.Floor((double)(int.Parse(one[oneLenght].ToString()) + num) / 10);
                        output.Insert(0,residual.ToString());
                }
                if (num > 0)
                {
                    output.Insert(0, num.ToString());
                }
            }
            else if (one.Length.CompareTo(two.Length) < 0)
            {
                while (oneLenght-- > 0)
                {
                    twoLenght--;
                    residual = ((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10) + num;
                    if (residual >= 10)
                    {
                        residual = (((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10) + num) % 10;
                        num = (int)(Math.Floor((double)((int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) % 10) + num) / 10);
                    }
                    else
                    {
                        num = (int)Math.Floor((double)(int.Parse(one[oneLenght].ToString()) + int.Parse(two[twoLenght].ToString())) / 10);
                    }
                    output.Insert(0, residual.ToString());
                }
                while(twoLenght-- > 0)
                {
                    residual = (int.Parse(two[twoLenght].ToString()) + num)%10;
                    num = (int)Math.Floor((double)(int.Parse(two[twoLenght].ToString()) + num) / 10);
                    output.Insert(0, residual.ToString());
                }
                if (num > 0)
                {
                    output.Insert(0, num.ToString());
                }
            }
            else
            {
                while (oneLenght-- > 0)
                {
                    residual = ((int.Parse(one[oneLenght].ToString()) + int.Parse(two[oneLenght].ToString())) % 10) + num;
                    if (residual >= 10)
                    {
                        residual = (((int.Parse(one[oneLenght].ToString()) + int.Parse(two[oneLenght].ToString())) % 10) + num) % 10;
                        num = (int)(Math.Floor((double)((int.Parse(one[oneLenght].ToString()) + int.Parse(two[oneLenght].ToString())) % 10) + num) / 10);
                    }
                    else
                    {
                        num = (int)Math.Floor((double)(int.Parse(one[oneLenght].ToString()) + int.Parse(two[oneLenght].ToString())) / 10);
                    }
                    output.Insert(0, residual.ToString());
                }
                if (num > 0)
                {
                    output.Insert(0, num.ToString());
                }
            }
            while (int.Parse(output[0].ToString()) < 1)
            {
                output.Remove(0, 1);
            }
            return output;
        }
    }
}
