using System;
using OpenCvSharp;

namespace Ex6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoCapture capture = new VideoCapture(@"Resources/video.mp4");
            Mat frame = new Mat();

            BackgroundSubtractorKNN subtractor = BackgroundSubtractorKNN.Create(500, 400, false);
            Mat fgmask = new Mat();

            Mat dst = new Mat();

            while (true)
            {
                if (capture.PosFrames == capture.FrameCount)
                {
                    break;
                }

                capture.Read(frame);
                subtractor.Apply(frame, fgmask);

                Cv2.CvtColor(fgmask, fgmask, ColorConversionCodes.GRAY2BGR);
                Cv2.HConcat(frame, fgmask, dst);

                Cv2.ImShow("dst", dst);
                if (Cv2.WaitKey(33) == (char)27)
                {
                    break;
                }
            }

            capture.Release();
            Cv2.DestroyAllWindows();
        }
    }
}