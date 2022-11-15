namespace ApacheTech.Common.FunctionalCSharp.Monads
{
    /// <summary>
    ///     A monadic wrapper for a type that is guaranteed to not have a value.
    /// </summary>
    /// <typeparam name="T">The type of value to wrap.</typeparam>
    /// <seealso cref="Maybe{T}" />
    public sealed class Nothing<T> : Maybe<T?>
    {
        /// <summary>
        ///     Gets the default value of the wrapped type.
        /// </summary>
        /// <value>
        ///     The default value of the type wrapped within this monad.
        /// </value>
        public override T? Value => default;
    }
}