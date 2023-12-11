using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    public class PExpireKeyCommand : CommandBase<int, IntegerValueConverter>
    {
        public PExpireKeyCommand(string key, int milliseconds) : base("PEXPIRE", key, milliseconds)
        {
        }
    }
}
