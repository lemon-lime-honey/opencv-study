using System;
using OpenCvSharp;

namespace ex3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenCvSharp.Range range = new OpenCvSharp.Range(0, 100);
            Console.WriteLine($"{range.Start}, {range.End}");
        }
    }
}
