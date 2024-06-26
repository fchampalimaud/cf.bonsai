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
    [Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]

    public class TemporalBasisFunctions
    {

        public int NumberOfBasisFunctions { get; set; }

        public int SamplesPerBasisFunction { get; set; }

        private List<Mat> buffer = new List<Mat>();


        public IObservable<Mat> Process(IObservable<Mat> source)
        {
            return source.Select(value =>
            {
                return this.Sparsify(value);

            }).Where(value =>
            {
                // return values only when the buffer is full
                return buffer.Count >= NumberOfBasisFunctions * SamplesPerBasisFunction;
            });


        }



        public IObservable<float[]> Process(IObservable<float[]> source)
        {
            return source.Select(value =>
            {
                Console.WriteLine("[MatToFloatArray]: 1");
                Mat mvalue = FloatArrayToMat(value);
                Console.WriteLine("[MatToFloatArray]: 2");
                Mat moutput = this.Sparsify(mvalue);
                Console.WriteLine("[MatToFloatArray]: 3");
                return MatToFloatArray(moutput);

            }).Where(value =>
            {
                // return values only when the buffer is full
                return buffer.Count >= NumberOfBasisFunctions * SamplesPerBasisFunction;
            });


        }



        public IObservable<float[]> Process(IObservable<float> source)
        {
            return source.Select(value =>
            {
                Mat mvalue = new Mat(1, 1, Depth.F32, 1);
                mvalue.Set(new Scalar(value, 0, 0, 0));
                Mat moutput = this.Sparsify(mvalue);

                return MatToFloatArray(moutput);

            }).Where(value =>
            {
                // return values only when the buffer is full
                return buffer.Count >= NumberOfBasisFunctions * SamplesPerBasisFunction;
            });

        }





        private Mat Sparsify(Mat value)
        {
            Console.WriteLine("[MatToFloatArray]: 2.0");
            buffer.Add(value);
            if (buffer.Count > NumberOfBasisFunctions * SamplesPerBasisFunction)
            {
                buffer.RemoveAt(0);
            }

            Console.WriteLine("[MatToFloatArray]: 2.1");
            int outputSize = NumberOfBasisFunctions * value.Rows;
            Mat output = new Mat(outputSize, 1, Depth.F32, 1);


            Console.WriteLine($"[MatToFloatArray] BUFFER COUNT: {buffer.Count},     OUTPUT SIZE: {outputSize}");
            int idx = 0;
            for (int j = 0; j < buffer.Count; j = j + SamplesPerBasisFunction)
            {

                Console.WriteLine($"[MatToFloatArray] ROWS:  {buffer[j].Rows}");
                for (int i = 0; i < buffer[j].Rows; i++)
                {
                    Console.WriteLine($"[MatToFloatArray] i: {i},  idx: {idx}");
                    output[idx + i, 0] = buffer[j][i];
                }

                idx = idx + buffer[j].Rows;
            }
            
            Console.WriteLine("[MatToFloatArray]: 2.3");
            return output;

        }


        private float[] MatToFloatArray(Mat value)
        {
            Console.WriteLine("[MatToFloatArray]: 3.0");
            float[] output = new float[value.Rows];
            Console.WriteLine("[MatToFloatArray]: 3.1");
            for (int i = 0; i < value.Rows; i++)
            {
                output[i] = (float)value[i, 0].Val0;
            }
            Console.WriteLine("[MatToFloatArray]: 3.2");
            return output;
        }

        private Mat FloatArrayToMat(float[] value)
        {
            Console.WriteLine("[MatToFloatArray]: 1.0");

            Mat output = new Mat(value.Length, 1, Depth.F32, 1);

            Console.WriteLine("[MatToFloatArray]: 1.1");
            for (int i = 0; i < value.Length; i++)
            {
                output[i, 0] = new Scalar(value[i],0,0,0);
            }

            return output;
        }



    }
}
