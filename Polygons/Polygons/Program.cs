using Polygons.Library;
using System;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using a concrete class 
            var square = new Square(5);
            DisplayPolygon("Square",square);

            //Using an abstract class
            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            //Using an interface
            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);
        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            Console.WriteLine($"{polygonType} Number of Sides : {polygon.NumberOfSides}");
            Console.WriteLine($"{polygonType} Side Length : {polygon.SideLength}");
            Console.WriteLine($"{polygonType} Perimeter : {polygon.GetPerimeter()}");
            Console.WriteLine($"{polygonType} Area : {polygon.GetArea()}");
            Console.WriteLine("--------------------");
        }
    }
}
