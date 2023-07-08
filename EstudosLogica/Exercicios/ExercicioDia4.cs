using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLogica.Exercicios
{
    public class ExercicioDia4
    {

        public void CalculoNumerArmstrong(string numero)
        {
            var numerosArray = numero.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            var somaNumerosArray = 0.0;

            for (var i = 0; i < numerosArray.Length; i++)
            {
                somaNumerosArray += Math.Pow(numerosArray[i], numerosArray.Length);
            };

            if (somaNumerosArray.ToString() == numero)
            {
                Console.WriteLine($"{numero} é um número de Armstrong");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número de Armstrong");
            }
        }

        public void IsNumeroPerfeito(string numero)
        {
            var numeroConvertido = Convert.ToInt32(numero);
            var somaDivisores = 0;

            for (int i = 1; i <= numeroConvertido; i++)
            {
                if (numeroConvertido % i == 0)
                {
                    somaDivisores += i;
                }
            }

            if ((somaDivisores - numeroConvertido) == numeroConvertido)
            {
                Console.WriteLine($"{numeroConvertido} é um número perfeito.");
            }
            else
            {
                Console.WriteLine($"{numeroConvertido} não é um número perfeito");
            }
        }

        public void IsAnoBissexto(int ano)
        {
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0)
                {
                    Console.WriteLine($"Não é um ano bissexto");
                }
                else
                {
                    Console.WriteLine($"É um ano bissexto");
                }
            }
            else
            {
                if (ano % 400 == 0)
                {
                    Console.WriteLine("É um ano bissexto");
                }
                else
                {
                    Console.WriteLine($"Não é um ano bissexto");
                }
            }
        }

        public void OrderPlavaraOrdemAlfabetica(string palavraParaConverterOrdemAlfabetica)
        {
            var arrayPalavra = palavraParaConverterOrdemAlfabetica.ToCharArray();
            Array.Sort(arrayPalavra);

            Console.WriteLine($"Palavra em ordem alfabética array {String.Join("", arrayPalavra)}");

        }
    }
}

