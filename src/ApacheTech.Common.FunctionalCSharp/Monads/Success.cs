namespace ApacheTech.Common.FunctionalCSharp.Monads
{
    /// <summary>
    ///     A monadic wrapper for a function type that has succeeded thus far, during the execution of its function tree.
    /// </summary>
    /// <typeparam name="T">The type of value to wrap.</typeparam>
    /// <seealso cref="Attempt{T}" />
    public sealed class Success<T> : Attempt<T>
    {
        /// <summary>
        ///     Initialises a new instance of the <see cref="Success{T}"/> class.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        public Success(T value) => Value = value;

        /// <summary>
        ///     Gets the raw wrapped value.
        /// </summary>
        /// <value>
        ///     The value wrapped within this monad.
        /// </value>
        public override T Value { get; }
    }
}