using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_o
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatura f = new Fatura(150.00, "Jimmy Rios Leung");
            IList<IAcaoAposGerarNF> acoes = new List<IAcaoAposGerarNF>();
            acoes.Add(new EnviadorEmail());
            acoes.Add(new NFDAO());
            GeradorNF geradorNF = new GeradorNF(acoes);
            var nf = geradorNF.Gera(f);
            Console.WriteLine("NF gerada com sucesso.");
            Console.WriteLine(String.Format("Valor Bruto: {0}", nf.ValorBruto));
            Console.WriteLine(String.Format("Valor Líquido: {0}", nf.ValorLiquido));
            Console.WriteLine(String.Format("Impostos: {0}", nf.Impostos));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
