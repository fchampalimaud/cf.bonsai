﻿using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Xml.Serialization;
using Python.Runtime;

namespace CF.Scripting.Python
{
    /// <summary>
    /// Represents an operator that gets the value of a variable in the specified
    /// Python module.
    /// </summary>
    [DefaultProperty(nameof(VariableName))]
    [Description("Gets the value of a variable in the specified Python module.")]
    public class GetInt : Source<int>
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
        /// Gets the value of a variable in the specified Python module and
        /// surfaces it through an observable sequence.
        /// </summary>
        /// <returns>
        /// A sequence containing the value of the Python runtime variable as
        /// a <see cref="PyObject"/>.
        /// </returns>
        public override IObservable<int> Generate()
        {
            return RuntimeManager.RuntimeSource.SelectMany(runtime =>
            {
                var module = Module ?? runtime.MainModule;
                return Observable.Return(module.Get(VariableName).As<int>());
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
        public IObservable<int> Generate<TSource>(IObservable<TSource> source)
        {
            return RuntimeManager.RuntimeSource.SelectMany(runtime =>
            {
                return source.Select(_ =>
                {
                    using (Py.GIL())
                    {
                        var module = Module ?? runtime.MainModule;
                        return module.Get(VariableName).As<int>();
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
        public IObservable<int> Process(IObservable<PyModule> source)
        {
            return source.Select(module =>
            {
                using (Py.GIL())
                {
                    return module.Get(VariableName).As<int>();
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
        public IObservable<int> Process(IObservable<RuntimeManager> source)
        {
            return source.Select(runtime =>
            {
                using (Py.GIL())
                {
                    return runtime.MainModule.Get(VariableName).As<int>();
                }
            });
        }
    }
}
