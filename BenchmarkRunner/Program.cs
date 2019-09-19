using System;
using BenchmarkDotNet.Running;

namespace BenchmarkRunnerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<OperacionesMatematicasBenchmark>();
            Console.Read();
        }
    }
}