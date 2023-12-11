using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    ///  Represents a EXPIREAT command 
    /// </summary>
    /// <remarks> 
    ///  EXPIREAT has the same effect and semantic as EXPIRE, but instead of specifying the number of seconds representing the TTL (time to live), it takes an absolute Unix timestamp (seconds since January 1, 1970). A timestamp in the past will delete the key immediately.
    /// </remarks>
    public class ExpireatKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public ExpireatKeyCommand(string key, long timestamp) : base("EXPIREAT", key, timestamp)
        {
        }
    }
}
