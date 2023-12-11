using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis connection
    /// </summary>
    public interface IRedisConnection : IDisposable
    {
        bool IsConnected { get; }
        Task ConnectAsync(CancellationToken cancellationToken = default);
        Task<string> SendAsync(string commandText, CancellationToken cancellationToken = default);
    }
}
