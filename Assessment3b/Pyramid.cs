using System;

namespace Assessment3b
{
    public class Pyramid : Building
    {
        public Pyramid()
        {

        }

        public Pyramid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double GetFirstFloorArea()
        {
            return Length * Width;
        }

        public override double GetVolume()
        {
            return Length * Width * Height / 3;
        }
    }
}
