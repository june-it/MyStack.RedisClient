using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Extensions.Redis
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Dragon Redis
        /// </summary>
        /// <param name="services">The Microsoft.Extensions.DependencyInjection.IServiceCollection</param>
        /// <param name="configure">The Dragon.Redis.RedisOptions configuration delegate</param>
        /// <returns>The Microsoft.Extensions.DependencyInjection.IServiceCollection</returns>
        public static IServiceCollection AddRedis(this IServiceCollection services, Action<RedisOptions> configure)
        {
            var options = new RedisOptions();
            configure.Invoke(options);
            services.Configure(configure);

            services.AddServices();
            return services;
        }
        /// <summary>
        /// Add Dragon Redis
        /// </summary>
        /// <param name="services">The Microsoft.Extensions.DependencyInjection.IServiceCollection</param>
        /// <param name="configuration">The Microsoft.Extensions.Configuration.IConfiguration</param>
        /// <returns>The Microsoft.Extensions.DependencyInjection.IServiceCollection</returns>
        public static IServiceCollection AddRedis(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RedisOptions>(configuration.GetSection("Redis"));
            services.AddServices();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IRedisClient, RedisClient>();
            services.AddTransient<IRedisConnection, RedisConnection>();
            return services;
        }
    }
}
