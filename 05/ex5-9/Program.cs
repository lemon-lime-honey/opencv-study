using System;
using OpenCvSharp;

namespace Ex5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/image.jpeg");
            Mat gray = new Mat(src.Size(), MatType.CV_8UC1);
            Mat binary = new Mat(src.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.AdaptiveThreshold(gray, binary, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 25, 5);

            Cv2.ImShow("binary", binary);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}