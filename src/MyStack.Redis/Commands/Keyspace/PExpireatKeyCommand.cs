using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a PEXPIREAT command
    /// </summary>
    /// <remarks>
    /// PEXPIREAT has the same effect and semantic as EXPIREAT, but the Unix time at which the key will expire is specified in milliseconds instead of seconds.
    /// https://redis.io/commands/pexpireat/
    /// </remarks>
    public class PExpireatKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public PExpireatKeyCommand(string key, long timestamp) : base("PEXPIREAT", key, timestamp)
        {
        }
    }
}
