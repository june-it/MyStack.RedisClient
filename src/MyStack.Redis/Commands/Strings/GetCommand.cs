using Microsoft.Extensions.Redis.Converters;
using System.ComponentModel;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GET command  
    /// </summary>
    /// <remarks> 
    /// Reference link: https://redis.io/commands/get
    /// </remarks>
    public class GetCommand : CommandBase<string, BulkStringValueConverter>
    {
        public GetCommand(string key) : base("GET", key)
        {
        }
    }
}
