using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis.Commands.Keyspace
{
    /// <summary>
    /// 表示RedisThe Microsoft.Extensions.RedisClient.IRedisClient键命令扩展类
    /// </summary>
    public static class RedisClientKeyExtensions
    {
        /// <summary>
        /// 删除指定键的值
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns>返回影响的记录数</returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<int> DeleteKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new DeleteKeyCommand(key), cancellationToken);
        }
        /// <summary>
        /// Serialize the value of the specified key
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns>If serialization is successful, return true; otherwise, return false</returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> DumpKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new DumpKeyCommand(key), cancellationToken);
            return RedisResult.Null.CompareTo(result);
        }
        /// <summary>
        /// 检查指定键是否存在
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> ExistsKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new ExistsKeyCommand(key), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 为指定键设置过期时间
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="seconds">过期时间（秒）</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> ExpireKeyAsync(this IRedisClient client, string key, int seconds, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new ExpireKeyCommand(key, seconds), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 为指定键设置过期时间
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="timestamp">过期时间（秒级UNIX时间戳）</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> ExpireatKeyAsync(this IRedisClient client, string key, long timestamp, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new ExpireatKeyCommand(key, timestamp), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 为指定键设置过期时间
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="milliseconds">过期时间（毫秒）</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> PExpireKeyAsync(this IRedisClient client, string key, int milliseconds, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new PExpireKeyCommand(key, milliseconds), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 为指定键设置过期时间
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="timestamp">过期时间（毫秒级UNIX时间戳）</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> PExpireatKeyAsync(this IRedisClient client, string key, long timestamp, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new PExpireatKeyCommand(key, timestamp), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 通过匹配模式查找键列表
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="pattern"></param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<List<string>> KeysAsync(this IRedisClient client, string pattern, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(pattern)) throw new ArgumentNullException(nameof(pattern), "匹配字符不能为空");
            return await client.SendAsync(new KeysCommand(pattern), cancellationToken);
        }
        /// <summary>
        /// 移动键到指定数据库
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="database">数据库</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> MoveKeyAsync(this IRedisClient client, string key, int database, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new MoveKeyCommand(key, database), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 移除键的过期时间，键永不过期
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throw an exception when the key is empty or null</exception>
        public static async Task<bool> PersistKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            var result = await client.SendAsync(new PersistKeyCommand(key), cancellationToken);
            return RedisResult.One.CompareTo(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key">The name of the key</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<long> PTTLKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new PTTLCommand(key), cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="key"></param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static async Task<long> TTLKeyAsync(this IRedisClient client, string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key), "The key cannot be empty");
            return await client.SendAsync(new TTLCommand(key), cancellationToken);
        }
    }
}
