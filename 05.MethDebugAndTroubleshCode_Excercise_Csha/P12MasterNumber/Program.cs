using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12MasterNumber
{
    class Program
    {
        static bool IsPalindrome(int num, int numberChecker)
        {
            bool output = false;
            int dig = 0;
            int revDigit = 0;
            while (num > 0)
            {
                dig = num % 10;
                revDigit = revDigit * 10 + dig;
                num = num / 10;
                if(numberChecker == revDigit)
                {
                    output = true;
                }
            }
            return output;
        }

        static int SumOfDigits(int num)
        {
            int sumDigits = 0;
            while (num > 0)
            {
                sumDigits += num % 10;
                num = num / 10;
            }
            return sumDigits;
        }

        static bool CheckIfHoldsEvenNumber (int num)
        {
            bool holdsEvenNumber = false;
            int digit = 0;
            while (num>0)
            {
                digit = num % 10;
                if (digit ==0|| digit==2|| digit==4|| digit==6|| digit==8)
                {
                    holdsEvenNumber = true;
                }
                num = num / 10;
            }
            return holdsEvenNumber;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i=232; i <= number; i++)
            {
                if (IsPalindrome(i,i) == true)
                {
                    if (SumOfDigits(i) % 7 == 0)
                    {
                        if (CheckIfHoldsEvenNumber(i) == true)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
