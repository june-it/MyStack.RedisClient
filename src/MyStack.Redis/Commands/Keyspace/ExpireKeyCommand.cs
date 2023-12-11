using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a EXPIRE command
    /// </summary>
    public class ExpireKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public ExpireKeyCommand(string key, int seconds) : base("EXPIRE", key, seconds)
        {
        }
    }
}
