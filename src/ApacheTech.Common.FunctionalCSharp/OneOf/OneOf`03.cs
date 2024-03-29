﻿using System;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace ApacheTech.Common.FunctionalCSharp.OneOf
{
    /// <summary>
    ///     Contains one, and only one, of three potential items.
    /// </summary>
    /// <typeparam name="T1">The type of the first parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T2">The type of the second parameter that this class encapsulates.</typeparam>
    /// <typeparam name="T3">The type of the third parameter that this class encapsulates.</typeparam>
    public class OneOf<T1, T2, T3>
    {
        private readonly T1? _t1;
        private readonly T2? _t2;
        private readonly T3? _t3;

        private readonly int _itemIndex;

        private OneOf(int index) => _itemIndex = index;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="t1">The type of the first parameter that this class encapsulates.</param>
        public OneOf(T1 t1) : this(1) => _t1 = t1;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="t2">The type of the second parameter that this class encapsulates.</param>
        public OneOf(T2 t2) : this(2) => _t2 = t2;

        /// <summary>
        ///     Initialises a new instance of the <see cref="OneOf{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="t3">The type of the third parameter that this class encapsulates.</param>
        public OneOf(T3 t3) : this(3) => _t3 = t3;

        /// <summary>
        ///     Invokes an action, based on the contained type.
        /// </summary>
        /// <param name="f1">The <see cref="Action"/> to invoke, for the first parameter that this class encapsulates.</param>
        /// <param name="f2">The <see cref="Action"/> to invoke, for the second parameter that this class encapsulates.</param>
        /// <param name="f3">The <see cref="Action"/> to invoke, for the third parameter that this class encapsulates.</param>
        public void Invoke(
            Action<T1> f1,
            Action<T2> f2,
            Action<T3> f3)
        {
            switch (_itemIndex)
            {
                case 1: f1(_t1!); break;
                case 2: f2(_t2!); break;
                case 3: f3(_t3!); break;
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
        public T Match<T>(
            Func<T1, T> f1,
            Func<T2, T> f2,
            Func<T3, T> f3) =>
            _itemIndex switch
            {
                1 => f1(_t1!),
                2 => f2(_t2!),
                3 => f3(_t3!),
                _ => throw new ArgumentOutOfRangeException(
                    nameof(_itemIndex), "Internal error within OneOf"),
            };
    }
}