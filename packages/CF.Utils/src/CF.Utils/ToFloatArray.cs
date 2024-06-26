using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;


namespace CF.Utils
{

    [Combinator]
    //[Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class ToFloatArray
    {

        public IObservable<float[]> Process(IObservable<Tuple<float, float>> source)
        {
            return source.Select(value =>
            {

                float[] output = new float[] { value.Item1, value.Item2 };
                return output;
            });
        }

        public IObservable<float[]> Process(IObservable<Tuple<float, float, float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[] { value.Item1, value.Item2, value.Item3 };
                return output;
            });
        }

        public IObservable<float[]> Process(IObservable<Tuple<float, float, float, float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[] { value.Item1, value.Item2, value.Item3, value.Item4 };
                return output;
            });
        }


        public IObservable<float[]> Process(IObservable<Tuple<float, float, float, float, float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
                return output;
            });
        }


        public IObservable<float[]> Process(IObservable<Tuple<float, float, float, float, float, float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
                return output;
            });
        }

        public IObservable<float[]> Process(IObservable<Tuple<float, float, float, float, float, float, float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
                return output;
            });
        }

        public IObservable<float[]> Process(IObservable<IList<float>> source)
        {
            return source.Select(value =>
            {
                float[] output = new float[value.Count];

                int count = 0;
                foreach (var number in value)
                {
                    count += 1;
                    output[count] = number;
                }

                return output;
            });
        }

    }
}