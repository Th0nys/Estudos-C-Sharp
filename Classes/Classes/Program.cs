using Classes; // Importa o namespace "Classes", onde está definida a classe Triangulo.
using System; // Importa o namespace "System" para utilizar funcionalidades básicas.

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // Declara duas variáveis do tipo Triangulo chamadas x e y.
            x = new Triangulo(); // Cria uma instância da classe Triangulo e atribui à variável x.
            y = new Triangulo(); // Cria outra instância da classe Triangulo e atribui à variável y.

            // Solicita ao usuário que insira as medidas do triângulo X.
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            // Solicita ao usuário que insira as medidas do triângulo Y.
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            // Calcula a área dos triângulos x e y.
            double areaX = x.Area();
            double areaY = y.Area();

            // Exibe as áreas calculadas com três casas decimais.
            Console.WriteLine($"Area de x: {areaX.ToString("F3")}");
            Console.WriteLine($"Area de y: {areaY.ToString("F3")}");
        }
    }
}
