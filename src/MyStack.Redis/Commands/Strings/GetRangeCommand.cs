using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    /// <summary>
    /// Represents a GETRANGE command
    /// </summary>
    public class GetRangeCommand : CommandBase<string, SimpleStringConverter>
    {
        public GetRangeCommand(string key, int start, int end) : base("GETRANGE", key, start, end)
        {
        }
    }
}
