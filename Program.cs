using Google.Cloud.Vision.V1;
using System;

namespace VisionApiDemo
{
    class Program
    {   
        static void Main(string[] args)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromUri("gs://cloud-samples-data/vision/using_curl/shanghai.jpeg");
            var labels = client.DetectLabels(image);

            Console.WriteLine("Labels (and confidence score):");
            Console.WriteLine(new String('=', 30));

            foreach (var label in labels)
            {
                Console.WriteLine($"{label.Description} ({(int)(label.Score * 100)}%)");
            }
        }
    }
}
