using System;

namespace ifelsemeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;

            Console.WriteLine("Por favor digite o valor corresponde ao mês desejado:");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine("O mês é Janeiro, Janeiro tem 31 dias");
            }

            if (mes == 2)
            {
                Console.WriteLine("O mês é Fevereiro, Fevereiro tem 28 dias em anos regulares e 29 dias em anos bissextos.");
                

            }

            if (mes == 3)
            {
                Console.WriteLine("O mês é Março, Março tem 31 dias");

            }

            if (mes == 4)
            {
                Console.WriteLine("O mês é Abril, Abril tem 30 dias");

            }

            if (mes == 5)
            {
                Console.WriteLine("O mês é Maio, Maio tem 31 dias");

            }

            if (mes == 6)
            {
                Console.WriteLine("O mês é Junho, Junho tem 30 dias");

            }

            if (mes == 7)
            {
                Console.WriteLine("O mês é Julho, Julho tem 31 dias");

            }

            if (mes == 8)
            {
                Console.WriteLine("O mês é Agosto, Agosto tem 31 dias");

            }

            if (mes == 9)
            {
                Console.WriteLine("O mês é Setembro, Setembro tem 30 dias");

            }

            if (mes == 10)
            {
                Console.WriteLine("O mês é Outubro, Outubro tem 31 dias");

            }

            if (mes == 11)
            {
                Console.WriteLine("O mês é Novembro, Novembro tem 30 dias");

            }

            if (mes == 12)
            {
                Console.WriteLine("O mês é Dezembro, Dezembro tem 31 dias");

            }
                Console.WriteLine("Obrigada por executar o programa! :) ");

        }
    }
}
