using ExercicioAula2Will;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangulo = new Triangulo();
            triangulo.CalcularDimensao();

            var circulo = new Circulo();
            circulo.CalcularDimensao();

            var quadrado = new Quadrado();
            quadrado.CalcularDimensao();
        }
    }
}
