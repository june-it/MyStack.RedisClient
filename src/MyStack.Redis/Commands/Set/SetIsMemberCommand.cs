using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SetIsMemberCommand : CommandBase<int, IntegerValueConverter>
    {
        public SetIsMemberCommand(string key, string value) : base("SISMEMBER", key, value)
        {
        }
    }
}
