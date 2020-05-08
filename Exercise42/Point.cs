using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise42
{
    public class Point
    {
        //// You NEVER want to have public fields in a class!
        //// Properties - Long hand version
        //private int _y;
        //public int Y { get { return _y; } set { _y = value; } }

        //private int _x;
        //public int X { get { return _x; } set { _x = value; } }

        // Properties are a way to provide consumers (code that uses your class) access
        // to internal values BUT provided a buffer to allow you to modify in the future.

        // Properties - Short hand version
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public int GetX()
        //{
        //    // Add some magic stuff
        //    return _x;
        //}
        
        //public void SetX(int x)
        //{
        //    _x = x;
        //}

        //public int GetY()
        //{
        //    // What magic stuff?  I dunno.  Whatever I want.
        //    // For example, I could log whenever accessed, etc.
        //    return _y;
        //}

        //public void SetY(int y)
        //{
        //    _y = y;
        //}
    }
}
