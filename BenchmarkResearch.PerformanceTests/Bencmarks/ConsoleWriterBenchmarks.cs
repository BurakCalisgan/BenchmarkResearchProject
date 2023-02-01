using BenchmarkDotNet.Attributes;
using BenchmarkResearch.PerformanceTests.Models;

namespace BenchmarkResearch.PerformanceTests.Bencmarks
{

    [MemoryDiagnoser]
    public class ConsoleWriterBenchmarks
    {
        [Benchmark]
        public void ProcessRequest()
        {
            var sut = new ConsolerWriter();
            sut.WriteConsole();
        }
    }
}
