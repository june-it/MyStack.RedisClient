using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a EXISTS command
    /// </summary>
    public class ExistsKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public ExistsKeyCommand(params string[] keys) : base("EXISTS", keys)
        {
        }
    }
}
