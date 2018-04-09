using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_o
{
    class GeradorNF
    {
        private EnviadorEmail email;
        private NFDAO dao;

        public GeradorNF(EnviadorEmail email, NFDAO dao)
        {
            this.email = email;
            this.dao = dao;
        }

        public NF Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NF nf = new NF(valor, ImpostoSimplesSobreO(valor));

            email.Enviar(nf);
            dao.Persistir(nf);

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
