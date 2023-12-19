using Microsoft.Extensions.Redis.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Redis.Commands.Set
{
    public class SinterStoreCommand : CommandBase<List<string>, ArrayValueConverter>
    {
        public SinterStoreCommand(string key, params string[] keys) : base("SINTERSTORE", key, keys)
        {
        }
    }
}
