using System;

namespace P18DifferentntegersSize
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputInteger = Console.ReadLine();
            sbyte svyteValue;
            byte byteValue;
            short shortValue;
            ushort ushortValue;
            int intValue;
            uint uintValue;
            long longValue;
            if (long.TryParse(inputInteger, out longValue)) {
                Console.WriteLine("{0} can fit in:", inputInteger.ToString());
            if (sbyte.TryParse(inputInteger, out svyteValue))
            {
                Console.WriteLine("* sbyte");
            }
            if (byte.TryParse(inputInteger, out byteValue))
            {
                Console.WriteLine("* byte");
            }
            if (short.TryParse(inputInteger, out shortValue))
            {
                Console.WriteLine("* short");
            }
            if (ushort.TryParse(inputInteger, out ushortValue))
            {
                Console.WriteLine("* ushort");
            }
            if (int.TryParse(inputInteger, out intValue))
            {
                Console.WriteLine("* int");
            }
            if (uint.TryParse(inputInteger, out uintValue))
            {
                Console.WriteLine("* uint");
            }
            if (long.TryParse(inputInteger, out longValue))
            {
                Console.WriteLine("* long");
            }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", inputInteger);
            }
        }
    }
}