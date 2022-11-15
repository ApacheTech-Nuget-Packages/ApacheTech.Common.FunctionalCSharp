using System;

namespace ApacheTech.Common.FunctionalCSharp.Monads
{
    /// <summary>
    ///     A monadic wrapper for a function type that may fail, during the execution of its function tree.
    /// </summary>
    /// <typeparam name="T">The type of value to wrap.</typeparam>
    public abstract class Attempt<T>
    {
        /// <summary>
        ///     Gets the raw wrapped value.
        /// </summary>
        /// <value>
        ///     The value wrapped within this monad.
        /// </value>
        public abstract T Value { get; }

        /// <summary>
        ///     Performs an implicit conversion from <see cref="Attempt{T}"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <param name="this">The instance of <see cref="Attempt{T}"/> to convert.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator T(Attempt<T> @this) => @this.Value;
    }
}