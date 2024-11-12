using System;
using OpenCvSharp;

namespace Ex5_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead(@"Resources/image.jpeg", ImreadModes.ReducedGrayscale4);
            Mat kernel = new Mat(3, 3, MatType.CV_32FC1, new float[] {
                1f, 1f, 1f,
                1f, 1f, 1f,
                1f, 1f, 1f,
            });
            Mat boxFilter = new Mat();
            Mat filter2D = new Mat();
            Mat dst = new Mat();

            Cv2.BoxFilter(src, boxFilter, MatType.CV_8UC1, new Size(3, 3), normalize: false);
            Cv2.Filter2D(src, filter2D, MatType.CV_8UC1, kernel);
            Cv2.VConcat(boxFilter, filter2D, dst);

            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}