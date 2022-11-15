using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.Memento
{
    /// <summary>
    ///     Extension methods to aid the decoration of functions, as cached mementos.
    /// </summary>
    public static class MementoExtensions
    {
        /// <summary>
        ///     Decorates a pure function as a <see cref="Memento{TInput,TOutput}"/>, that caches the output of any given invocation, and returns a cached value early, if present.
        /// </summary>
        /// <typeparam name="TInput">The non-nullable type of the input.</typeparam>
        /// <typeparam name="TOutput">The non-nullable type of the output.</typeparam>
        /// <param name="function">The pure function to decorate.</param>
        /// <returns></returns>
        public static Memento<TInput, TOutput> ToMemento<TInput, TOutput>(this Func<TInput, TOutput> function)
            where TInput : notnull where TOutput : notnull => new(function);
    }
}