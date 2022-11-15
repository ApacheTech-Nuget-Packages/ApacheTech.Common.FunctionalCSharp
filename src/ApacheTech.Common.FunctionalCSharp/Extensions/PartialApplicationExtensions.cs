using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable ConvertClosureToMethodGroup

namespace ApacheTech.Common.FunctionalCSharp.Extensions
{
    /// <summary>
    ///     Provides extension methods for partial application of functions.
    /// </summary>
    public static class PartialApplicationExtensions
    {
        #region Max Input: 1

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, TOut> Apply<T1, TOut>(this Func<T1, TOut> @this) => (t1) => @this(t1);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, TOut>(this Func<T1, TOut> @this, T1 t1) => () => @this(t1);

        #endregion

        #region Max Input: 2

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, TOut> Apply<T1, T2, TOut>(this Func<T1, T2, TOut> @this) => (t1, t2) => @this(t1, t2);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, TOut> Apply<T1, T2, TOut>(this Func<T1, T2, TOut> @this, T1 t1) => (t2) => @this(t1, t2);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, TOut>(this Func<T1, T2, TOut> @this, T1 t1, T2 t2) => () => @this(t1, t2);

        #endregion

        #region Max Input: 3

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, TOut> Apply<T1, T2, T3, TOut>(this Func<T1, T2, T3, TOut> @this) => (t1, t2, t3) => @this(t1, t2, t3);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, TOut> Apply<T1, T2, T3, TOut>(this Func<T1, T2, T3, TOut> @this, T1 t1) => (t2, t3) => @this(t1, t2, t3);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, TOut> Apply<T1, T2, T3, TOut>(this Func<T1, T2, T3, TOut> @this, T1 t1, T2 t2) => (t3) => @this(t1, t2, t3);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, TOut>(this Func<T1, T2, T3, TOut> @this, T1 t1, T2 t2, T3 t3) => () => @this(t1, t2, t3);

        #endregion

        #region Max Input: 4

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, TOut> Apply<T1, T2, T3, T4, TOut>(this Func<T1, T2, T3, T4, TOut> @this) => (t1, t2, t3, t4) => @this(t1, t2, t3, t4);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, TOut> Apply<T1, T2, T3, T4, TOut>(this Func<T1, T2, T3, T4, TOut> @this, T1 t1) => (t2, t3, t4) => @this(t1, t2, t3, t4);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, TOut> Apply<T1, T2, T3, T4, TOut>(this Func<T1, T2, T3, T4, TOut> @this, T1 t1, T2 t2) => (t3, t4) => @this(t1, t2, t3, t4);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, TOut> Apply<T1, T2, T3, T4, TOut>(this Func<T1, T2, T3, T4, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4) => @this(t1, t2, t3, t4);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, TOut>(this Func<T1, T2, T3, T4, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => () => @this(t1, t2, t3, t4);

        #endregion

        #region Max Input: 5

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this) => (t1, t2, t3, t4, t5) => @this(t1, t2, t3, t4, t5);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this, T1 t1) => (t2, t3, t4, t5) => @this(t1, t2, t3, t4, t5);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5) => @this(t1, t2, t3, t4, t5);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5) => @this(t1, t2, t3, t4, t5);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5) => @this(t1, t2, t3, t4, t5);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, TOut>(this Func<T1, T2, T3, T4, T5, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => () => @this(t1, t2, t3, t4, t5);

        #endregion

        #region Max Input: 6

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this) => (t1, t2, t3, t4, t5, t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6) => @this(t1, t2, t3, t4, t5, t6);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, TOut>(this Func<T1, T2, T3, T4, T5, T6, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => () => @this(t1, t2, t3, t4, t5, t6);

        #endregion

        #region Max Input: 7

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7) => @this(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => () => @this(t1, t2, t3, t4, t5, t6, t7);

        #endregion

        #region Max Input: 8

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8) => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8);

        #endregion

        #region Max Input: 9

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        #endregion

        #region Max Input: 10

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        #endregion

        #region Max Input: 11

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        #endregion

        #region Max Input: 12

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T12, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        #endregion

        #region Max Input: 13

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T12, T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T13, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        #endregion

        #region Max Input: 14

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T12, T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T13, T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T14, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        #endregion

        #region Max Input: 15

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T12, T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T13, T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T14, T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T15, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => (t15) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <param name="t15">The fifteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        #endregion

        #region Max Input: 16

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T10, T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T11, T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T12, T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T13, T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T14, T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T15, T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => (t15, t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <param name="t15">The fifteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<T16, TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => (t16) => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        /// <summary>
        ///     Applies a partial number of input parameters to a function, without executing it.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TOut">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="this">The function to apply the values to.</param>
        /// <param name="t1">The first value to apply to the function.</param>
        /// <param name="t2">The second value to apply to the function.</param>
        /// <param name="t3">The third value to apply to the function.</param>
        /// <param name="t4">The fourth value to apply to the function.</param>
        /// <param name="t5">The fifth value to apply to the function.</param>
        /// <param name="t6">The sixth value to apply to the function.</param>
        /// <param name="t7">The seventh value to apply to the function.</param>
        /// <param name="t8">The eighth value to apply to the function.</param>
        /// <param name="t9">The ninth value to apply to the function.</param>
        /// <param name="t10">The tenth value to apply to the function.</param>
        /// <param name="t11">The eleventh value to apply to the function.</param>
        /// <param name="t12">The twelfth value to apply to the function.</param>
        /// <param name="t13">The thirteenth value to apply to the function.</param>
        /// <param name="t14">The fourteenth value to apply to the function.</param>
        /// <param name="t15">The fifteenth value to apply to the function.</param>
        /// <param name="t16">The sixteenth value to apply to the function.</param>
        /// <returns>A new function, that takes in the remaining parameters that still need to be applied, and outputs the result.</returns>
        public static Func<TOut> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOut> @this, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) => () => @this(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

        #endregion
    }
}