using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a KEYS command
    /// </summary>
    /// <remarks>
    /// https://redis.io/commands/keys/
    /// </remarks>
    public class KeysCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public KeysCommand(string pattern) : base("KEYS", pattern)
        {
        }

    }
}
