using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace CF.Utils
{
    [Combinator]
    [Description("Repeats a signal a number of times each time with a given delay")]
    [WorkflowElementCategory(ElementCategory.Transform)]

    public class Echo
    {

        public int NumberRepetitions { get; set; }

        public int SampleInterval { get; set; }

        private List<float[]> buffer = new List<float[]>();

        public IObservable<float[]> Process(IObservable<float[]> source)
        {

            // SAMPLE INTERVAL IS NOT CURRENTLY WORKING (and it is assumed to be 1)
            
            return source.Select(value =>
            {
                buffer.Add(value);
                if (buffer.Count > NumberRepetitions * SampleInterval)
                {
                    buffer.RemoveAt(0);
                }

                int outputSize = NumberRepetitions * SampleInterval * value.Length;
                float[] output = new float[outputSize];

                int idx = 0;
                foreach (var elem in buffer)
                {
                    for (int i = 0; i < elem.Length; i++)
                    {
                        output[idx + i] = elem[i];
                    }
                    idx += elem.Length;
                }

                return output;

            });
        }

    }

}
