using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkResearch.PerformanceTests.Bencmarks;
using Xunit.Abstractions;

namespace BenchmarkResearch.PerformanceTests
{
    public class BenchmarkTests
    {
        private readonly ITestOutputHelper _output;

        public BenchmarkTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestPerformance__HeavyMethod__ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ConsoleWriterBenchmarks>(config);

            // write benchmark summary
            _output.WriteLine(logger.GetLog());
        }

    }

}