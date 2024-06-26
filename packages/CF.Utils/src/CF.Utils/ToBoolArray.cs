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
    public class ToBoolArray
    {

        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2 };
                return output;
            });
        }

        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2, value.Item3 };
                return output;
            });
        }

        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool, bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2, value.Item3, value.Item4 };
                return output;
            });
        }


        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool, bool, bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
                return output;
            });
        }


        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool, bool, bool, bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
                return output;
            });
        }

        public IObservable<bool[]> Process(IObservable<Tuple<bool, bool, bool, bool, bool, bool, bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
                return output;
            });
        }


        public IObservable<bool[]> Process(IObservable<IList<bool>> source)
        {
            return source.Select(value =>
            {
                bool[] output = new bool[value.Count];

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
