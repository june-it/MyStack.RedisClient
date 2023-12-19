using Microsoft.Extensions.Redis.Converters;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SMisMemberCommand : CommandBase<List<int>, ArrayValueConverter>
    {
        public override Version Version => new Version(6, 2, 0);
        public SMisMemberCommand(string key, params object[] values) : base("SMISMEMBER", key, values)
        {
        }
    }
}
