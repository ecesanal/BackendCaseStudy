using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCaseStudy.Infrastructure
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _redis;

        public RedisService(IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("Redis:Connection").Value;
            _redis = ConnectionMultiplexer.Connect(connectionString);
        }

        public IDatabase GetDatabase() => _redis.GetDatabase();
    }
}
