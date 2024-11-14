﻿using System;
using OpenCvSharp;

namespace Ex5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src1= Cv2.ImRead(@"Resources/image.jpeg");
            Mat dst = new Mat(src1.Size(), MatType.CV_8UC3);

            Cv2.Compare(src1, new Scalar(200, 127, 100), dst, CmpType.GT);

            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}