using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;

namespace AsyncMethodTests
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(exportHtml: true)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    public class AsyncMethodsBenchmarkTest
    {
        [Benchmark]
        public async Task<int> ReturnFromAsyncAwaitedMethod()
        {
            return await ValueReturnAsync(1, 2345);
        }

        [Benchmark]
        public Task<int> ReturnFromAsyncMethod()
        {
            return ValueReturnAsync(1, 2345);
        }

        [Benchmark]
        public int ReturnFromNormalMethod()
        {
            return ValueReturn(1, 2345);
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public async Task<int> ValueReturnAsync(int a, int b)
        {
            return a + b * a / b + 123;
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public int ValueReturn(int a, int b)
        {
            return a + b * a / b + 123;
        }
    }
}
