using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_o
{
    class GeradorNF
    {
        // Guardamos somente uma referência a uma lista de ações
        private IList<IAcaoAposGerarNF> acoes;

        public GeradorNF(IList<IAcaoAposGerarNF> acoes)
        {
            this.acoes = acoes;
        }

        public NF Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NF nf = new NF(valor, ImpostoSimplesSobreO(valor));

            // Agora podemos ter 1, 2, 5, 10, 20 ações
            foreach (var acao in this.acoes)
            {
                acao.Executar(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
