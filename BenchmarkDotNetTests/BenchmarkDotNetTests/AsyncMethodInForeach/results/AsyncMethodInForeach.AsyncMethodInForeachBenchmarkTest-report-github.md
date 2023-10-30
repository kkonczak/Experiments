```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 8.1 (6.3.9600.0)
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency: 2435873 Hz, Resolution: 410.5304 ns, Timer: TSC
.NET SDK 7.0.103
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX [AttachedDebugger]
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX


```
| Method          | Mean      | Error    | StdDev    | Code Size | Gen0     | Allocated |
|---------------- |----------:|---------:|----------:|----------:|---------:|----------:|
| ForeachSumAsync | 419.48 μs | 8.354 μs | 10.565 μs |     447 B | 458.9844 |  720040 B |
| ForeachSum      |  66.16 μs | 1.285 μs |  1.529 μs |     227 B |        - |      40 B |
