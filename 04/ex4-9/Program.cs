using System;
using OpenCvSharp;

namespace ex4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat one = new Mat(@"Resources/image1.jpeg");
            Mat two = new Mat(@"Resources/image2.jpeg");
            Mat three = new Mat(@"Resources/image3.jpeg");
            Mat four = new Mat(@"Resources/image4.jpeg");

            Mat left = new Mat();
            Mat right = new Mat();
            Mat dst = new Mat();

            Cv2.VConcat(new Mat[] { one, three }, left);
            Cv2.VConcat(new Mat[] { two, four }, right);
            Cv2.HConcat(new Mat[] { left, right }, dst);

            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}