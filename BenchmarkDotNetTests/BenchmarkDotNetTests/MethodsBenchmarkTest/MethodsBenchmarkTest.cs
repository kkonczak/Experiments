using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;

namespace MethodsBenchmarkTest
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(exportHtml: true)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    public class MethodsBenchmarkTest
    {
        [Benchmark]
        public int ImmediateCode()
        {
            return new Random().Next();
        }

        [Benchmark]
        public int ExtractedPrivateMethodCode()
        {
            return PrivateMethod();
        }

        [Benchmark]
        public int ExtractedPublicMethodCode()
        {
            return PublicMethod();
        }

        [Benchmark]
        public int ExtractedPublicMethodWithAggressiveInliningCode()
        {
            return PublicMethodWithAggressiveInlining();
        }

        [Benchmark]
        public int ExtractedMethodWithNonStaticMethodCode()
        {
            return new NonStaticTestMethod().ReturnValue();
        }


        [Benchmark]
        public int ExtractedMethodWithStaticMethodCode()
        {
            return StaticTestMethod.ReturnValue();
        }


        private int PrivateMethod()
        {
            return new Random().Next();
        }

        public int PublicMethod()
        {
            return new Random().Next();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int PublicMethodWithAggressiveInlining()
        {
            return new Random().Next();
        }
    }
}
