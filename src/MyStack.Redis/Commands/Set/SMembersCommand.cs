using Microsoft.Extensions.Redis.Converters;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SMembersCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SMembersCommand(string key) : base("SMEMBERS", key)
        {
        }
    }
}
