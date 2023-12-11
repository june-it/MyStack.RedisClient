using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Redis;
using Microsoft.Extensions.Redis.Commands.Strings;

namespace MyStack.Redis.Test
{
    public class RedisClientStringsTest : TestBase
    {
        [Test]
        public async Task Set()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.SetAsync("AA", Guid.NewGuid().ToString());
            Assert.Pass();
        }
        [Test]
        public async Task Get()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.GetAsync("AA");
            Assert.Pass();
        }
        [Test]
        public async Task Getrange()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.GetRangeAsync("AA", 0, 5);
            Assert.Pass();
        }

        [Test]
        public async Task Getset()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.GetSetAsync("AA", Guid.NewGuid().ToString());
            Assert.Pass();
        }

        [Test]
        public async Task IncrByFloat()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.SetAsync("F1", "1");
            await client.IncrByFloatAsync("F1", 1);
            var result = await client.GetAsync("F1");
            Assert.That( result, Is.EqualTo("2"));
        }
    }
}
