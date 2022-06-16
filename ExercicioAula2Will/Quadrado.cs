using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2Will
{
    internal class Quadrado : Forma
    {
        public override void CalcularDimensao()
        {
            Console.WriteLine("Digite a medida de um dos lados: ");
            var baseQuadrado = Convert.ToDouble(Console.ReadLine());

            var calculoQuadrado = baseQuadrado * baseQuadrado;
            Console.WriteLine($"A dimensão do seu quadrado é: {calculoQuadrado}");
        }
    }
}
