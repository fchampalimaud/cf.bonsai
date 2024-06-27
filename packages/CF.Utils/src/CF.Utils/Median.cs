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
    public class Median
    {

        public IObservable<int> Process(IObservable<int[]> source)
        {
            return source.Select(value =>
            {
                int idx = value.Length / 2;
                Array.Sort(value);
                return value[idx];
            });
        }



        public IObservable<float> Process(IObservable<float[]> source)
        {
            return source.Select(value =>
            {
                int idx = value.Length / 2;
                Array.Sort(value);
                return value[idx];
            });
        }


        public IObservable<double> Process(IObservable<double[]> source)
        {
            return source.Select(value =>
            {
                int idx = value.Length / 2;
                Array.Sort(value);
                return value[idx];
            });
        }



    }
}