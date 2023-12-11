using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GETDEL command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/getdel/
    /// </remarks>
    public class GetDelCommand : CommandBase<string, SimpleStringConverter>
    {
        public GetDelCommand(string key) : base("GETDEL", key)
        {
        }
    }
}
