```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 8.1 (6.3.9600.0)
Unknown processor
Frequency: 2435873 Hz, Resolution: 410.5304 ns, Timer: TSC
.NET SDK 7.0.103
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX


```
| Method          | Mean      | Error    | StdDev   | Median    | Code Size | Gen0     | Allocated |
|---------------- |----------:|---------:|---------:|----------:|----------:|---------:|----------:|
| ForeachSumAsync | 386.79 μs | 7.527 μs | 8.960 μs | 388.40 μs |     447 B | 458.9844 |  720040 B |
| ForeachSum      |  65.88 μs | 1.226 μs | 2.937 μs |  64.73 μs |     227 B |        - |      40 B |
