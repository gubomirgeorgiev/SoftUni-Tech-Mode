using System;

namespace P09MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
                while (text.IndexOf(pattern)!= text.LastIndexOf(pattern)&& pattern.Length > 0)
                {
                    byte first = byte.Parse(text.IndexOf(pattern).ToString());
                    byte last = byte.Parse(text.LastIndexOf(pattern).ToString());
                    Console.WriteLine("Shaked it.");
                    text = text.Remove(last, pattern.Length);
                    text = text.Remove(first, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
