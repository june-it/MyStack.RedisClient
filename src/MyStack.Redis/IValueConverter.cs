namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Value Converter
    /// </summary>
    public interface IValueConverter
    {
        /// <summary>
        /// Get unique prefix
        /// </summary>
        string Prefix { get; }
        /// <summary>
        /// Convert strings
        /// </summary>
        /// <param name="input">redis value</param>
        /// <returns></returns>
        object Convert(string input);
    }
}
