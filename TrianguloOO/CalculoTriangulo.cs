using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOO
{
    internal class CalculoTriangulo
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public string triangulo { get; set; }
        public string CalcularTriangulos()
        {
            if (x == y && y == z && x == z)
            {
                return triangulo = "Triangulo Equilatero";
            }
            if (x != y && y != z && x != z)
            {
                return triangulo = "Triangulo Escaleno";
            }
            else
            {
                return triangulo = "Triangulo Isoceles";
            }
        }
    }
}
