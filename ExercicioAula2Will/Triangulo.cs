﻿namespace ExercicioAula2Will
{
    internal class Triangulo : Forma
    {
        public override void CalcularDimensao()
        {
            Console.WriteLine("Digite a medida da base: ");
            var baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a medida da altura: ");
            var alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            var calculoTriangulo = baseTriangulo * alturaTriangulo / 2;

            Console.WriteLine("A dimensão do seu triangulo é: ");
            Console.WriteLine(calculoTriangulo);
        }
    }
}
