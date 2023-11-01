using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringConcatenationBenchmarkTest
{
    [DisassemblyDiagnoser]
    [MemoryDiagnoser]
    public class StringConcatenationBenchmarkTest
    {
        public const string String1 = "asdasdasfadsfasdfasdfdsfsdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String2 = "asdasdasfadsfasdfasdfdsfsdspopkpkopkokijojoijjiuhihyuguygugytytfadasdasdasdasdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String3 = "asdas2342342342342342342dasfadsfasdfasdfdsfsdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String4 = "asdasdasfadsfasdfasdfdsfsdAASASASASASSAfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String5 = "asdasdasfadsfaasdasdasdfasiuihhhbjhbhgvfcgfcgxdfxfxsdresresreydfdsfsdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String6 = "asdasdasfadsfasdfasdfdsfsdfsdfrtyrtyrtyrsdfsdfsdfsdfsdfsdfs";
        public const string String7 = "asdasdastyutyutyutyutfadsfhihih8h887y807y80y8080hiuhbuvytftfrcgfvhgvbjbhihuiasdfasdfdsfsdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String8 = "asdasdasfadsfasdfasduiyuiyuiyuiyuiyiyuiyuifdsfsdfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String9 = "asdasdasfadsfasdfasdfdsfsdvbnvbnvbs45se45setsretserergru6867867nvbnvbnvbnfsdfsdfsdfsdfsdfsdfsdfs";
        public const string String10 = "asdasdasfadsfasdfasdfdsfsdfmbnmbnmbnmbnmvbncvbcvbcbxcvxcvcvbcvnvnvbnsdfsdfsdfsdfsdfsdfsdfs";
        public const string String11 = "asdasdasfadsfasweq2qwea34aw34wrse5se45sdfasdfdsfsdfsdfsdfsdfsdfsdfsdfsdfs";

        [Benchmark]
        public string PlusStringConcatenationTest()
        {
            return PlusStringConcatenation(String1, String2, String3, String4, String5, String6, String7, String8, String9, String10, String11);
        }

        [Benchmark]
        public string StringBuilderStringConcatenationTest()
        {
            return StringBuilderStringConcatenation(String1, String2, String3, String4, String5, String6, String7, String8, String9, String10, String11);
        }

        public string PlusStringConcatenation(params string[] strings)
        {
            string result = string.Empty;

            foreach (var str in strings)
            {
                result += str + str + str;
            }

            return result;
        }

        public string StringBuilderStringConcatenation(params string[] strings)
        {
            var stringBuilder = new StringBuilder();

            foreach (var str in strings)
            {
                stringBuilder.Append(str);
                stringBuilder.Append(str);
                stringBuilder.Append(str);
            }

            return stringBuilder.ToString();
        }
    }
}
