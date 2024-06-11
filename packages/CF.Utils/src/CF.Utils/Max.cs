using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using OpenCV.Net;


namespace CF.Utils
{

    [Combinator]
    //[Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class Max
    {

        public IObservable<IplImage> Process(IObservable<Tuple<IplImage, IplImage>> source)
        {
            return source.Select(input =>
            {
                IplImage maxMat = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(input.Item1, input.Item2, maxMat);
                return maxMat;
            });
        }

        public IObservable<IplImage> Process(IObservable<Tuple<IplImage, IplImage, IplImage>> source)
        {
            return source.Select(input =>
            {
                IplImage maxMat0 = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(input.Item1, input.Item2, maxMat0);
                IplImage maxMat = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(input.Item3, maxMat0, maxMat);

                return maxMat;
            });
        }

        public IObservable<IplImage> Process(IObservable<Tuple<IplImage, IplImage, IplImage, IplImage>> source)
        {
            return source.Select(input =>
            {
                IplImage maxMat0 = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(input.Item1, input.Item2, maxMat0);
                IplImage maxMat1 = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(input.Item2, input.Item3, maxMat1);
                IplImage maxMat = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Max(maxMat0, maxMat1, maxMat);
                return maxMat;
            });
        }

    }
}