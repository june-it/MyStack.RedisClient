using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Redis;
using Microsoft.Extensions.Redis.Commands.Keyspace;

namespace MyStack.Redis.Test
{
    public class RedisClientKeysTest : TestBase
    {
        [Test]
        public async Task DeleteKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.DeleteKeyAsync("AA");
            Assert.Pass();
        }
        [Test]
        public async Task DumpKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.DumpKeyAsync("AAA");
            Assert.Pass();
        }

        [Test]
        public async Task ExistsKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.ExistsKeyAsync("AA");
            Assert.Pass();
        }
        [Test]
        public async Task ExpireKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.ExpireKeyAsync("A", 1000);
            Assert.Pass();
        }

        [Test]
        public async Task Keys()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.KeysAsync("A*");
            Assert.Pass();
        }
        [Test]
        public async Task MoveKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.MoveKeyAsync("A", 1);
            Assert.Pass();
        }

        [Test]
        public async Task PersistKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.PersistKeyAsync("A1");
            Assert.Pass();
        }
        [Test]
        public async Task PTTLKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.PTTLKeyAsync("A1");
            Assert.Pass();
        }
        [Test]
        public async Task TTLKey()
        {
            var client = ServiceProvider.GetRequiredService<IRedisClient>();
            await client.TTLKeyAsync("A1");
            Assert.Pass();
        }
    }
}
