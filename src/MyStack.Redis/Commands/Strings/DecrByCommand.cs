using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a DECRBY command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/decrby
    /// </remarks>
    public class DecrByCommand : CommandBase<long, IntegerValueConverter>
    {
        public DecrByCommand(string key, long decrement) : base("DECRBY", key, decrement)
        {
        }
    }
}
