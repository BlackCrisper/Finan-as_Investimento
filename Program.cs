using System;
namespace FirstCode
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Calcular Juros");

                double montante ,capital ,meses, anos , juros;

                Console.WriteLine("Digite o capital");
                capital = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Digite os meses");
                meses = Convert.ToDouble(Console.ReadLine());

                anos = (meses/12);

                montante = (capital * (Math.Pow(1 + 0.07, anos))); 

                juros = (montante - capital);

                Console.WriteLine("Seu Montante é: "+ montante);
                Console.WriteLine("Seu Juros é: "+ juros);

            }       
        }
}


