using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    internal class SPopCommand : CommandBase<string, SimpleStringConverter>
    {
        public SPopCommand(string key, int number = 1) : base("SPOP", key, number)
        {
        }
    }
}
