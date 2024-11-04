using System;
using OpenCvSharp;

namespace ex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/image.jpeg", ImreadModes.ReducedColor2);
            Console.WriteLine(src);
        }
    }
}