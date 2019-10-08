using System;
namespace ShapesApp.Library
{
    
    public class ColorCircle : Circle
    {
        public ColorCircle(double radius, string color) : base(radius) => Color = color;
        public ColorCircle(double radius) : this(radius, "clear")
        {

        }
        public string Color { get; set; }

        public override double Perimeter
        {
            get
            {
                Console.WriteLine("calculating perimeter");
                //return 2 * Math.PI * Radius;
                //uses base class implementation
                return base.Perimeter;
            }
        }
    }
}