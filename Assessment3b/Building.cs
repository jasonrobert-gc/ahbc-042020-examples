using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public abstract class Building
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double GetVolume();
        public abstract double GetFirstFloorArea();
    }
}
