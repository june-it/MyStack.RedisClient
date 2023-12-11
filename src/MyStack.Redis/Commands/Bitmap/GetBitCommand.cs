using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Bitmap
{
    /// <summary>
    /// Represents a GETBIT command
    /// </summary>
    /// <remarks>
    /// Reference link: https://redis.io/commands/getbit/
    /// </remarks>
    public class GetBitCommand : CommandBase<long, IntegerValueConverter>
    {
        public GetBitCommand(string key, long offset) : base("GETBIT", key, offset)
        {
        }
    }
}
