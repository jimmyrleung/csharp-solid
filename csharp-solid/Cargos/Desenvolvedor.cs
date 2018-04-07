using csharp_solid.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraCalculo regra) : base(regra) // Equivale ao super() do Java
        {

        }
    }
}
