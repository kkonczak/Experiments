```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 8.1 (6.3.9600.0)
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency: 2435873 Hz, Resolution: 410.5304 ns, Timer: TSC
.NET SDK 7.0.103
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX


```
| Method                       | Mean       | Error     | StdDev    | Median     | Code Size | Gen0   | Allocated |
|----------------------------- |-----------:|----------:|----------:|-----------:|----------:|-------:|----------:|
| ReturnFromAsyncAwaitedMethod | 71.0543 ns | 1.4519 ns | 1.4910 ns | 70.4923 ns |     446 B | 0.0918 |     144 B |
| ReturnFromAsyncMethod        | 33.9784 ns | 0.7079 ns | 1.0810 ns | 33.4904 ns |     163 B | 0.0459 |      72 B |
| ReturnFromNormalMethod       |  0.0278 ns | 0.0369 ns | 0.0346 ns |  0.0141 ns |       6 B |      - |         - |
