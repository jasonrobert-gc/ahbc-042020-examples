using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public class BuildingProgram
    {
        public static Pyramid BuildGreatPyramid()
        {
            //var pyramid = new Pyramid();
            //pyramid.Height = 750;
            //pyramid.Width = 450;
            //pyramid.Length = 800;
            //return pyramid;

            return new Pyramid(800, 450, 750);
        }

        public static string DescribeBuilding(Building building)
        {
            //return $"volume {building.GetVolume()}, first floor area {building.GetFirstFloorArea()}";

            var volume = building.GetVolume();
            var area = building.GetFirstFloorArea();
            return $"volume {volume}, first floor area {area}";
        }
    }
}
