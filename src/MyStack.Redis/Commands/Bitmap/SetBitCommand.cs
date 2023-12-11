using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Bitmap
{
    /// <summary>
    /// Represents a SETBIT command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/setbit/
    /// </remarks>
    public class SetBitCommand : CommandBase<long, IntegerValueConverter>
    {
        public SetBitCommand(string key, long offset, string value) : base("SETBIT", key, offset, value)
        {
        }
    }
}
