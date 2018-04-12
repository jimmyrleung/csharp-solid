using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var boletos = new List<Boleto>()
            {
                new Boleto(100), new Boleto(200), new Boleto(400)
            };

            var fatura = new Fatura("Cliente XYZ", 700);

            var processador = new ProcessadorDeBoletos();
            processador.Processa(boletos, fatura);
            Console.WriteLine(String.Format("Cliente: {0} - Pago: {1}", fatura.Cliente, fatura.Pago));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
