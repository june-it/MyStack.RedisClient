using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a PERSIST command 
    /// </summary>
    public class PersistKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public PersistKeyCommand(string key) : base("PERSIST", key)
        {

        }
    }
}
