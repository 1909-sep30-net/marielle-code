namespace ShapesApp.Library
{
    //this class has implementations for all members IShape specifies
    public class Rectangle: TwoDShape, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
        public int Sides => 2;
        public double Perimeter => Length * 2 + Width * 2;
        public int Dimensions => 2;
    
        public bool Validate()
        {
            if (Length <= 0)
            {
                return false;
            }
            if (Width <= 0)
            {
                return false;
            }
            return true;
        }
    }
}