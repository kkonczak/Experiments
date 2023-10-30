namespace MethodsBenchmarkTest
{
    public class NonStaticTestMethod
    {
        public int ReturnValue()
        {
            return new Random().Next();
        }
    }
}
