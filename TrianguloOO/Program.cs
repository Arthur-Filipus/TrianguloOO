namespace TrianguloOO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CalculoTriangulo teste = new CalculoTriangulo();





            Console.Write("Digite o valor de X: ");

            teste.x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o valor de Y: ");

            teste.y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de Z: ");

            teste.z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(teste.CalcularTriangulos());

            Console.ReadLine();
        }
    }
}