using BenchmarkDotNet.Running;

namespace AsyncMethodInForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AsyncMethodInForeachBenchmarkTest>();
        }
    }
}