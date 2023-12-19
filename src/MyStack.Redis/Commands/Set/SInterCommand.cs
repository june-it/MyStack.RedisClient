using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SInterCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SInterCommand( params string[] keys) : base("SINTER", keys)
        {
        }
    }
}
