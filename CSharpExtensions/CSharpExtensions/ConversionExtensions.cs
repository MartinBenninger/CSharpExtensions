namespace CSharpExtensions
{
    using System;

    public static class ConversionExtensions
    {
        public static TOut Convert<TIn, TOut>(this TIn input, Converter<TIn, TOut> converter)
        {
            return converter(input);
        }
    }
}