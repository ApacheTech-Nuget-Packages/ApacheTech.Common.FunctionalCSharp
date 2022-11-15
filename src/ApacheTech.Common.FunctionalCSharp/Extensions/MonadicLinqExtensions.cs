using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable CommentTypo

namespace ApacheTech.Common.FunctionalCSharp.Extensions
{
    /// <summary>
    ///     Extension methods for monadic functions.
    /// </summary>
    public static class MonadicLinqExtensions
    {
        /// <summary>
        ///     Executes a function that converts one type, to another.
        /// </summary>
        /// <typeparam name="TFromType">The type to map from.</typeparam>
        /// <typeparam name="TToType">The type to map to.</typeparam>
        /// <param name="this">The input value.</param>
        /// <param name="f">The function that converts the input value, to an output type.</param>
        /// <returns>An instance of <typeparamref name="TToType"/>, converted from the input value.</returns>
        public static TToType Map<TFromType, TToType>(this TFromType @this, Func<TFromType, TToType> f)
            => f(@this);

        /// <summary>
        ///     Executes a function on a value, and if that function does not produce a valid result, performs a second action.
        /// </summary>
        /// <typeparam name="TInput">The type of the input value.</typeparam>
        /// <typeparam name="TOutput">The type of the output value.</typeparam>
        /// <param name="this">The input value.</param>
        /// <param name="f1">The initial function to execute on the input value.</param>
        /// <param name="f2">The function to run is <paramref name="f1"/> returns as a default value.</param>
        /// <returns>An instance of <typeparamref name="TOutput"/>, from the result of either <paramref name="f1"/>, or if that fails, <paramref name="f2"/>.</returns>
        public static TOutput Alt<TInput, TOutput>(this TInput @this, Func<TInput, TOutput> f1, Func<TInput, TOutput> f2)
            => f1(@this).IfDefaultDo(f2, @this);

        /// <summary>
        ///     Runs a function, if the input value is the default for its type.
        /// </summary>
        /// <typeparam name="TInput">The type of the input.</typeparam>
        /// <typeparam name="TOutput">The type of the output.</typeparam>
        /// <param name="this">The this.</param>
        /// <param name="f">The f.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static TOutput IfDefaultDo<TInput, TOutput>(this TOutput @this, Func<TInput, TOutput> f, TInput input)
            => @this.IsDefaultValue() ? f(input) : @this;

        /// <summary>
        ///     Executes a number of operations on the input value, which all output the same type. The results are flattened, and returned as a single value.
        /// </summary>
        /// <typeparam name="TInput">The type of the input value.</typeparam>
        /// <typeparam name="TOutput">The type of the output value.</typeparam>
        /// <param name="this">The input value.</param>
        /// <param name="joinFunc">The function used to flatten the results from each of the <paramref name="paths"/>.</param>
        /// <param name="paths">A number of operations, to be performed on the input value.</param>
        /// <returns>A single value, of type <typeparamref name="TOutput"/>, flattened from the results of operations performed on the input value.</returns>
        /// <remarks>For more information, see: https://www.youtube.com/watch?v=v7WLC5As6g4</remarks>
        /// <example>
        ///     var input = "aaabbbcccddd";<br/>
        ///     var output = input.Fork(x => x.Sum(),<br/>
        ///         x => x.Count(y=> y == 'a'),<br/>
        ///         x => x.Count(y=> y == 'b'),<br/>
        ///         x => x.Count(y=> y == 'c'));<br/>
        ///     output.Should().Be(9);
        /// </example>
        public static TOutput Fork<TInput, TOutput>(this TInput @this, Func<IEnumerable<TOutput>, TOutput> joinFunc, params Func<TInput, TOutput>[] paths)
            => paths.Select(f => f(@this)).Map(joinFunc);

        /// <summary>
        ///     Executes a number of predicates on a specific input value, and validates against all of them.
        /// </summary>
        /// <typeparam name="T">The type of the input value.</typeparam>
        /// <param name="this">The input value.</param>
        /// <param name="failedRules">The input value.</param>
        /// <param name="rules">A number of predicates, to be performed on the input value.</param>
        /// <returns>Returns <c>true</c> is all predicates return <c>true</c>; otherwise returns <c>false</c>.</returns>
        public static bool TryValidate<T>(this T @this, out IEnumerable<Func<T, bool>> failedRules, params Func<T, bool>[] rules) 
            => !(failedRules = rules.Where(x => !x(@this))).Any();

        /// <summary>
        ///     Executes a number of predicates on a specific input value, and validates against all of them.
        /// </summary>
        /// <typeparam name="T">The type of the input value.</typeparam>
        /// <param name="this">The input value.</param>
        /// <param name="rules">A number of predicates, to be performed on the input value.</param>
        /// <returns>Returns <c>true</c> is all predicates return <c>true</c>; otherwise returns <c>false</c>.</returns>
        public static bool Validate<T>(this T @this, params Func<T, bool>[] rules)
            => rules.All(p => p(@this));
    }
}