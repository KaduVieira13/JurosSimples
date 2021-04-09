using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal capital = 0; // valor
            decimal tempo = 0; //Parcelas
            decimal taxaDeJuros = 2; // Taxa de Juros
            decimal juros;
            decimal montante;

            Console.Write("Digite o valor a ser investido: ");
            capital = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor da taxa de juros: ");
            taxaDeJuros = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o numero de parcelas: ");
            tempo = Convert.ToDecimal(Console.ReadLine());
          
            juros = capital * (taxaDeJuros / 100) * tempo ;
            montante = capital + juros;
            Console.WriteLine($"O valor do juros é: {juros:C2}");
            Console.WriteLine($"O valor do montante é: {montante:C2}");
        }
    }
}
