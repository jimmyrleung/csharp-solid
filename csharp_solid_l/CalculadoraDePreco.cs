using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_l
{
    class CalculadoraDePreco
    {
        private ITabelaPreco tabelaPreco;
        private IServicoEntrega servicoEntrega;

        public CalculadoraDePreco(ITabelaPreco tabelaPreco, IServicoEntrega servicoEntrega)
        {
            this.tabelaPreco = tabelaPreco;
            this.servicoEntrega = servicoEntrega;
        }

        public double Calcula(Compra produto)
        {
            double desconto = this.tabelaPreco.CalculaDesconto(produto.Valor);
            double frete = this.servicoEntrega.CalculaFrete(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
