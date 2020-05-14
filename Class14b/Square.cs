namespace Class14b
{
    public class Square : IRectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int GetArea()
        {
            return Length * Width;
        }
    }
}
