using BenchmarkDotNet.Attributes;
using static IndexOfLibrary.IndexOfLibrary;

namespace SearchingBenchmarkTest
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(exportHtml: true)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [MinIterationCount(100)]
    [MaxIterationCount(200)]
    public class SearchingBenchmarkTest
    {
        public const int SearchingValue = 250859681;

        [Benchmark]
        public int TestForEachIndexOf()
        {
            return ForEachIndexOf(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOf()
        {
            return ForIndexOf(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithCompare()
        {
            return ForIndexOfWithCompare(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithSpan()
        {
            return ForIndexOfWithSpan(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithSpanAndOneLengthCalling()
        {
            return ForIndexOfWithSpanAndOneLengthCalling(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithMemory()
        {
            return ForIndexOfWithMemory(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithPointer()
        {
            return ForIndexOfWithPointer(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithPointerAndDecrement()
        {
            return ForIndexOfWithPointerAndDecrement(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithPointerAndBinaryOperator()
        {
            return ForIndexOfWithPointerAndBinaryOperator(SearchingArrayData.Elements, SearchingValue);
        }

        [Benchmark]
        public int TestForIndexOfWithSseAndOneLengthCalling()
        {
            return ForIndexOfWithSseAndOneLengthCalling(SearchingArrayData.Elements, SearchingValue);
        }
    }
}
