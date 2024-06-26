using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Xml.Serialization;
using Python.Runtime;
using OpenCV.Net;
using System.Runtime.InteropServices;

namespace CF.Scripting.Python
{
    /// <summary>
    /// Represents an operator that gets the value of a variable in the specified
    /// Python module.
    /// </summary>
    [DefaultProperty(nameof(VariableName))]
    [Description("Gets the value of a variable in the specified Python module.")]
    public class GetMat : Source<Mat>
    {
        /// <summary>
        /// Gets or sets the Python module containing the variable.
        /// </summary>
        [XmlIgnore]
        [Description("The Python module containing the variable.")]
        public PyModule Module { get; set; }

        /// <summary>
        /// Gets or sets the name of the variable to get the value of.
        /// </summary>
        [Description("The name of the variable to get the value of.")]
        public string VariableName { get; set; }


        /// <summary>
        /// Gets or sets the name of the variable to get the value of.
        /// </summary>
        [Description("The dimensions of the matrix.")]
        public Size MatSize { get; set; }



        /// <summary>
        /// Gets the value of a variable in the specified Python module and
        /// surfaces it through an observable sequence.
        /// </summary>
        /// <returns>
        /// A sequence containing the value of the Python runtime variable as
        /// a <see cref="PyObject"/>.
        /// </returns>
        public override IObservable<Mat> Generate()
        {
            return RuntimeManager.RuntimeSource.SelectMany(runtime =>
            {
                var module = Module ?? runtime.MainModule;
                return Observable.Return(ConvertToMat(module.Get(VariableName)));
            });
        }

        /// <summary>
        /// Gets the value of a variable in the specified Python module
        /// whenever an observable sequence emits a notification.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the elements in the <paramref name="source"/> sequence.
        /// </typeparam>
        /// <param name="source">
        /// The sequence of notifications used to get the value of the variable.
        /// </param>
        /// <returns>
        /// A sequence of <see cref="PyObject"/> handles representing the value
        /// of the Python runtime variable.
        /// </returns>
        public IObservable<Mat> Generate<TSource>(IObservable<TSource> source)
        {
            return RuntimeManager.RuntimeSource.SelectMany(runtime =>
            {
                return source.Select(_ =>
                {
                    using (Py.GIL())
                    {
                        var module = Module ?? runtime.MainModule;
                        return ConvertToMat(module.Get(VariableName));
                    }
                });
            });
        }

        /// <summary>
        /// Gets the value of the specified variable in each of the Python modules
        /// in an observable sequence.
        /// </summary>
        /// <param name="source">
        /// The sequence of modules from which to get the value of the specified
        /// variable.
        /// </param>
        /// <returns>
        /// A sequence of <see cref="PyObject"/> handles representing the value
        /// of the specified variable for each of the modules in the
        /// <paramref name="source"/> sequence.
        /// </returns>
        public IObservable<Mat> Process(IObservable<PyModule> source)
        {
            return source.Select(module =>
            {
                using (Py.GIL())
                {
                    return ConvertToMat(module.Get(VariableName));
                }
            });
        }

        /// <summary>
        /// Gets the value of the specified variable in the main module of the
        /// Python runtime.
        /// </summary>
        /// <param name="source">
        /// A sequence containing the Python runtime from which to get the
        /// value of the specified variable.
        /// </param>
        /// <returns>
        /// A sequence of <see cref="PyObject"/> handles representing the value
        /// of the specified variable in the main module of the Python runtime.
        /// </returns>
        public IObservable<Mat> Process(IObservable<RuntimeManager> source)
        {
            return source.Select(runtime =>
            {
                using (Py.GIL())
                {
                    return ConvertToMat(runtime.MainModule.Get(VariableName));
                }
            });
        }



        private Mat ConvertToMat(PyObject value)
        {
            var datatype = Depth.U8;
            GCHandle handle = GCHandle.Alloc(value.As<uint[]>(), GCHandleType.Pinned);
            
            string type_str = value[0].GetPythonType().ToString();
            Console.WriteLine(type_str);


            if (type_str.Contains("float")) 
            {
                datatype = Depth.F32;
                handle = GCHandle.Alloc(value.As<double[]>(), GCHandleType.Pinned);
            }
            else if(type_str.Contains("double"))
            {
                datatype = Depth.F64;
                handle = GCHandle.Alloc(value.As<float[]>(), GCHandleType.Pinned);
            }
            else if(type_str.Contains("int"))
            { 
                datatype = Depth.S32;
                handle = GCHandle.Alloc(value.As<int[]>(), GCHandleType.Pinned);
            }

            
            IntPtr pointer;
            try
            {
                pointer = handle.AddrOfPinnedObject();
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }

            Mat output = new Mat(MatSize.Height, MatSize.Width, datatype, 1, pointer, Mat.AutoStep);
            
            /*
            float[] input_arr = value.As<float[]>();
            
            Mat output = new Mat(2, 2, Depth.F32, 1);
            for (int i = 0; i < input_arr.Length; i++)
            {
                output[i, 0] = new Scalar(input_arr[i], 0, 0, 0);
            }
            */

            return output;


        }
    }
}
