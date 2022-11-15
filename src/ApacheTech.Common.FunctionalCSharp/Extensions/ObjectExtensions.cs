using System.Collections.Generic;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.Extensions
{
    /// <summary>
    ///     Extension methods to aid working with objects.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        ///     Determines whether the specified object is equal to the default instance of the object.
        /// </summary>
        /// <typeparam name="T">The type of object to determine the value of.</typeparam>
        /// <param name="this">The instance of the object to determine the value of.</param>
        /// <returns>
        ///   <c>true</c> if the object is set to the default value; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDefaultValue<T>(this T @this) 
            => EqualityComparer<T?>.Default.Equals(@this, default);
    }
}