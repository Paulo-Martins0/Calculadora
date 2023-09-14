using System;

namespace Calculadora.Entities
{
    internal class Potencia
    {

        public Potencia() { }

        

        public void Potenciacao (double N1, double N2)
        {

            Console.WriteLine(Math.Pow(N1,N2));
        }
    }
}
