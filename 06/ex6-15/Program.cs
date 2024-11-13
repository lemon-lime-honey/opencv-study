using System;
using OpenCvSharp;

namespace Ex6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/hats.jpg");
            Mat templ = Cv2.ImRead(@"Resources/hat.jpg");
            Mat dst = src.Clone();
            Mat result = new Mat();

            Cv2.MatchTemplate(src, templ, result, TemplateMatchModes.CCoeffNormed);

            Cv2.MinMaxLoc(result, out double minVal, out double maxVal, out Point minLoc, out Point maxLoc);

            Cv2.Rectangle(dst, new Rect(maxLoc, templ.Size()), new Scalar(0, 0, 255), 4);

            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}