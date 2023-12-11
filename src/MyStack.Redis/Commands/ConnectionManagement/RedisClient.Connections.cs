using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis.Commands.ConnectionManagement
{
    public static class RedisClientConnectionExtensions
    {
        /// <summary>
        /// 查看服务是否运行
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation</param>
        /// <returns></returns>
        public static async Task<bool> PingAsync(this IRedisClient client, CancellationToken cancellationToken = default)
        {
            var result = await client.SendAsync(PingCommand.Default, cancellationToken);
            return string.Equals(result, "PONG");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<string> EchoAsync(this IRedisClient client, string message, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new EchoCommand(message), cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">The Microsoft.Extensions.RedisClient.IRedisClient</param> 
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<bool> QuitAsync(this IRedisClient client, CancellationToken cancellationToken = default)
        {
            var result = await client.SendAsync(QuitCommand.Default, cancellationToken);
            return string.Equals(result, "OK");
        }
    }
}
