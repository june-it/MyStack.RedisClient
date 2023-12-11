using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a command to move a key to a specified database, and obtains the expiration time of the key in seconds
    /// </summary>
    public class TTLCommand : CommandBase<long, IntegerValueConverter>
    {
        public TTLCommand(string key) : base("TTL", key)
        {
        }
    }
}
