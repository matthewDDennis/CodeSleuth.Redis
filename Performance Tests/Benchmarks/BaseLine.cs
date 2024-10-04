using BenchmarkDotNet.Attributes;

using StackExchange.Redis;

namespace Benchmarks
{
    [MemoryDiagnoser]
    
    public class BaseLine
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase db;

        static BaseLine()
        {
            redis = ConnectionMultiplexer.Connect("localhost");
            db = redis.GetDatabase();
        }

        [Benchmark(Baseline = true)]
        public bool SetString()
        {
            return db.StringSet("key", "value");
        }
    }
}
