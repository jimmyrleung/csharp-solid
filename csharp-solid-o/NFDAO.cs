using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_o
{
    class NFDAO : IAcaoAposGerarNF
    {
        public void Executar(NF nf)
        {
            Console.WriteLine("Persistindo NF...");
        }
    }
}
