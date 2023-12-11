using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    public class IncrByFloatCommand : CommandBase<decimal, SimpleStringConverter>
    {
        public IncrByFloatCommand(string key, decimal increment) : base("INCRBYFLOAT", key, increment)
        {
        }
    }
}
