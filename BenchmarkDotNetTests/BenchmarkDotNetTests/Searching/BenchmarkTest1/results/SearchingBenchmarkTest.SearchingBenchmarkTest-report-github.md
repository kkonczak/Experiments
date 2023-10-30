```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 8.1 (6.3.9600.0)
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency: 2435873 Hz, Resolution: 410.5304 ns, Timer: TSC
.NET SDK 7.0.103
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
  Job-FDPKPL : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX

MaxIterationCount=200  MinIterationCount=100  

```
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
