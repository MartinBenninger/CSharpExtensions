namespace CSharpExtensions
{
    using System;

    public static partial class CurryExtensions
    {

        public static Func<T1, Action<T2>>
            Curry<T1, T2>(
                this Action<T1, T2> action) =>
                    x1 => x2 =>
                        action(x1, x2);

        public static Func<T1, Func<T2, Action<T3>>>
            Curry<T1, T2, T3>(
                this Action<T1, T2, T3> action) =>
                    x1 => x2 => x3 =>
                        action(x1, x2, x3);

        public static Func<T1, Func<T2, Func<T3, Action<T4>>>>
            Curry<T1, T2, T3, T4>(
                this Action<T1, T2, T3, T4> action) =>
                    x1 => x2 => x3 => x4 =>
                        action(x1, x2, x3, x4);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>
            Curry<T1, T2, T3, T4, T5>(
                this Action<T1, T2, T3, T4, T5> action) =>
                    x1 => x2 => x3 => x4 => x5 =>
                        action(x1, x2, x3, x4, x5);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>
            Curry<T1, T2, T3, T4, T5, T6>(
                this Action<T1, T2, T3, T4, T5, T6> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 =>
                        action(x1, x2, x3, x4, x5, x6);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7>(
                this Action<T1, T2, T3, T4, T5, T6, T7> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 =>
                        action(x1, x2, x3, x4, x5, x6, x7);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 => x15 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 => x15 => x16 =>
                        action(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
    }
}