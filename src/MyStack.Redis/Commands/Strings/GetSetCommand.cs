using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GETSET command  
    /// </summary>
    /// <remarks> 
    /// Reference link: https://redis.io/commands/getbit/
    /// </remarks>
    public class GetSetCommand : CommandBase<string, SimpleStringConverter>
    {
        public GetSetCommand(string key, string value) : base("GETSET", key, value)
        {
        }
    }
}
