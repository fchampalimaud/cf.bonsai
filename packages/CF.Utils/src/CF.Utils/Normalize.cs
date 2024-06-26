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
    //[Description("Normalizes the pixel values of an image to [0,1] range. It fixes a bug with the Normalize from the Vision package.")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class Normalize : Transform<IplImage, IplImage>
    {
        public override IObservable<IplImage> Process(IObservable<IplImage> source)
        {
            return source.Select(input =>
            {
                var output = new IplImage(input.Size, IplDepth.F32, input.Channels);
                double min;
                double max;
                Point minLoc;
                Point maxLoc;
                CV.MinMaxLoc(input, out min, out max, out minLoc, out maxLoc);
                var range = max - min;
                var scale = range > 0 ? 1.0 / range : 0;
                var shift = range > 0 ? -min * scale : 0;
                CV.ConvertScale(input, output, scale, shift);
                return output;
            });
        }
            
    }
}