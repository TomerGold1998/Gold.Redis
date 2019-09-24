﻿namespace Gold.Redis.Common.Models.Configuration
{
    public class RedisConnectionConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 6379;
        public string Password { get; set; }
        public int MaxConnections { get; set; }
    }
}
