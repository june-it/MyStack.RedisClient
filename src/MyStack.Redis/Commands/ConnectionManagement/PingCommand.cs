using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.ConnectionManagement
{
    /// <summary>
    /// Represents a PING command
    /// </summary>
    public class PingCommand : CommandBase<string, SimpleStringConverter>
    {
        public PingCommand() : base("PING")
        {
        }
        public static PingCommand Default => new PingCommand();
    }
}
