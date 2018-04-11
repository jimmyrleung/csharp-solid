using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_l
{
    class CalculadoraDePreco
    {
        public double Calcula(Compra produto)
        {
            TabelaPrecoPadrao tabela = new TabelaPrecoPadrao();
            FreteCorreios correios = new FreteCorreios();

            double desconto = tabela.DescontoPara(produto.Valor);
            double frete = correios.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
