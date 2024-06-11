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
    //[Description("Takes the pixel-by-pixel minimum between two IplImages images")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class Min
    {

        public IObservable<IplImage> Process(IObservable<Tuple<IplImage, IplImage>> source)
        {
            return source.Select(input =>
            {

                IplImage minMat = new IplImage(input.Item1.Size, input.Item1.Depth, 1);
                CV.Min(input.Item1, input.Item2, minMat);
                return minMat;

                /*
                                IplImage out_img = new IplImage(input.Item1.Size, input.Item1.Depth, 1);

                                for (int i = 0; i < out_img.Size.Height; i++)
                                    for (int j = 0; j < out_img.Size.Width; j++)
                                        out_img[i, j] = (input.Item1[i, j].Val0 < input.Item2[i, j].Val0) ? input.Item1[i, j] : input.Item2[i, j];

                                return out_img;
                */
            });
        }

    }
}