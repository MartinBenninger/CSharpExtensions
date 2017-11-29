namespace CSharpExtensions
{
    using System;

    /// <summary>
    /// Generic curry extension methods for all built in System.Func and System.Action delegates.
    /// </summary>
    public static partial class CurryExtensions
    {
        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, TResult>>
            Curry<T1, T2, TResult>(
                this Func<T1, T2, TResult> func) =>
                    x1 => x2 =>
                        func(x1, x2);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, TResult>>>
            Curry<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func) =>
                    x1 => x2 => x3 =>
                        func(x1, x2, x3);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>
            Curry<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func) =>
                    x1 => x2 => x3 => x4 =>
                        func(x1, x2, x3, x4);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>
            Curry<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 =>
                        func(x1, x2, x3, x4, x5);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 =>
                        func(x1, x2, x3, x4, x5, x6);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 =>
                        func(x1, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="T12">The type of parameter 12.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="T12">The type of parameter 12.</typeparam>
        /// <typeparam name="T13">The type of parameter 13.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="T12">The type of parameter 12.</typeparam>
        /// <typeparam name="T13">The type of parameter 13.</typeparam>
        /// <typeparam name="T14">The type of parameter 14.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="T12">The type of parameter 12.</typeparam>
        /// <typeparam name="T13">The type of parameter 13.</typeparam>
        /// <typeparam name="T14">The type of parameter 14.</typeparam>
        /// <typeparam name="T15">The type of parameter 15.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 => x15 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        /// <summary>
        /// Curries the specified function.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="T8">The type of parameter 8.</typeparam>
        /// <typeparam name="T9">The type of parameter 9.</typeparam>
        /// <typeparam name="T10">The type of parameter 10.</typeparam>
        /// <typeparam name="T11">The type of parameter 11.</typeparam>
        /// <typeparam name="T12">The type of parameter 12.</typeparam>
        /// <typeparam name="T13">The type of parameter 13.</typeparam>
        /// <typeparam name="T14">The type of parameter 14.</typeparam>
        /// <typeparam name="T15">The type of parameter 15.</typeparam>
        /// <typeparam name="T16">The type of parameter 16.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function to curry.</param>
        /// <returns>The curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) =>
                    x1 => x2 => x3 => x4 => x5 => x6 => x7 => x8 => x9 => x10 => x11 => x12 => x13 => x14 => x15 => x16 =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
    }
}