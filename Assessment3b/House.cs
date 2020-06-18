namespace Assessment3b
{
    public class House : Building
    {
        public House()
        {

        }

        public House(double length, double width, double height)
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
            return Length * Width * Height;
        }
    }
}
