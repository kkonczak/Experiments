# Przesukiwanie tablic
Najwolniejsze okazało się przesukiwanie z wykorzystaniem pętli foreach i IEnumerable<>. Najszybszy kod był wykorzystujący bezpośrednio zwykłą iterację pętlą for po tablicy i wykorzystujący instrukcje SSE2.
| Method                                     | Mean       | Error    | StdDev    | Median     | Code Size | Gen0   | Allocated |
|------------------------------------------- |-----------:|---------:|----------:|-----------:|----------:|-------:|----------:|
| TestForEachIndexOf                         | 6,806.7 ns | 49.75 ns | 137.85 ns | 6,742.3 ns |     240 B | 0.0153 |      32 B |
| TestForIndexOfWithMemory                   | 2,457.7 ns | 14.92 ns |  41.58 ns | 2,442.3 ns |     215 B |      - |         - |
| TestForIndexOfWithCompare                  | 1,128.3 ns |  9.09 ns |  26.08 ns | 1,118.3 ns |      72 B |      - |         - |
| TestForIndexOf                             |   723.2 ns |  8.57 ns |  24.59 ns |   713.3 ns |      62 B |      - |         - |
| TestForIndexOfWithSpanAndOneLengthCalling  |   716.2 ns |  6.18 ns |  17.93 ns |   708.4 ns |      85 B |      - |         - |
| TestForIndexOfWithPointerAndDecrement      |   714.3 ns |  4.34 ns |  12.46 ns |   708.2 ns |     131 B |      - |         - |
| TestForIndexOfWithSpan                     |   710.5 ns |  4.75 ns |  13.40 ns |   703.7 ns |      85 B |      - |         - |
| TestForIndexOfWithPointerAndBinaryOperator |   710.4 ns |  4.22 ns |  11.90 ns |   705.2 ns |     114 B |      - |         - |
| TestForIndexOfWithPointer                  |   710.3 ns |  3.67 ns |  10.24 ns |   706.2 ns |     138 B |      - |         - |
| TestForIndexOfWithSseAndOneLengthCalling   |   308.6 ns |  2.12 ns |   5.95 ns |   306.0 ns |     277 B |      - |         - |

## Najwolniejszy kod
```
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
```
## Najszybszy kod
```
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
```

# Korzystanie z async...await w synchronicznym kodzie, kiedy nie jest to potrzebne
Zbędne korzystanie z async...await  może wydłużyć wykonywanie kodu 1222 razy, przynajmniej w przykładowym kodzie
| Method                       | Mean       | Error     | StdDev    | Median     | Code Size | Gen0   | Allocated |
|----------------------------- |-----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| ReturnFromAsyncAwaitedMethod | 71.0543 ns | 1.4519 ns | 1.4910 ns | 70.4923 ns |     446 B | 0.0918 |     144 B |
| ReturnFromAsyncMethod        | 33.9784 ns | 0.7079 ns | 1.0810 ns | 33.4904 ns |     163 B | 0.0459 |      72 B |
| ReturnFromNormalMethod       |  0.0278 ns | 0.0369 ns | 0.0346 ns |  0.0141 ns |       6 B |      - |         - |

## Najwolniejszy kod
```
return await ValueReturnAsync(1, 2345);
```

## Najszybszy kod
```
return ValueReturn(1, 2345);
```

# Korzystanie z async...await w synchronicznym kodzie w pętli foreach, kiedy nie jest to potrzebne
Zbędne korzystanie z async...await może wydłużyć czas wykonywania kodu o 6 razy, przynajmniej w przykładowym kodzie
| Method          | Mean      | Error    | StdDev   | Median    | Code Size | Gen0     | Allocated |
|---------------- |----------:|---------:|---------:|----------:|----------:|---------:|----------:|
| ForeachSumAsync | 386.79 μs | 7.527 μs | 8.960 μs | 388.40 μs |     447 B | 458.9844 |  720040 B |
| ForeachSum      |  65.88 μs | 1.226 μs | 2.937 μs |  64.73 μs |     227 B |        - |      40 B |

## Najwolniejszy kod
```
public async Task<int> ForeachSumAsync()
        {
            int result = 0;

            foreach (var i in Enumerable.Range(0, 10000))
            {
                result += await SumAsync(i, i * 10);
            }

            return result;
        }
```

## Najszybszy kod
```
        public int ForeachSum()
        {
            int result = 0;

            foreach (var i in Enumerable.Range(0, 10000))
            {
                result += NonAsyncSum(i, i * 10);
            }

            return result;
        }
```
