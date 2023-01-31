using BenchmarkDotNet.Attributes;
using BencmarkProcessor.Clients;

namespace BencmarkProcessor.Benchmark
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class BenchmarkHarness
    {
        [Params(100, 200)]
        public int IterationCount;

        private readonly RestClient _restClient = new RestClient();

        [Benchmark]
        public async Task RestGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _restClient.GetSmallPayloadAsync();
            }
        }
    }
}
