using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.ConnectionManagement
{
    /// <summary>
    /// Represents a QUIT command
    /// </summary>
    public class QuitCommand : CommandBase<string, SimpleStringConverter>
    {
        public QuitCommand() : base("QUIT")
        {
        }
        public static QuitCommand Default => new QuitCommand();
    }
}
