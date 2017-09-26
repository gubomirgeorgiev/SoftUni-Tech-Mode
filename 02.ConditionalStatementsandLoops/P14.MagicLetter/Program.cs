using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char lettertwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int secondLetter = alphabet.IndexOf(lettertwo);
            int firstLetter = alphabet.IndexOf(letterOne);
            for (int i= firstLetter; i <= secondLetter; i++)
            {
                for(int j= firstLetter; j <= secondLetter; j++)
                {
                    for (int l= firstLetter; l<=secondLetter; l++)
                    {
                        if (alphabet.IndexOf(letterThree) != l && alphabet.IndexOf(letterThree) != j && alphabet.IndexOf(letterThree) != i)
                        {
                            Console.Write($"{alphabet[i]}{alphabet[j]}{alphabet[l]} ");
                        }
                    }
                }
            }
        }
    }
}
