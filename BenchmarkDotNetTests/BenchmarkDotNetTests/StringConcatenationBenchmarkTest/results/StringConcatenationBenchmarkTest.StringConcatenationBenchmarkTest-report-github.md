```

BenchmarkDotNet v0.13.10, Windows 8.1 (6.3.9600.0)
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency: 2435873 Hz, Resolution: 410.5304 ns, Timer: TSC
.NET SDK 7.0.103
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX


```
| Method                               | Mean     | Error     | StdDev    | Median   | Gen0    | Code Size | Allocated |
|------------------------------------- |---------:|----------:|----------:|---------:|--------:|----------:|----------:|
| PlusStringConcatenationTest          | 4.908 μs | 0.0853 μs | 0.1079 μs | 4.902 μs | 19.5084 |     360 B |  29.91 KB |
| StringBuilderStringConcatenationTest | 2.330 μs | 0.0463 μs | 0.1290 μs | 2.279 μs |  7.7896 |     469 B |  11.95 KB |
