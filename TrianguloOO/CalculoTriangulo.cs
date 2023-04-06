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
            else if (x != y && y != z && x != z)
            {
                return triangulo = "Triangulo Escaleno";
            }
            else if (x != y && x != z && y == z || x != y && y != z && x == z || x == y && x != z && y != z)
            {
                return triangulo = "Triangulo Isoceles";
            }
            else
            {
                return triangulo = "Triangulo Inválido";
            }
        }
    }
}
