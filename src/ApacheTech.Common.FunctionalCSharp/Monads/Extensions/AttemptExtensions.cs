using System;
using ApacheTech.Common.FunctionalCSharp.Extensions;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace ApacheTech.Common.FunctionalCSharp.Monads.Extensions
{
    // For reference: https://www.youtube.com/watch?v=v7WLC5As6g4

    /// <summary>
    ///     Extension methods for monadic functions.
    /// </summary>
    public static class AttemptExtensions
    {
        /// <summary>
        ///     Performs an explicit conversion from <typeparamref name="T"/> to <see cref="Attempt{T}"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static Attempt<T> ToAttempt<T>(this T value) => new Success<T>(value);

        /// <summary>
        ///     Binds a function to a monad of type <see cref="Attempt{T}"/>, mutating the return type dependent on the result.
        /// </summary>
        /// <typeparam name="TFromType">The type of the value wrapped within the input monad.</typeparam>
        /// <typeparam name="TToType">The type of the value to wrap within the output monad.</typeparam>
        /// <param name="this">The monad to bind the function to.</param>
        /// <param name="f">The function to bind.</param>
        /// <returns>Returns a <see cref="Success{T}"/>, if the execution of the function succeeds; otherwise returns a <see cref="Fail{T}"/>.</returns>
        public static Attempt<TToType> Bind<TFromType, TToType>(
            this Attempt<TFromType> @this, Func<TFromType, TToType> f)
        {
            return @this switch
            {
                Success<TFromType> success when typeof(TFromType).IsValueType => f.TryInvoke(success),
                Success<TFromType> success when !success.Value.IsDefaultValue() => f.TryInvoke(success),
                Fail<TFromType> fail => new Fail<TToType>(fail.Exception)!,
                _ => new Fail<TToType>(new ArgumentOutOfRangeException(nameof(@this)))!
            };
        }
        
        private static Attempt<TToType> TryInvoke<TFromType, TToType>(this Func<TFromType, TToType> f, Success<TFromType> value)
        {
            try
            {
                return f(value).ToAttempt();
            }
            catch (Exception ex)
            {
                return new Fail<TToType>(ex)!;
            }
        }

        /// <summary>
        ///     Invokes a function, based on the contained type.
        /// </summary>
        /// <param name="attempt">The monadic function to attempt to invoke.</param>
        /// <param name="onSuccess">The function to invoke, if the invocation attempt succeeds.</param>
        /// <param name="onFailure">The function to invoke if the invocation attempt fails.</param>
        public static T Match<T>(this Attempt<T> attempt, Func<Success<T>, T> onSuccess, Func<Fail<T>, T> onFailure) =>
            attempt switch
            {
                Success<T> success => onSuccess(success),
                Fail<T> fail => onFailure(fail),
                _ => throw new ArgumentOutOfRangeException(nameof(attempt))
            };

        /// <summary>
        ///     Invokes a function, based on the contained type.
        /// </summary>
        /// <param name="attempt">The monadic function to attempt to invoke.</param>
        /// <param name="onSuccess">The function to invoke, if the invocation attempt succeeds.</param>
        /// <param name="onFailure">The function to invoke if the invocation attempt fails.</param>
        public static void ActOn<T>(this Attempt<T> attempt, Action<Success<T>> onSuccess, Action<Fail<T>> onFailure)
        {
            switch (attempt)
            {
                case Fail<T> fail: onFailure(fail); break;
                case Success<T> success: onSuccess(success); break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(attempt));
            }
        }
    }
}