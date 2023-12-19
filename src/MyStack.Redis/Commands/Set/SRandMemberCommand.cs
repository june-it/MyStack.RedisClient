using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SRandMemberCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SRandMemberCommand(string key, int count = 1) : base("SRANDMEMBER", key, count)
        {
        }
    }
}
