using ApacheTech.Common.FunctionalCSharp.Monads.Extensions;

namespace ApacheTech.Common.FunctionalCSharp.Monads
{
    /// <summary>
    ///     Wraps the value in a monad, allowing functional style operations to be executed.
    /// </summary>
    /// <typeparam name="T">The type of value to wrap.</typeparam>
    public sealed class Identity<T>
    {
        /// <summary>
        ///     Initialises a new instance of the <see cref="Identity{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Identity(T value) => Value = value;

        /// <summary>
        ///     Gets the raw wrapped value.
        /// </summary>
        /// <value>
        ///     The value wrapped within this monad.
        /// </value>
        public T Value { get; }

        /// <summary>
        ///     Performs an implicit conversion from <typeparamref name="T"/> to <see cref="Identity{T}"/>.
        /// </summary>
        /// <param name="this">The instance of <typeparamref name="T"/> to convert.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator Identity<T>(T @this) => @this.ToIdentity();

        /// <summary>
        ///     Performs an implicit conversion from <see cref="Identity{T}"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <param name="this">The instance of <see cref="Identity{T}"/> to convert.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator T(Identity<T> @this) => @this.Value;
    }
}
