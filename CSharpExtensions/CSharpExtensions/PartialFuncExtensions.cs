namespace CSharpExtensions
{
    using System;

    public static partial class PartialExtensions
    {
        public static Func<TResult> Partial<T1, TResult>(this Func<T1, TResult> func, T1 x1) =>
            () => func(x1);

        public static Func<T2, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 x1) =>
            (x2) => func(x1, x2);

        public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 x1) =>
            (x2, x3) => func(x1, x2, x3);

        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 x1) =>
            (x2, x3, x4) => func(x1, x2, x3, x4);

        public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 x1) =>
            (x2, x3, x4, x5) => func(x1, x2, x3, x4, x5);

        public static Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6) => func(x1, x2, x3, x4, x5, x6);

        public static Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7) => func(x1, x2, x3, x4, x5, x6, x7);

        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8) => func(x1, x2, x3, x4, x5, x6, x7, x8);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 x1) =>
            (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) => func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
    }
}