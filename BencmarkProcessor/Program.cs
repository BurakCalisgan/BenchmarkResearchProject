// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Running;
using BencmarkProcessor.Benchmark;

BenchmarkRunner.Run<BenchmarkHarness>();

Console.WriteLine("------------------------------------");
Console.WriteLine("Hello, World!");

Console.ReadKey();
