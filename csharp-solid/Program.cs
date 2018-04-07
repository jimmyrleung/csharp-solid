using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dev = new Funcionario(new Desenvolvedor(), 2000);
            Console.WriteLine(String.Format("Salário Bruto: {0}\nSalário Líquido: {1}", dev.SalarioBase, calculadora.calcula(dev)));
            System.Threading.Thread.Sleep(20000);
        }
    }
}
