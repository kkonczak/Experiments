using BenchmarkDotNet.Running;
using SearchingBenchmarkTest;

namespace BenchmarkTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SearchingBenchmarkTest.SearchingBenchmarkTest>();
        }
    }
}