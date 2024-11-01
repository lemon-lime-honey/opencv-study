using System;
using OpenCvSharp;

namespace ex3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            RotatedRect rotatedRect = new RotatedRect(new Point2f(100f, 100f), new Size2f(100, 100), 45f);

            Console.WriteLine(rotatedRect.BoundingRect());
            Console.WriteLine(rotatedRect.Points().Length);
            Console.WriteLine(rotatedRect.Points()[0]);
        }
    }
}
