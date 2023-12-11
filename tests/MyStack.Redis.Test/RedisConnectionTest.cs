using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Redis;

namespace MyStack.Redis.Test
{
    public class RedisConnectionTest : TestBase
    {
        [Test]
        public async Task Ping()
        {
            var connection = ServiceProvider.GetRequiredService<IRedisConnection>();
            await connection.ConnectAsync();
            Assert.IsTrue(connection.IsConnected);
        }
    }
}
