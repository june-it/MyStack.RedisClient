using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a DECR command
    /// </summary>
    /// <remarks>
    /// Referebce link: https://redis.io/commands/decr
    /// </remarks>
    public class DecrCommand : CommandBase<long, IntegerValueConverter>
    {
        public DecrCommand(string key) : base("DECR", key)
        {
        }
    }
}
