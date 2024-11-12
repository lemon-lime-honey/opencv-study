using System;
using OpenCvSharp;

namespace Ex5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/image.jpeg");
            Mat gray = new Mat(src.Size(), MatType.CV_8UC1);
            Mat binary = new Mat(src.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(gray, binary, 127, 255, ThresholdTypes.Otsu);

            Cv2.ImShow("binary", binary);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}