using Microsoft.Extensions.Redis.Converters;
using System;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SInterCardCommand : CommandBase<int, IntegerValueConverter>
    {
        public override Version Version => new Version(7, 0, 0);
        public SInterCardCommand(int limit = 0, params string[] keys) : base("SINTERCARD", keys.Length, keys, "limit", limit)
        {
        }
        public SInterCardCommand(params string[] keys) : this(0, keys)
        {
        }
    }
}
