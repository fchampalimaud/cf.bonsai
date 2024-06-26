using Bonsai;
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Xml.Serialization;
using Python.Runtime;
using OpenCV.Net;

namespace CF.Scripting.Python
{
    /// <summary>
    /// Converts a python object into an integer value <see cref="PyObject"/>
    /// </summary>
    [Combinator]
    [Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class ToMat
    {
        public IObservable<Mat> Process(IObservable<PyObject> source)
        {
            return source.Select(value =>
            {
          
                Console.WriteLine(value[0].GetPythonType());

                float[] input_arr = value.As<float[]>();

                Mat output = new Mat(input_arr.Length, 1, Depth.F32, 1);

                for (int i = 0; i < input_arr.Length; i++)
                {
                    output[i, 0] = new Scalar(input_arr[i], 0, 0, 0);
                }

                return output;


            });
        }
    }
}
