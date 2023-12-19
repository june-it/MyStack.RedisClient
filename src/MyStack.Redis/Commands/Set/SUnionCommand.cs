using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SUnionCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SUnionCommand(params string[] keys) : base("SUNION", keys)
        {
        }
    }
}
