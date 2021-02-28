using System;
using System.Globalization;
namespace Exercicio_Classes__Atributos_Metodos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome : ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto : ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto : ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Funcionário : "+funcionario.Nome+", $ "+funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário : ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);
           
            Console.Write("Dados Atualizados : "+funcionario.Nome+", $ "+funcionario.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}
