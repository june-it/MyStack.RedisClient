using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SAddCommand : CommandBase<int, IntegerValueConverter>
    {
        public SAddCommand(string key, string value) : base("SADD", key, value)
        {
        }
    }
}
