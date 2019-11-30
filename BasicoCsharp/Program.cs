using System;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int annioActual = Convert.ToInt32("2019");
            double numPI = 3.141592;
            Console.WriteLine("Valores {0} -- {1}", annioActual, numPI);
            decimal montoFact = 94593.34m + 0.07m;
            float impVenta = 9239.04f;
            Console.WriteLine("Valores {0} -- {1}",montoFact,impVenta);
            double resultadoSum = 540 + -18.5;
            float resultadoResta = 3464.55f + 334.34f;
            decimal resultadoMult = 23.545m * 4243m;
            decimal resultdoDiv = 239.42m / 0.3m;
            decimal resultadoResiduo = 2321.432m % 23m;
            double resultadoPoetencia = Math.Pow(78, 2);
            double resultadoRaiz = Math.Sqrt(144);
            Console.WriteLine("Valores {0}--{1}-{2}-{3}-{4}-{5}-{6}", resultadoSum,resultadoResta, resultadoMult, resultdoDiv, resultadoResiduo, resultadoPoetencia, resultadoRaiz);
            int primerNumero = 48;
            int segundoNumero = 12;
            primerNumero += segundoNumero;
            primerNumero -= segundoNumero;
            primerNumero *= segundoNumero;
            primerNumero /= segundoNumero;
            primerNumero %= segundoNumero;
            primerNumero++;
            primerNumero--;
            Console.WriteLine("Aqui puede ir cualquiera de los de arriba:" + primerNumero);
            bool compY = true && true;
            var compO = true || false;
            bool compaEquals = compY == compO;
            bool valorNegado = !compaEquals;
            String[] nombres = new string[10];
            nombres[4] = "Jeremy";
            String[] diasDeLaSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            Console.WriteLine("La semana tiene {0} dias", diasDeLaSemana.Length);
            int[] numerosPrimos = { 1, 2, 3, 5, 7, 11 };
            bool[] celdasMarcadas = new bool[16];
            
        }
    }
}
