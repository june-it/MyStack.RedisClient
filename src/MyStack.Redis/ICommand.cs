namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis command interface
    /// </summary>
    /// <typeparam name="TResult">The type of result in the command</typeparam>
    public interface ICommand<TResult>
    {
        /// <summary>
        /// Get the text of the command
        /// </summary>
        string CommandText { get; }
        /// <summary>
        /// Convert response results
        /// </summary>
        /// <param name="responseText">Response Text</param>
        /// <returns></returns>
        TResult Parse(string responseText);
    }
}
