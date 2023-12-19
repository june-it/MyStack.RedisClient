using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SDiffCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SDiffCommand(params string[] keys) : base("SDIFF", keys)
        {
        }
    }
}
