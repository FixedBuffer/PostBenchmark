using BenchmarkDotNet.Attributes;
using PostBenchmarkDotNet;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkRunnerProject
{
    [RankColumn]
    public class OperacionesMatematicasBenchmark
    {
        [Params(2, 3)]
        public int A { get; set; }

        [Params(2, 200)]
        public int B { get; set; }

        [Benchmark]
        public void Suma()
        {
            var operaciones = new OperacionesMatematicas();
            operaciones.Suma(A, B);
        }

        [Benchmark]
        public void Multiplicacion()
        {
            var operaciones = new OperacionesMatematicas();
            operaciones.Multiplicacion(A, B);
        }

        [Benchmark]
        public void Potencia()
        {
            var operaciones = new OperacionesMatematicas();
            operaciones.Potencia(A, B);
        }

        [Benchmark]
        public void Potencia2()
        {
            var operaciones = new OperacionesMatematicas();
            operaciones.Potencia2(A, B);
        }
    }
}

