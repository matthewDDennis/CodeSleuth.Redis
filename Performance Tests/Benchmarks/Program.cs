using BenchmarkDotNet.Running;

var baseline = new Benchmarks.BaseLine();
Console.WriteLine($"SetString: {baseline.SetString()}");

BenchmarkRunner.Run<Benchmarks.BaseLine>();