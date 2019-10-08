using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    static class Program
    {
        static void Main(string[] args)
        {
            double length;
            string input;
            do
            {
                Console.WriteLine("Enter a length: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out length));

            double width;
            do
            {
                Console.WriteLine("Enter a width: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out width));

            /* var r = new Rectangle();
            r.Length = length;
            r.Width = width;*/
            // Property initializer
            var r = new Rectangle{
                Length = length,
                Width = width
            };
            r.PrintRectangle();
            var circle = new ColorCircle(4,"black");
            Console.WriteLine(ShapeDetails(circle));
            
        }

        public static void PrintRectangle(this Rectangle r){
            Console.WriteLine($"({r.Length})x({r.Width}) rectangle");
        }

        public static string ShapeDetails(IShape shape) => $"area: {shape.Area}, {shape.Sides}";
    }
}
