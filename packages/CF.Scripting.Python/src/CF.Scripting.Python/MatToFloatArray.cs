using Bonsai;
using System;
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
    public class MatToFloatArray
    {
        public IObservable<float[,]> Process(IObservable<Mat> source)
        {
            return source.Select(value => 
            {
                return this.ConvertMatToFloatArray(value);               
            });
        }

        private float[,] ConvertMatToFloatArray(Mat value)
        {
            float[,] output = new float[value.Rows, value.Cols];

            for (int i = 0; i < value.Rows; i++)
            {
                for (int j = 0; j < value.Cols; j++)
                {
                    output[i, j] = (float)value[i, j].Val0;
                }
            }
            return output;
        }


    }



}
