using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a INCRBY command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/incrby/
    /// </remarks>
    public class IncrByCommand : CommandBase<long, SimpleStringConverter>
    {
        public IncrByCommand(string key, long increment) : base("INCRBY", key, increment)
        {
        }
    }
}
