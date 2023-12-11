using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a default Redis client implementation
    /// </summary>
    public class RedisClient : IRedisClient
    {
        private readonly IRedisConnection _connection;
        public RedisClient(IRedisConnection connection)
        {
            _connection = connection;
        }
        /// <summary>
        /// Send a command and return the result
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public virtual async Task<TResult> SendAsync<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default)
        {
            if (!_connection.IsConnected)
                await _connection.ConnectAsync(cancellationToken);
            var responseText = await _connection.SendAsync(command.CommandText, cancellationToken);
            return command.Parse(responseText);
        }

        public virtual void Dispose()
        {
            _connection?.Dispose();
        }

    }
}
