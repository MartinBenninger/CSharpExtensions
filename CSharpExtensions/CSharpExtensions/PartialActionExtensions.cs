namespace CSharpExtensions
{
    using System;

    /// <summary>
    /// Generic partial extension methods for all built in System.Func and System.Action delegates.
    /// </summary>
    public static partial class PartialExtensions
    {
        public static Action
            Partial<T1>(
                this Action<T1> action, T1 x1) =>
                    () =>
                        action(x1);

        public static Action<T2>
            Partial<T1, T2>(
                this Action<T1, T2> action, T1 x1) =>
                    (x2) =>
                        action(x1, x2);

        public static Action<T2, T3>
            Partial<T1, T2, T3>(
                this Action<T1, T2, T3> action, T1 x1) =>
                    (x2, x3) =>
                        action(x1, x2, x3);

        public static Action<T2, T3, T4>
            Partial<T1, T2, T3, T4>(
                this Action<T1, T2, T3, T4> action, T1 x1) =>
                    (x2, x3, x4) =>
                        action(x1, x2, x3, x4);

        public static Action<T2, T3, T4, T5>
            Partial<T1, T2, T3, T4, T5>(
                this Action<T1, T2, T3, T4, T5> action, T1 x1) =>
                    (x2, x3, x4, x5) =>
                        action(x1, x2, x3, x4, x5);

        public static Action<T2, T3, T4, T5, T6>
            Partial<T1, T2, T3, T4, T5, T6>(
                this Action<T1, T2, T3, T4, T5, T6> action, T1 x1) =>
                    (x2, x3, x4, x5, x6) =>
                        action(x1, x2, x3, x4, x5, x6);

        public static Action<T2, T3, T4, T5, T6, T7>
            Partial<T1, T2, T3, T4, T5, T6, T7>(
                this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7) =>
                        action(x1, x2, x3, x4, x5, x6, x7);

        public static Action<T2, T3, T4, T5, T6, T7, T8>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
    }
}