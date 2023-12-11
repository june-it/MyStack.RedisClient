using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Redis;
using Microsoft.Extensions.Redis.Commands.ConnectionManagement;

namespace MyStack.Redis.Test
{
    public class RedisClientConnectionsTest : TestBase
    {
        [Test]
        public async Task Ping()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            var result = await client.PingAsync();
            Assert.True(result);
        }
    }
}
