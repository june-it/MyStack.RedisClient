using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis client interface
    /// </summary>
    public interface IRedisClient : IDisposable
    {
        /// <summary>
        /// Send a command and return the result
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TResult> SendAsync<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default);
    }
}
