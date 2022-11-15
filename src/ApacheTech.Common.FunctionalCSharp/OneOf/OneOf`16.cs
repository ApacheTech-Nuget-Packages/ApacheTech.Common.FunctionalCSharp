using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.OneOf
{
    /// <summary>
    ///     Contains one, and only one, of sixteen potential items.
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
    /// <typeparam name="T11">The type of the eleventh parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T12">The type of the twelfth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T13">The type of the thirteenth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T14">The type of the fourteenth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T15">The type of the fifteenth parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T16">The type of the sixteenth parameter that this class encapsulates.</typeparam>
    public class OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
        private readonly T11? _t11;
        private readonly T12? _t12;
        private readonly T13? _t13;
        private readonly T14? _t14;
        private readonly T15? _t15;
        private readonly T16? _t16;

        private readonly int _itemIndex;

        private OneOf(int index) => _itemIndex = index;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t1">The type of the first parameter that this class encapsulates.</param>
        public OneOf(T1 t1) : this(1) => _t1 = t1;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t2">The type of the second parameter that this class encapsulates.</param>
        public OneOf(T2 t2) : this(2) => _t2 = t2;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t3">The type of the third parameter that this class encapsulates.</param>
        public OneOf(T3 t3) : this(3) => _t3 = t3;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t4">The type of the fourth parameter that this class encapsulates.</param>
        public OneOf(T4 t4) : this(4) => _t4 = t4;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t5">The type of the fifth parameter that this class encapsulates.</param>
        public OneOf(T5 t5) : this(5) => _t5 = t5;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t6">The type of the sixth parameter that this class encapsulates.</param>
        public OneOf(T6 t6) : this(6) => _t6 = t6;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t7">The type of the seventh parameter that this class encapsulates.</param>
        public OneOf(T7 t7) : this(7) => _t7 = t7;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t8">The type of the eighth parameter that this class encapsulates.</param>
        public OneOf(T8 t8) : this(8) => _t8 = t8;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t9">The type of the ninth parameter that this class encapsulates.</param>
        public OneOf(T9 t9) : this(9) => _t9 = t9;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t10">The type of the tenth parameter that this class encapsulates.</param>
        public OneOf(T10 t10) : this(10) => _t10 = t10;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t11">The type of the eleventh parameter that this class encapsulates.</param>
        public OneOf(T11 t11) : this(11) => _t11 = t11;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t12">The type of the twelfth parameter that this class encapsulates.</param>
        public OneOf(T12 t12) : this(12) => _t12 = t12;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t13">The type of the thirteenth parameter that this class encapsulates.</param>
        public OneOf(T13 t13) : this(13) => _t13 = t13;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t14">The type of the fourteenth parameter that this class encapsulates.</param>
        public OneOf(T14 t14) : this(14) => _t14 = t14;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t15">The type of the fifteenth parameter that this class encapsulates.</param>
        public OneOf(T15 t15) : this(15) => _t15 = t15;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> class.
        /// </summary>
        /// <param name="t16">The type of the sixteenth parameter that this class encapsulates.</param>
        public OneOf(T16 t16) : this(16) => _t16 = t16;

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
        /// <param name="f11">The <see cref="Action"/> to invoke, for the eleventh parameter that this class encapsulates.</param>
        /// <param name="f12">The <see cref="Action"/> to invoke, for the twelfth parameter that this class encapsulates.</param>
        /// <param name="f13">The <see cref="Action"/> to invoke, for the thirteenth parameter that this class encapsulates.</param>
        /// <param name="f14">The <see cref="Action"/> to invoke, for the fourteenth parameter that this class encapsulates.</param>
        /// <param name="f15">The <see cref="Action"/> to invoke, for the fifteenth parameter that this class encapsulates.</param>
        /// <param name="f16">The <see cref="Action"/> to invoke, for the sixteenth parameter that this class encapsulates.</param>
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
            Action<T10> f10,
            Action<T11> f11,
            Action<T12> f12,
            Action<T13> f13,
            Action<T14> f14,
            Action<T15> f15,
            Action<T16> f16)
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
                case 11: f11(_t11!); break;
                case 12: f12(_t12!); break;
                case 13: f13(_t13!); break;
                case 14: f14(_t14!); break;
                case 15: f15(_t15!); break;
                case 16: f16(_t16!); break;
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
        /// <param name="f11">The <see cref="Func{T11, T}"/> to invoke, for the eleventh parameter that this class encapsulates.</param>
        /// <param name="f12">The <see cref="Func{T12, T}"/> to invoke, for the twelfth parameter that this class encapsulates.</param>
        /// <param name="f13">The <see cref="Func{T13, T}"/> to invoke, for the thirteenth parameter that this class encapsulates.</param>
        /// <param name="f14">The <see cref="Func{T14, T}"/> to invoke, for the fourteenth parameter that this class encapsulates.</param>
        /// <param name="f15">The <see cref="Func{T15, T}"/> to invoke, for the fifteenth parameter that this class encapsulates.</param>
        /// <param name="f16">The <see cref="Func{T16, T}"/> to invoke, for the sixteenth parameter that this class encapsulates.</param>
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
            Func<T10, T> f10,
            Func<T11, T> f11,
            Func<T12, T> f12,
            Func<T13, T> f13,
            Func<T14, T> f14,
            Func<T15, T> f15,
            Func<T16, T> f16) =>
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
                11 => f11(_t11!),
                12 => f12(_t12!),
                13 => f13(_t13!),
                14 => f14(_t14!),
                15 => f15(_t15!),
                16 => f16(_t16!),
                _ => throw new ArgumentOutOfRangeException(
                    nameof(_itemIndex), "Internal error within OneOf"),
            };
    }
}