using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GETSET command 
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/set/
    /// </remarks>
    public class SetCommand : CommandBase<string, SimpleStringConverter>
    {
        public SetCommand(string key, string value) : base("SET", key, value)
        {
        }
    }
}
