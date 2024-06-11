using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Xml.Serialization;
using Python.Runtime;

namespace CF.Scripting.Python
{
    /// <summary>
    /// Converts a python object into an integer value <see cref="PyObject"/>
    /// </summary>
    [Combinator]
    [Description("")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class ToFloatArray
    {
        public IObservable<float[]> Process(IObservable<PyObject> source)
        {
            return source.Select(value => 
            {
                return value.As<float[]>();
            });
        }
    }
}
