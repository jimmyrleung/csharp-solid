﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid.Calculos
{
    public class DezOuVintePorcento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }
    }
}
