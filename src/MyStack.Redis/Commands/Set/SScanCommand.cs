using Microsoft.Extensions.Redis.Converters;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SScanCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public override Version Version => new Version(2, 8, 0);
        public SScanCommand(string key, int cursor, string pattern, int count) : base("SSCAN", key, cursor, "MATCH", pattern, "COUNT", count)
        {
        }
    }
}
