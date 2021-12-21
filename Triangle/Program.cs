using System;
using System.IO;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle MyTriangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 5));
            Console.WriteLine("Lenght of side AB : " + MyTriangle.SideAB.Lenght.ToString());
            Console.WriteLine("Angle Degree of angle A : " + MyTriangle.GetAngleDegree( MyTriangle.AngleA ).ToString());
            Console.WriteLine("Rectangled? : " +  MyTriangle.Rectangled.ToString());
            Console.WriteLine("Perimeter : " +  Math.Round( MyTriangle.Perimeter, 2 ).ToString());
            Console.WriteLine("Area : " + Math.Round(MyTriangle.Area, 4).ToString());
            Console.WriteLine("Lenght of altitude for Side AB : " + MyTriangle.GetAltitudeLenght(MyTriangle.SideAB).ToString());
            Console.ReadLine();
        }
    }
}