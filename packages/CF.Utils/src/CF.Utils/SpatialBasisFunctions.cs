using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace CF.Utils
{
    [Combinator]
    [Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    
    public class SpatialBasisFunctions
    {
        
        public int NumberOfBasisFunctions { get; set; }

        public float GaussianStd { get; set; }

        public float InputMin { get; set; }

        public float InputMax { get; set; }

        public bool IsCircular { get; set; }

        public bool ClearZeroValue { get; set; }


        public IObservable<float[]> Process(IObservable<float> source)
        {
            return source.Select(value =>
            {
                return Sparsify(value);
            });
        }


        public IObservable<float[]> Process(IObservable<double> source)
        {
            return source.Select(value =>
            {
                return Sparsify((float) value);
            });
        }


        public IObservable<float[]> Process(IObservable<int> source)
        {
            return source.Select(value =>
            {
                return Sparsify(value);
            });
        }


        private float[] Sparsify(float x)
        {
            float[] y = new float[NumberOfBasisFunctions];

            if (x == 0 && ClearZeroValue)
            {
                for (int i = 0; i < NumberOfBasisFunctions; i++)
                {
                    y[i] = 0;
                }
                return y;
            }

            for (int i = 0; i < NumberOfBasisFunctions; i++)
            {
                float bf_mean = i * (InputMax - InputMin) / (NumberOfBasisFunctions - 1) + InputMin;
                y[i] = (float)(1 / (GaussianStd * Math.Sqrt(2 * Math.PI)) * Math.Exp(-Math.Pow((x - bf_mean), 2) / (2 * GaussianStd * GaussianStd)));
            }

            return y;
        }

    }
}
