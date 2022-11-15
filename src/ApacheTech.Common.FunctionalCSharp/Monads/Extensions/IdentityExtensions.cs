using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace ApacheTech.Common.FunctionalCSharp.Monads.Extensions
{
    /// <summary>
    ///     Extension methods for monadic functions.
    /// </summary>
    public static class IdentityExtensions
    {
        /// <summary>
        ///     Wraps the value in a monad, allowing functional style operations to be executed.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        /// <returns>
        ///     An instance of <see cref="Identity{T}"/>, which wraps the value, and provides access to functional style monadic operations.
        /// </returns>
        public static Identity<T> ToIdentity<T>(this T value) => new(value);

        /// <summary>
        ///     Binds a function to a monad of type <see cref="Identity{TFromType}"/>, mutating the return type dependent on the result.
        /// </summary>
        /// <typeparam name="TFrom">The type of the value wrapped within the input monad.</typeparam>
        /// <typeparam name="TTo">The type of the value to wrap within the output monad.</typeparam>
        /// <param name="this">The monad to bind the function to.</param>
        /// <param name="f">The function to bind.</param>
        /// <returns>Returns the result of the bound operation, as an instance of <see cref="Identity{TTo}"/>.</returns>
        public static Identity<TTo> Bind<TFrom, TTo>(this Identity<TFrom> @this, Func<TFrom, TTo> f) => f(@this).ToIdentity();
    }
}