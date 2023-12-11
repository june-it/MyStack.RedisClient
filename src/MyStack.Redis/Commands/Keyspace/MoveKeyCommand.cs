using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a MOVE command 
    /// </summary>
    public class MoveKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public MoveKeyCommand(string key, int database) : base("MOVE", key, database)
        {
        }
    }
}
