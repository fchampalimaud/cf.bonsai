﻿using Bonsai;
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
    public class ToDoubleArray
    {

        public IObservable<double[]> Process(IObservable<Tuple<double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2 };
                return output;
            });
        }

        public IObservable<double[]> Process(IObservable<Tuple<double, double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2, value.Item3 };
                return output;
            });
        }

        public IObservable<double[]> Process(IObservable<Tuple<double, double, double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2, value.Item3, value.Item4 };
                return output;
            });
        }


        public IObservable<double[]> Process(IObservable<Tuple<double, double, double, double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
                return output;
            });
        }


        public IObservable<double[]> Process(IObservable<Tuple<double, double, double, double, double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
                return output;
            });
        }

        public IObservable<double[]> Process(IObservable<Tuple<double, double, double, double, double, double, double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
                return output;
            });
        }



        public IObservable<double[]> Process(IObservable<IList<double>> source)
        {
            return source.Select(value =>
            {
                double[] output = new double[value.Count];

                int count = 0;
                foreach (var number in value)
                {
                    count += 1;
                    output[count] = number;
                }

                return output;
            });
        }


        public IObservable<double[]> Process(IObservable<Mat> source)
        {
            return source.Select(value =>
            {

                double[] output = new double[value.Rows * value.Cols];

                int count = 0;
                for (int i = 0; i < value.Rows; i++)
                {
                    for (int j = 0; j < value.Cols; j++)
                    {
                        output[count] = value[i, j].Val0;
                        count++;
                    }
                }
                return output;

            });
        }

    }
}