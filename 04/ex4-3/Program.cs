﻿using System;
using OpenCvSharp;

namespace ex4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/image.jpeg", ImreadModes.ReducedColor2);

            Cv2.NamedWindow("src", WindowFlags.GuiExpanded);
            Cv2.SetWindowProperty("src", WindowPropertyFlags.Fullscreen, 0);
            Cv2.ImShow("src", src);
            Cv2.WaitKey(0);
            Cv2.DestroyWindow("src");
        }
    }
}