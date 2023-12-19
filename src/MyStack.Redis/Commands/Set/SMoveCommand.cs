using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SMoveCommand : CommandBase<int, IntegerValueConverter>
    {
        public SMoveCommand(string source, string destination, string value) : base("SMOVE", source, destination, value)
        {
        }
    }
}
