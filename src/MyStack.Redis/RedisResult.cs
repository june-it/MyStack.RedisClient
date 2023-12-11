using System;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis result
    /// </summary>
    public class RedisResult : IEquatable<RedisResult>
    {
        public object Value { get; }
        public RedisResult(object value)
        {
            Value = value;
        }
        /// <summary>
        /// Represents a result with a value of OK
        /// </summary>
        public static RedisResult OK = new RedisResult("OK");
        /// <summary>
        /// Represents a result with a value of 0
        /// </summary>
        public static RedisResult Zero = new RedisResult(0);
        /// <summary>
        /// Represents a result with a value of 1
        /// </summary>
        public static RedisResult One = new RedisResult(1);
        /// <summary>
        /// Represents a result with a value of -1
        /// </summary>
        public static RedisResult MinusOne = new RedisResult(-1);
        /// <summary>
        /// Represents a result with a value of -2
        /// </summary>
        public static RedisResult MinusTwo = new RedisResult(-2);
        /// <summary>
        /// Represents a result with a value of null
        /// </summary>
        public static RedisResult Null = new RedisResult(null);
        public bool Equals(RedisResult other)
        {
            return Convert.ToString(Value) == Convert.ToString(other.Value);
        }
        public bool CompareTo(object otherValue)
        {
            return Convert.ToString(Value) == Convert.ToString(otherValue);
        }
    }
}
