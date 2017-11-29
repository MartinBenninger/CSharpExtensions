namespace CSharpExtensions
{
    using System;

    /// <summary>
    /// Generic partial extension methods for all built in System.Func and System.Action delegates.
    /// </summary>
    public static partial class PartialExtensions
    {
        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<TResult>
            Partial<T1, TResult>(
                this Func<T1, TResult> func, T1 x1) =>
                    () =>
                        func(x1);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, TResult>
            Partial<T1, T2, TResult>(
                this Func<T1, T2, TResult> func, T1 x1) =>
                    (x2) =>
                        func(x1, x2);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, TResult>
            Partial<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func, T1 x1) =>
                    (x2, x3) =>
                        func(x1, x2, x3);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, TResult>
            Partial<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func, T1 x1) =>
                    (x2, x3, x4) =>
                        func(x1, x2, x3, x4);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, TResult>
            Partial<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5) =>
                        func(x1, x2, x3, x4, x5);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, TResult>
            Partial<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6) =>
                        func(x1, x2, x3, x4, x5, x6);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
        /// </summary>
        /// <typeparam name="T1">The type of parameter 1.</typeparam>
        /// <typeparam name="T2">The type of parameter 2.</typeparam>
        /// <typeparam name="T3">The type of parameter 3.</typeparam>
        /// <typeparam name="T4">The type of parameter 4.</typeparam>
        /// <typeparam name="T5">The type of parameter 5.</typeparam>
        /// <typeparam name="T6">The type of parameter 6.</typeparam>
        /// <typeparam name="T7">The type of parameter 7.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7) =>
                        func(x1, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        /// <summary>
        /// Creates a new method with the given parameter partially applied as the first parameter of the given method.
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
        /// <param name="func">The original function.</param>
        /// <param name="x1">The parameter to partially apply to the new function.</param>
        /// <returns>The new function with the first parameter partially applied.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
            Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 x1) =>
                    (x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16) =>
                        func(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
    }
}