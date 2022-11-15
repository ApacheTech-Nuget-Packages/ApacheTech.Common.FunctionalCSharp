using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.Extensions
{
    /// <summary>
    ///     Extensions methods that provide a means to curry functions; to split multi-input functions into single input functions.
    /// </summary>
    public static class CurryingExtensions
    {
        /// <summary>
        ///     Curries a function with two inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<TLast, TResult>>
            Curry<T1, TLast, TResult>(
            this Func<T1, TLast, TResult> f) =>
            t1 => tLast =>
                f(t1, tLast);

        /// <summary>
        ///     Curries a function with three inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<TLast, TResult>>>
            Curry<T1, T2, TLast, TResult>(
            this Func<T1, T2, TLast, TResult> f) =>
            t1 => t2 => tLast =>
                f(t1, t2, tLast);

        /// <summary>
        ///     Curries a function with four inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<TLast, TResult>>>>
            Curry<T1, T2, T3, TLast, TResult>(
            this Func<T1, T2, T3, TLast, TResult> f) =>
            t1 => t2 => t3 => tLast =>
                f(t1, t2, t3, tLast);

        /// <summary>
        ///     Curries a function with five inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<TLast, TResult>>>>>
            Curry<T1, T2, T3, T4, TLast, TResult>(
            this Func<T1, T2, T3, T4, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => tLast =>
                f(t1, t2, t3, t4, tLast);

        /// <summary>
        ///     Curries a function with six inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<TLast, TResult>>>>>>
            Curry<T1, T2, T3, T4, T5, TLast, TResult>(
            this Func<T1, T2, T3, T4, T5, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => tLast =>
                f(t1, t2, t3, t4, t5, tLast);

        /// <summary>
        ///     Curries a function with seven inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<TLast, TResult>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => tLast =>
                f(t1, t2, t3, t4, t5, t6, tLast);

        /// <summary>
        ///     Curries a function with eight inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<TLast, TResult>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, tLast);

        /// <summary>
        ///     Curries a function with nine inputs.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<TLast, TResult>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, tLast);

        /// <summary>
        ///     Curries a function with ten inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<TLast, TResult>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, tLast);

        /// <summary>
        ///     Curries a function with eleven inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<TLast, TResult>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, tLast);

        /// <summary>
        ///     Curries a function with twelve inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<TLast, TResult>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, tLast);

        /// <summary>
        ///     Curries a function with thirteen inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<TLast, TResult>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, tLast);

        /// <summary>
        ///     Curries a function with fourteen inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<TLast, TResult>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, tLast);

        /// <summary>
        ///     Curries a function with fifteen inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<TLast, TResult>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, tLast);

        /// <summary>
        ///     Curries a function with sixteen inputs.
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
        /// <typeparam name="TLast">The type of the last parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.</typeparam>
        /// <param name="f">The function to curry.</param>
        /// <returns>Returns a chain of single-input functions, that when complete, will invoke the original multi-input function</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<TLast, TResult>>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> f) =>
            t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => tLast =>
                f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, tLast);
    }
}
