using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a DEL command
    /// </summary>
    public class DeleteKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public DeleteKeyCommand(params string[] keys) : base("DEL", keys)
        {
        }
    }
}
