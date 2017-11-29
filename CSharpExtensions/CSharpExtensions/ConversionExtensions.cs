namespace CSharpExtensions
{
    using System;

    /// <summary>
    /// Generic extension methods for running Converter delegates in-line.
    /// </summary>
    public static class ConversionExtensions
    {
        /// <summary>
        /// Converts from the input type to the output type using the specified converter.
        /// </summary>
        /// <typeparam name="TIn">The input type.</typeparam>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input">The input object to convert.</param>
        /// <param name="converter">The converter delegate to do the conversion with.</param>
        /// <returns>TIn converted to TOut.</returns>
        public static TOut Convert<TIn, TOut>(this TIn input, Converter<TIn, TOut> converter)
        {
            return converter(input);
        }
    }
}