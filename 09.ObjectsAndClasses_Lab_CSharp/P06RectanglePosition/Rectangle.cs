using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RectanglePosition
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right
        {
            get { return Left + Width; }
        }
        //SAme as above!!!
        public int Bottom => Top - Height;

        public int CalcArea()
        {
            return Width * Height;
        }

      
    }
}
