﻿using System;
using OpenCvSharp;

namespace Ex7_3
{
    class Program
    {
        static Tuple<float[], int[]> LoadTrainData(string imagePath, string labelPath, int length)
        {
            using (FileStream imageData = new FileStream(imagePath, FileMode.Open))
            using (FileStream labelData = new FileStream(labelPath, FileMode.Open))
            using (BinaryReader imageBinary = new BinaryReader(imageData))
            using (BinaryReader labelBinary = new BinaryReader(labelData))
            {
                imageBinary.ReadBytes(16);
                labelBinary.ReadBytes(8);

                float[] image = new float[length * 784];
                int[] label = new int[length];

                for (int dataIndex = 0; dataIndex < length; ++dataIndex)
                {
                    for (int i = 0; i < 784; ++i)
                    {
                        byte img = imageBinary.ReadByte();
                        image[dataIndex * 784 + i] = (float)img;
                    }
                    byte lb = labelBinary.ReadByte();
                    label[dataIndex] = (int)lb;
                }
                return new Tuple<float[], int[]>(image, label);
            }
        }

        static void Main(string[] args)
        {
            Tuple<float[], int[]> train = LoadTrainData("../../models/fashion-mnist/train-images-idx3-ubyte", "../../models/fashion-mnist/train-labels-idx1-ubyte", 60000);
            Tuple<float[], int[]> test = LoadTrainData("../../models/fashion-mnist/t10k-images-idx3-ubyte", "../../models/fashion-mnist/t10k-labels-idx1-ubyte", 10000);

            Mat trainX = Mat.FromPixelData(60000, 784, MatType.CV_32F, train.Item1);
            Mat trainY = Mat.FromPixelData(1, 60000, MatType.CV_32S, train.Item2);
            Mat testX = Mat.FromPixelData(10000, 784, MatType.CV_32F, test.Item1);
            Mat testY = Mat.FromPixelData(1, 10000, MatType.CV_32S, test.Item2);
        }
    }
}