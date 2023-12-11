using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// Represents a DUMP command
    /// </summary>
    public class DumpKeyCommand : CommandBase<string, SimpleStringConverter>
    {
        public DumpKeyCommand(string key) : base("DUMP", key)
        {
        }
    }
}
