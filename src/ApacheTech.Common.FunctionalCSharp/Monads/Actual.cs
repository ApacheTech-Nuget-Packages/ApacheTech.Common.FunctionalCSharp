namespace ApacheTech.Common.FunctionalCSharp.Monads
{
    /// <summary>
    ///     A monadic wrapper for a type that is guaranteed to have a value, at any given stage of the function tree.
    /// </summary>
    /// <typeparam name="T">The type of value to wrap.</typeparam>
    /// <seealso cref="Maybe{T}" />
    public sealed class Actual<T> : Maybe<T>
    {
        /// <summary>
        ///     Initialises a new instance of the <see cref="Actual{T}"/> class.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        public Actual(T value) => Value = value;

        /// <summary>
        ///     Gets the raw wrapped value.
        /// </summary>
        /// <value>
        ///     The value wrapped within this monad.
        /// </value>
        public override T Value { get; }
    }
}