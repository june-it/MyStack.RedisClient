using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GETEX command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/getex/
    /// </remarks>
    public class GetExCommand : CommandBase<string, SimpleStringConverter>
    {
        public GetExCommand(string key, GetExOptions option, long expire) : base("GETEX", key, option, expire)
        {
        }
    }
    /// <summary>
    /// The GETEX command supports a set of options that modify its behavior
    /// </summary>
    public enum GetExOptions
    {
        /// <summary>
        /// Set the specified expire time, in seconds.
        /// </summary>
        EX,
        /// <summary>
        /// Set the specified expire time, in milliseconds.
        /// </summary>
        PX,
        /// <summary>
        /// Set the specified Unix time at which the key will expire, in seconds.
        /// </summary>
        EXAT,
        /// <summary>
        /// Set the specified Unix time at which the key will expire, in milliseconds.
        /// </summary>
        PXAT,
        /// <summary>
        /// Remove the time to live associated with the key.
        /// </summary>
        PERSIST
    }
}
