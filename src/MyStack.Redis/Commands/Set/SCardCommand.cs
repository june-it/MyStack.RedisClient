using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SCardCommand : CommandBase<int, IntegerValueConverter>
    {
        public SCardCommand(string key) : base("SCARD", key)
        {
        }
    }
}
