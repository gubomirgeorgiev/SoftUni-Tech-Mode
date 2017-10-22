using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();
            Console.WriteLine(IsInside(r1,r2) ? "Inside" : "Not inside");
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            var isInLeft = first.Left >= second.Left;
            var isInRight = first.Right <= second.Right;
            var isInsideHorizontal = isInLeft && isInRight;
            var isInTop = first.Top <= second.Top;
            var isInBottom = first.Bottom>= second.Bottom;
            var isInsideVertical = isInTop && isInBottom;
            return isInsideHorizontal && isInsideVertical;
        }


        public static Rectangle ReadRectangle()
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = sizes.First(),
                Top = sizes.Skip(1).First(),
                Width = sizes.Skip(2).First(),
                Height = sizes.Skip(3).First()
            };
            return rectangle;
        }
    }
}
