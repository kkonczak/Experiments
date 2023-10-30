using BenchmarkDotNet.Running;

namespace MethodsBenchmarkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MethodsBenchmarkTest>();
        }
    }
}