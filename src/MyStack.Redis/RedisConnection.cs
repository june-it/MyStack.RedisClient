using Microsoft.Extensions.Options;
using System;
using System.Buffers;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Redis
{
    public class RedisConnection : IRedisConnection
    {
        private TaskCompletionSource<bool> _taskCompletionSource;
        private Socket _socket;
        private bool _isConnected;
        public RedisConnection(IOptions<RedisOptions> options)
        {
            Options = options.Value;
        }
        public RedisOptions Options { get; }
        public bool IsConnected => _isConnected;
        public virtual Task ConnectAsync(CancellationToken cancellationToken = default)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _taskCompletionSource?.TrySetCanceled();

            _taskCompletionSource = new TaskCompletionSource<bool>();

            _socket.BeginConnect(Options.Nodes[0].GetEndPoint(), asyncResult =>
            {
                if (cancellationToken.IsCancellationRequested)
                    _taskCompletionSource.TrySetCanceled();
                try
                {
                    _socket.EndConnect(asyncResult);
                    _taskCompletionSource.TrySetResult(true);
                }
                catch (Exception ex)
                {
                    _taskCompletionSource.TrySetException(ex);
                }
            }, null);
            _isConnected = true;
            return _taskCompletionSource.Task;
        }
        public virtual async Task<string> SendAsync(string commandText, CancellationToken cancellationToken = default)
        {
            var sendBytes = Encoding.UTF8.GetBytes(commandText);
            await _socket.SendAsync(new ArraySegment<byte>(sendBytes), SocketFlags.None, cancellationToken);
            byte[] receivedBytes = ArrayPool<byte>.Shared.Rent(1024);
            try
            {
                var length = await _socket.ReceiveAsync(new ArraySegment<byte>(receivedBytes), SocketFlags.None, cancellationToken);
                if (length == 0)
                    return null;
                return Encoding.UTF8.GetString(receivedBytes, 0, length);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(receivedBytes);
            }
        }
        public virtual void Dispose()
        {
            if (_socket != null)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
        }
    }
}
