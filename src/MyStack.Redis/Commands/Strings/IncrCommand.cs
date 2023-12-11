using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a INCR command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/incr/
    /// </remarks>
    public class IncrCommand : CommandBase<long, SimpleStringConverter>
    {
        public IncrCommand(string key) : base("INCR", key)
        {
        }
    }
}
