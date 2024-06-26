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
    //[Description("Returns the pixel coordinates of the pixel with the highest intensity")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class MinMaxLoc 
    {

        public IObservable<Tuple<double, double, Point, Point>> Process(IObservable<IplImage> source)
        {
            return source.Select(input =>
            {
                CV.MinMaxLoc(input, out double min, out double max, out Point minLoc, out Point maxLoc);

                return Tuple.Create(min, max, minLoc, maxLoc);
                
            });
        }

    }

}