using System;
using System.Diagnostics;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace ApacheTech.Common.FunctionalCSharp.Extensions
{
    /// <summary>
    ///     Extension methods for working with try...catch blocks.
    /// </summary>
    public static class TryCatchExtensions
    {
        /// <summary>
        ///     Wraps an action within a try..catch block, performing a second action if the specified exception is thrown.
        /// </summary>
        /// <typeparam name="TException">The type of the exception to catch.</typeparam>
        /// <param name="try">The action to try.</param>
        /// <param name="catch">The action to perform if an exception of type <see ref="TException"/> is caught.</param>
        public static void TryCatch<TException>(this Action @try, Action<TException> @catch)
            where TException : Exception
        {
            try { @try(); } catch (TException ex) { @catch(ex); }
        }

        /// <summary>
        ///     Wraps an action within a try..catch block, failing fast if the specified exception is thrown.
        /// </summary>
        /// <typeparam name="TException">The type of the exception to catch.</typeparam>
        /// <param name="try">The action to try.</param>
        public static void TryOrFailFast<TException>(this Action @try)
            where TException : Exception
            => TryCatch<TException>(@try, ex => Environment.FailFast(ex.Message, ex));

        /// <summary>
        ///     Wraps an action within a try..catch block, rethrowing if the specified exception is thrown.
        /// </summary>
        /// <typeparam name="TException">The type of the exception to catch.</typeparam>
        /// <param name="try">The action to try.</param>
        public static void TryOrThrow<TException>(this Action @try)
            where TException : Exception
            => TryCatch<TException>(@try, ex => throw ex);

        /// <summary>
        ///     Wraps an action within a try..catch block, logging to the Console output if the specified exception is thrown.
        /// </summary>
        /// <typeparam name="TException">The type of the exception to catch.</typeparam>
        /// <param name="try">The action to try.</param>
        public static void TryOrLogToConsole<TException>(this Action @try)
            where TException : Exception
            => TryCatch<TException>(@try, Console.WriteLine);

        /// <summary>
        ///     Wraps an action within a try..catch block, logging to the Debug output if the specified exception is thrown.
        /// </summary>
        /// <typeparam name="TException">The type of the exception to catch.</typeparam>
        /// <param name="try">The action to try.</param>
        public static void TryOrLogToDebug<TException>(this Action @try)
            where TException : Exception
            => TryCatch<TException>(@try, ex => Debug.WriteLine(ex));
    }
}