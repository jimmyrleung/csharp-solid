using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_o
{
    class NF
    {
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public double ValorLiquido
        {
            get
            {
                return this.ValorBruto - this.Impostos;
            }

        }

        public NF(double valorBruto, double impostos)
        {
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
        }
    }
}
