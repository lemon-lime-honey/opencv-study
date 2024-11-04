using System;
using OpenCvSharp;

namespace ex4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoCapture capture = new VideoCapture(@"Resources/video.mp4");
            Mat frame = new Mat();

            while (true)
            {
                if (capture.PosFrames == capture.FrameCount) capture.Open(@"Resources/video.mp4");

                capture.Read(frame);

                Cv2.ImShow("VideoFrame", frame);

                if (Cv2.WaitKey(15) == 'q') break;
            }

            capture.Release();
            Cv2.DestroyAllWindows();
        }
    }
}