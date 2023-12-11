using System.Net;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis server node
    /// </summary>
    public class RedisNode
    {
        public RedisNode(string host, int port)
        {
            Host = host;
            Port = port;
        }

        public string Host { get; set; }
        public int Port { get; set; }

        public EndPoint GetEndPoint()
        {
            return new IPEndPoint(IPAddress.Parse(Host), Port);
        }
    }

}