using System;
using System.Threading.Tasks;

namespace PostBenchmarkDotNet
{
    public class OperacionesMatematicas
    {
        public double Suma(double a, double b)
        {
            return a + b;
        }

        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        public double Potencia(double @base, double exponente)
        {
            return Math.Pow(@base, exponente);
        }

        public double Potencia2(double @base, double exponente)
        {
            if (exponente == 0)
                return 1;

            var resultado = @base;
            for(int i = 1; i < exponente; i++)
            {
                resultado = resultado * @base;
            }
            return resultado;
        }
    }
}
