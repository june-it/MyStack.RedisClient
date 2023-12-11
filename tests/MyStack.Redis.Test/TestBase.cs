using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Redis;

namespace MyStack.Redis.Test
{
    public class TestBase
    {
        protected IServiceProvider ServiceProvider { get; private set; }
        [SetUp]
        public void Setup()
        {
            var builder = new HostBuilder()
              .ConfigureHostConfiguration(configure =>
              {
                  configure.SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json");
              })
              .ConfigureServices((context, services) =>
              {
                  services.AddRedis(configure =>
                  {
                      configure.Nodes.Add(new RedisNode("127.0.0.1", 6379));
                      configure.Timeout = 1000;
                      configure.DefaultDatabase = 0;
                      configure.KeyPrefix = "";

                  });
              });

            var app = builder.Build();
            ServiceProvider = app.Services;
        }

    }
}