using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_4
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private IList<Pagamento> Pagamentos;
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionarPagamento(Pagamento p)
        {
            this.Pagamentos.Add(p);
            
            // Ao adicionarmos um novo pagamento verificamos se seu status deve ser mudado.
            // Encapsulamos essa RN pois quem chama AdicionarPagamento não tem noção disso
            if (valorTotalPagamentos() >= this.Valor) this.Pago = true;
        }

        private double valorTotalPagamentos()
        {
            double total = 0;

            foreach(var p in Pagamentos)
            {
                total += p.Valor;
            }

            return total;
        }
    }
}
