using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a APPEND command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/append/
    /// </remarks>
    public class AppendCommand : CommandBase<int, IntegerValueConverter>
    {
        public AppendCommand(string key, string value) : base("APPEND", key, value)
        {
        }
    }
}
