using System;
using System.Collections.Generic;
using ApacheTech.Common.FunctionalCSharp.Monads.Extensions;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

namespace ApacheTech.Common.FunctionalCSharp.Memento
{
    /// <summary>
    ///     A decorator for pure functions, that caches the output of any given invocation, and returns a cached value early, if present.
    /// </summary>
    /// <typeparam name="TInput">The non-nullable type of the input.</typeparam>
    /// <typeparam name="TOutput">The non-nullable type of the output.</typeparam>
    public class Memento<TInput, TOutput>
        where TInput : notnull
        where TOutput : notnull
    {
        private readonly Func<TInput, TOutput> _function;

        // Internal to expose to test suite.
        internal Dictionary<TInput, TOutput> CachedValues { get; } = new();
        
        /// <summary>
        ///     Initialises a new instance of the <see cref="Memento{TInput, TOutput}"/> class.
        /// </summary>
        /// <param name="function">The pure function to decorate.</param>
        public Memento(Func<TInput, TOutput> function) => _function = function;

        /// <summary>
        ///     Invokes the decorated function with the given input argument.
        /// </summary>
        /// <param name="input">The input argument to invoke the decorated function with.</param>
        /// <returns>The result, of type <typeparamref name="TOutput"/> will be cached, and returned early if present within the cache.</returns>
        public TOutput Invoke(TInput input)
        {
            if (CachedValues.TryGetValue(input, out var cachedResult)) return cachedResult;
            return _function
                .ToAttempt()
                .Bind(x => x(input))
                .Match(
                success => CachedValues[input] = success!,
                fail => throw fail.Exception)!;

        }

        public static implicit operator Memento<TInput, TOutput>(Func<TInput, TOutput> f) => new(f);
        public static implicit operator Func<TInput, TOutput>(Memento<TInput, TOutput> f) => f.Invoke;
    }
}