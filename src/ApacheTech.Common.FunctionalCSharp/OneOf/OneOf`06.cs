using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.OneOf
{
    /// <summary>
    ///     Contains one, and only one, of six potential items.
    /// </summary>
    /// <typeparam name="T1">The type of the first parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T2">The type of the second parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T3">The type of the third parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T4">The type of the forth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T5">The type of the fifth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T6">The type of the sixth parameter that this class encapsulates.</typeparam>
    public class OneOf<T1, T2, T3, T4, T5, T6>
    {
        private readonly T1? _t1;
        private readonly T2? _t2;
        private readonly T3? _t3;
        private readonly T4? _t4;
        private readonly T5? _t5;
        private readonly T6? _t6;

        private readonly int _itemIndex;

        private OneOf(int index) => _itemIndex = index;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter that this class encapsulates.</typeparam>
        public OneOf(T1 t1) : this(1) => _t1 = t1;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T2">The type of the second parameter that this class encapsulates.</typeparam>
        public OneOf(T2 t2) : this(2) => _t2 = t2;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T3">The type of the third parameter that this class encapsulates.</typeparam>
        public OneOf(T3 t3) : this(3) => _t3 = t3;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T4">The type of the fourth parameter that this class encapsulates.</typeparam>
        public OneOf(T4 t4) : this(4) => _t4 = t4;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T5">The type of the fifth parameter that this class encapsulates.</typeparam>
        public OneOf(T5 t5) : this(5) => _t5 = t5;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6}"/> class.
        /// </summary>
        /// <typeparam name="T6">The type of the sixth parameter that this class encapsulates.</typeparam>
        public OneOf(T6 t6) : this(6) => _t6 = t6;

        /// <summary>
        ///     Invokes an action, based on the contained type.
        /// </summary>
        /// <param name="f1">The <see cref="Action"/> to invoke, for the first parameter that this class encapsulates.</param>
        /// <param name="f2">The <see cref="Action"/> to invoke, for the second parameter that this class encapsulates.</param>
        /// <param name="f3">The <see cref="Action"/> to invoke, for the third parameter that this class encapsulates.</param>
        /// <param name="f4">The <see cref="Action"/> to invoke, for the fourth parameter that this class encapsulates.</param>
        /// <param name="f5">The <see cref="Action"/> to invoke, for the fifth parameter that this class encapsulates.</param>
        /// <param name="f6">The <see cref="Action"/> to invoke, for the sixth parameter that this class encapsulates.</param>
        public void Invoke(
            Action<T1> f1,
            Action<T2> f2,
            Action<T3> f3,
            Action<T4> f4,
            Action<T5> f5,
            Action<T6> f6)
        {
            switch (_itemIndex)
            {
                case 1: f1(_t1!); break;
                case 2: f2(_t2!); break;
                case 3: f3(_t3!); break;
                case 4: f4(_t4!); break;
                case 5: f5(_t5!); break;
                case 6: f6(_t6!); break;
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(_itemIndex), "Internal error within OneOf");
            }
        }

        /// <summary>
        ///     Invokes a function, based on the contained type.
        /// </summary>
        /// <param name="f1">The <see cref="Func{T1, T}"/> to invoke, for the first parameter that this class encapsulates.</param>
        /// <param name="f2">The <see cref="Func{T2, T}"/> to invoke, for the second parameter that this class encapsulates.</param>
        /// <param name="f3">The <see cref="Func{T3, T}"/> to invoke, for the third parameter that this class encapsulates.</param>
        /// <param name="f4">The <see cref="Func{T4, T}"/> to invoke, for the fourth parameter that this class encapsulates.</param>
        /// <param name="f5">The <see cref="Func{T5, T}"/> to invoke, for the fifth parameter that this class encapsulates.</param>
        /// <param name="f6">The <see cref="Func{T6, T}"/> to invoke, for the sixth parameter that this class encapsulates.</param>
        public T Match<T>(
            Func<T1, T> f1,
            Func<T2, T> f2,
            Func<T3, T> f3,
            Func<T4, T> f4,
            Func<T5, T> f5,
            Func<T6, T> f6) =>
            _itemIndex switch
            {
                1 => f1(_t1!),
                2 => f2(_t2!),
                3 => f3(_t3!),
                4 => f4(_t4!),
                5 => f5(_t5!),
                6 => f6(_t6!),
                _ => throw new ArgumentOutOfRangeException(
                    nameof(_itemIndex), "Internal error within OneOf"),
            };
    }
}