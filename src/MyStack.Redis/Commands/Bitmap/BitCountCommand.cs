using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Bitmap
{
    /// <summary>
    /// Represents a BITCOUNT command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/bitcount/
    /// </remarks>
    public class BitCountCommand : CommandBase<long, IntegerValueConverter>
    {
        public BitCountCommand(string command, params object[] arguments) : base(command, arguments)
        {
        }
    }
}
