using BenchmarkDotNet.Running;

namespace StringConcatenationBenchmarkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringConcatenationBenchmarkTest>();
        }
    }
}