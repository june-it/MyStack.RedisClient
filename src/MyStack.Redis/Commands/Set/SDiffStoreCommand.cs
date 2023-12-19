using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SDiffStoreCommand : CommandBase<int, IntegerValueConverter>
    {
        public SDiffStoreCommand(string destination, params object[] keys) : base("SDIFFSTORE", destination, keys)
        {
        }
    }
}
