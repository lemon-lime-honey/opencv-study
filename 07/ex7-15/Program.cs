﻿using System;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Dnn;

namespace Ex7_15
{
    class Program
    {
        static void Main(string[] args)
        {
            const string prototxt = "../../models/caffe_model/bvlc_googlenet.prototxt";
            const string caffeModel = "../../models/caffe_model/bvlc_googlenet.caffemodel";
            string[] classNames = File.ReadAllLines("../../models/caffe_model/bvlc_googlenet.txt");

            Mat image = Cv2.ImRead(@"Resources/umbrella.jpg");
            Net net = Net.ReadNetFromCaffe(prototxt, caffeModel);
            Mat inputBlob = CvDnn.BlobFromImage(
                image, 1, new Size(224, 224), new Scalar(104, 117, 123),
                swapRB: false, crop: false
            );

            net.SetInput(inputBlob);
            Mat outputBlobs = net.Forward("prob");

            Cv2.MinMaxLoc(outputBlobs, out _, out double classProb, out _, out Point classID);
            Console.WriteLine($"Class ID : {classID.X}");
            Console.WriteLine($"Class Name : {classNames[classID.X]}");
            Console.WriteLine($"Probability : {classProb:P2}");
        }
    }
}