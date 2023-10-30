using BenchmarkDotNet.Attributes;

namespace AsyncMethodInForeach
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(exportHtml: true)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    public class AsyncMethodInForeachBenchmarkTest
    {
        [Benchmark]
        public int ForeachSum()
        {
            int result = 0;

            foreach (var i in Enumerable.Range(0, 10000))
            {
                result += NonAsyncSum(i, i * 10);
            }

            return result;
        }

        [Benchmark]
        public async Task<int> ForeachSumAsync()
        {
            int result = 0;

            foreach (var i in Enumerable.Range(0, 10000))
            {
                result += await SumAsync(i, i * 10);
            }

            return result;
        }

        public int NonAsyncSum(int a, int b)
        {
            return a + b * 10;
        }

        public async Task<int> SumAsync(int a, int b)
        {
            return a + b * 10;
        }
    }
}
