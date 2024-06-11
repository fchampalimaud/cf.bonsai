using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Xml.Serialization;
using Python.Runtime;
using Python;

namespace CF.Scripting.Python
{
    /// <summary>
    /// Converts a python object into an integer value <see cref="PyObject"/>
    /// </summary>
    [Combinator]
    [Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class ToDoubleArray
    {
        public IObservable<double[]> Process(IObservable<PyObject> source)
        {
            return source.Select(value => 
            {
                double[] pydata = value.As<double[]>();
                return pydata;
            });
        }
    }
}
