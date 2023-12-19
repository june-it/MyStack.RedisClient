using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SetUnionStoreCommand : CommandBase<int, IntegerValueConverter>
    {
        public SetUnionStoreCommand(string destination, params string[] keys) : base("SUNIONSTORE", destination, keys)
        {
        }
    }
}
