using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace IndexOfLibrary
{
    public static class IndexOfLibrary
    {
        public static int ForEachIndexOf(IEnumerable<int> elements, int searchingElement)
        {
            int i = 0;
            foreach (var element in elements)
            {
                if (element == searchingElement)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int ForIndexOf(int[] elements, int searchingElement)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                if (elements[i] == searchingElement)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int ForIndexOfWithCompare(int[] elements, int searchingElement)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(searchingElement) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int ForIndexOfWithSpan(int[] elements, int searchingElement)
        {
            Span<int> elementsSpan = new Span<int>(elements);
            for (var i = 0; i < elementsSpan.Length; i++)
            {
                if (elementsSpan[i] == searchingElement)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int ForIndexOfWithSpanAndOneLengthCalling(int[] elements, int searchingElement)
        {
            Span<int> elementsSpan = new Span<int>(elements);
            var length = elementsSpan.Length;
            for (var i = 0; i < length; i++)
            {
                if (elementsSpan[i] == searchingElement)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int ForIndexOfWithMemory(int[] elements, int searchingElement)
        {
            Memory<int> elementsSpan = new Memory<int>(elements);
            for (var i = 0; i < elementsSpan.Length; i++)
            {
                if (elementsSpan.Span[i] == searchingElement)
                {
                    return i;
                }
            }

            return -1;
        }

        public static unsafe int ForIndexOfWithPointer(int[] elements, int searchingElement)
        {
            fixed (int* elementsAsPointer = elements)
            {
                var length = elements.Length;

                for (var i = 0; i < length; i++)
                {
                    if (elementsAsPointer[i] == searchingElement)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static unsafe int ForIndexOfWithPointerAndDecrement(int[] elements, int searchingElement)
        {
            fixed (int* elementsAsPointer = elements)
            {
                var length = elements.Length;

                for (var i = length - 1; i >= 0; i--)
                {
                    if (elementsAsPointer[i] == searchingElement)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static unsafe int ForIndexOfWithPointerAndBinaryOperator(int[] elements, int searchingElement)
        {
            fixed (int* elementsAsPointer = elements)
            {
                var length = elements.Length;

                for (var i = length - 1; (i & 0) == 0; i--)
                {
                    if (elementsAsPointer[i] == searchingElement)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static int ForIndexOfWithSseAndOneLengthCalling(int[] elements, int searchingElement)
        {
            ReadOnlySpan<int> elementsSpan = new ReadOnlySpan<int>(elements);
            var length = elements.Length;
            var lengthForSse = length / 4 * 4;
            var vectorSearchingElement = Vector128.Create(searchingElement, searchingElement, searchingElement, searchingElement);
            var vectorZeros = Vector128.Create(0, 0, 0, 0);
            Vector128<int> resultVector;
            int i;

            for (i = 0; i < lengthForSse; i += 4)
            {
                resultVector = Sse2.CompareEqual(
                    Vector128.Create(elementsSpan.Slice(i, 4)),
                    vectorSearchingElement);
                if (resultVector != vectorZeros)
                {
                    if (resultVector[3] == -1)
                    {
                        return i + 3;
                    }
                    else if (resultVector[2] == -1)
                    {
                        return i + 2;
                    }
                    else if (resultVector[1] == -1)
                    {
                        return i + 1;
                    }
                    else
                    {
                        return i;
                    }
                }
            }

            for (; i < length; i++)
            {
                if (elements[i] == searchingElement)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}