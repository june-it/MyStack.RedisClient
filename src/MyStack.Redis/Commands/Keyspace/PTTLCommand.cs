using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a command to move a key to a specified database, and obtains the expiration time of the key in milliseconds
    /// </summary>
    public class PTTLCommand : CommandBase<long, IntegerValueConverter>
    {
        public PTTLCommand(string key) : base("PTTL", key)
        {
        }
    }
}
