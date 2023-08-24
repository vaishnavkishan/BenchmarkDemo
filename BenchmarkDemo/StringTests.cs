using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo;

//[SimpleJob()]
[IterationsColumn, MaxColumn, MinColumn, MeanColumn, RankColumn]
[MemoryDiagnoser]
[IterationCount(10)]
[WarmupCount(5)]
[HtmlExporter]
public class StringTests
{
    StringVsStringBuilder _test;

    [GlobalSetup]
    public void Setup()
    {
        _test = new StringVsStringBuilder();
    }

    [Benchmark]
    public void StringBenchmark()
    {
        _test.StringDemo();
    }

    [Benchmark]
    public void StringBuilderBenchmark()
    {
        _test.StringBuilderDemo();
    }
}
