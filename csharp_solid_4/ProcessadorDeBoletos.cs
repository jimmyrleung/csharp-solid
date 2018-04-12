using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_4
{
    public class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {
            foreach (Boleto boleto in boletos)
            {
                // Adicionamos um pagamento sem saber o que de fato acontece
                fatura.AdicionarPagamento(new Pagamento(boleto.Valor, Enumerators.MeioDePagamento.BOLETO));
            }
        }
    }
}
