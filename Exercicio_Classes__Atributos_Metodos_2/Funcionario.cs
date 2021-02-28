using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Classes__Atributos_Metodos_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            
            return (SalarioBruto-Imposto);
        }

        public void AumentarSalario(double porcentagem)
        {
            double percentual = porcentagem/100.0;
            double p = SalarioBruto * percentual;
            SalarioBruto += p;
            SalarioBruto -= Imposto;

        }
    }
}
