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
    public class ToMat
    {


        public IObservable<Mat> Process(IObservable<int[]> source)
        {
            return source.Select(value =>
            {
                Mat output = new Mat(value.Length, 1, Depth.S32, 1);

                for (int i = 0; i < value.Length; i++)
                {
                    output[i,0] = new Scalar(value[i], 0, 0, 0);
                }

                return output;
            });
        }



        public IObservable<Mat> Process(IObservable<float[]> source)
        {
            return source.Select(value =>
            {
                Mat output = new Mat(value.Length, 1, Depth.F32, 1);

                for (int i = 0; i < value.Length; i++)
                {
                    output[i, 0] = new Scalar(value[i], 0, 0, 0);
                }

                return output;
            });
        }


        public IObservable<Mat> Process(IObservable<double[]> source)
        {
            return source.Select(value =>
            {
                Mat output = new Mat(value.Length, 1, Depth.F64, 1);

                for (int i = 0; i < value.Length; i++)
                {
                    output[i, 0] = new Scalar(value[i], 0, 0, 0);
                }

                return output;
            });
        }



    }
}