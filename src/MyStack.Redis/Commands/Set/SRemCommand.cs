using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SRemCommand : CommandBase<int, IntegerValueConverter>
    {
        public SRemCommand(string key, string value) : base("SREM", key, value)
        {
        }
    }
}
