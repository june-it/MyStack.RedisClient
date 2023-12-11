using Microsoft.Extensions.Redis.Converters;

namespace Microsoft.Extensions.Redis.Commands.Bitmap
{
    /// <summary>
    /// Represents a BITOP command
    /// </summary>
    public class BitOPCommand : CommandBase<long, IntegerValueConverter>
    {
        public BitOPCommand(BitOP option, string destKey, params string[] keys) : base("BITOP", option, destKey, keys)
        {
        }
    }
    public enum BitOP
    {
        AND,
        OR,
        XOR,
        NOT
    }
}
