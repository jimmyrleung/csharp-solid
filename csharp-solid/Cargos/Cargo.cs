using csharp_solid.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid
{
    public abstract class Cargo
    {
        public IRegraCalculo Regra;

        // Mesmo que uma classe seja abstrata (ou seja, não pode ser instanciada)
        // ela pode ter um construtor. As classes filhas devem passar o parametro
        // por base.
        public Cargo(IRegraCalculo regra)
        {
            this.Regra = regra;
        }
    }
}
