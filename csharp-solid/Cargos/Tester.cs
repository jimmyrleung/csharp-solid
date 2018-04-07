using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_solid.Calculos;

namespace csharp_solid
{
    public class Tester : Cargo
    {
        public Tester(IRegraCalculo regra) : base(regra)
        {
        }
    }
}
