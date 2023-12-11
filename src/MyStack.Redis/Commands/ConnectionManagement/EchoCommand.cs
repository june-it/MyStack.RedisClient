using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.ConnectionManagement
{
    /// <summary>
    /// Represents a ECHO command
    /// </summary>
    public class EchoCommand : CommandBase<string, SimpleStringConverter>
    {
        public EchoCommand(string message) : base("ECHO", message)
        {
        }
    }
}
