using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.OneOf
{
    /// <summary>
    ///     Contains one, and only one, of ten potential items.
    /// </summary>
    /// <typeparam name="T1">The type of the first parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T2">The type of the second parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T3">The type of the third parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T4">The type of the forth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T5">The type of the fifth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T6">The type of the sixth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T7">The type of the seventh parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T8">The type of the eighth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T9">The type of the ninth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T10">The type of the tenth parameter that this class encapsulates.</typeparam>
    public class OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly T1? _t1;
        private readonly T2? _t2;
        private readonly T3? _t3;
        private readonly T4? _t4;
        private readonly T5? _t5;
        private readonly T6? _t6;
        private readonly T7? _t7;
        private readonly T8? _t8;
        private readonly T9? _t9;
        private readonly T10? _t10;

        private readonly int _itemIndex;

        private OneOf(int index) => _itemIndex = index;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter that this class encapsulates.</typeparam>
        public OneOf(T1 t1) : this(1) => _t1 = t1;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T2">The type of the second parameter that this class encapsulates.</typeparam>
        public OneOf(T2 t2) : this(2) => _t2 = t2;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T3">The type of the third parameter that this class encapsulates.</typeparam>
        public OneOf(T3 t3) : this(3) => _t3 = t3;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T4">The type of the fourth parameter that this class encapsulates.</typeparam>
        public OneOf(T4 t4) : this(4) => _t4 = t4;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T5">The type of the fifth parameter that this class encapsulates.</typeparam>
        public OneOf(T5 t5) : this(5) => _t5 = t5;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T6">The type of the sixth parameter that this class encapsulates.</typeparam>
        public OneOf(T6 t6) : this(6) => _t6 = t6;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T7">The type of the seventh parameter that this class encapsulates.</typeparam>
        public OneOf(T7 t7) : this(7) => _t7 = t7;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T8">The type of the eighth parameter that this class encapsulates.</typeparam>
        public OneOf(T8 t8) : this(8) => _t8 = t8;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T9">The type of the ninth parameter that this class encapsulates.</typeparam>
        public OneOf(T9 t9) : this(9) => _t9 = t9;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> class.
        /// </summary>
        /// <typeparam name="T10">The type of the tenth parameter that this class encapsulates.</typeparam>
        public OneOf(T10 t10) : this(10) => _t10 = t10;

        /// <summary>
        ///     Invokes an action, based on the contained type.
        /// </summary>
        /// <param name="f1">The <see cref="Action"/> to invoke, for the first parameter that this class encapsulates.</param>
        /// <param name="f2">The <see cref="Action"/> to invoke, for the second parameter that this class encapsulates.</param>
        /// <param name="f3">The <see cref="Action"/> to invoke, for the third parameter that this class encapsulates.</param>
        /// <param name="f4">The <see cref="Action"/> to invoke, for the fourth parameter that this class encapsulates.</param>
        /// <param name="f5">The <see cref="Action"/> to invoke, for the fifth parameter that this class encapsulates.</param>
        /// <param name="f6">The <see cref="Action"/> to invoke, for the sixth parameter that this class encapsulates.</param>
        /// <param name="f7">The <see cref="Action"/> to invoke, for the seventh parameter that this class encapsulates.</param>
        /// <param name="f8">The <see cref="Action"/> to invoke, for the eighth parameter that this class encapsulates.</param>
        /// <param name="f9">The <see cref="Action"/> to invoke, for the ninth parameter that this class encapsulates.</param>
        /// <param name="f10">The <see cref="Action"/> to invoke, for the tenth parameter that this class encapsulates.</param>
        public void Invoke(
            Action<T1> f1,
            Action<T2> f2,
            Action<T3> f3,
            Action<T4> f4,
            Action<T5> f5,
            Action<T6> f6,
            Action<T7> f7,
            Action<T8> f8,
            Action<T9> f9,
            Action<T10> f10)
        {
            switch (_itemIndex)
            {
                case 1: f1(_t1!); break;
                case 2: f2(_t2!); break;
                case 3: f3(_t3!); break;
                case 4: f4(_t4!); break;
                case 5: f5(_t5!); break;
                case 6: f6(_t6!); break;
                case 7: f7(_t7!); break;
                case 8: f8(_t8!); break;
                case 9: f9(_t9!); break;
                case 10: f10(_t10!); break;
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
        /// <param name="f7">The <see cref="Func{T7, T}"/> to invoke, for the seventh parameter that this class encapsulates.</param>
        /// <param name="f8">The <see cref="Func{T8, T}"/> to invoke, for the eighth parameter that this class encapsulates.</param>
        /// <param name="f9">The <see cref="Func{T9, T}"/> to invoke, for the ninth parameter that this class encapsulates.</param>
        /// <param name="f10">The <see cref="Func{T10, T}"/> to invoke, for the tenth parameter that this class encapsulates.</param>
        public T Match<T>(
            Func<T1, T> f1,
            Func<T2, T> f2,
            Func<T3, T> f3,
            Func<T4, T> f4,
            Func<T5, T> f5,
            Func<T6, T> f6,
            Func<T7, T> f7,
            Func<T8, T> f8,
            Func<T9, T> f9,
            Func<T10, T> f10) =>
            _itemIndex switch
            {
                1 => f1(_t1!),
                2 => f2(_t2!),
                3 => f3(_t3!),
                4 => f4(_t4!),
                5 => f5(_t5!),
                6 => f6(_t6!),
                7 => f7(_t7!),
                8 => f8(_t8!),
                9 => f9(_t9!),
                10 => f10(_t10!),
                _ => throw new ArgumentOutOfRangeException(
                    nameof(_itemIndex), "Internal error within OneOf"),
            };
    }
}