using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis.Commands.Strings
{
    public static class IRedisClientStringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>

        public static async Task<bool> SetAsync(this IRedisClient client, string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new SetCommand(key, value), cancellationToken);
            return RedisResult.OK.CompareTo(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<string> GetAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new GetCommand(key), cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<string> GetRangeAsync(this IRedisClient client, string key, int start, int end, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new GetRangeCommand(key, start, end), cancellationToken);
        }
        /// <summary>
        /// Get the value of the key and set a new value
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="value"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<string> GetSetAsync(this IRedisClient client, string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new GetSetCommand(key, value), cancellationToken);
        }
        /// <summary>
        /// aa
        /// </summary>
        /// <param name="client"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<string> GetbitAsync(this IRedisClient client, string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new GetSetCommand(key, value), cancellationToken);
        }

        public static async Task<decimal> IncrByFloatAsync(this IRedisClient client, string key, decimal increment, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new IncrByFloatCommand(key, increment), cancellationToken);
        }

    }
}
