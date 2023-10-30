using BenchmarkDotNet.Running;

namespace AsyncMethodTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AsyncMethodsBenchmarkTest>();
        }
    }
}