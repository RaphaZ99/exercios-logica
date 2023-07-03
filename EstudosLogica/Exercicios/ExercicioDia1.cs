using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLogica.Exercicios
{
    public class ExercicioDia1
    {
        public void NumerosUmADez()
        {
            Console.WriteLine("Irá contar de 1 a 10");
            var numberCount = 0;

            while (numberCount <= 9)
            {
                numberCount++;
                Console.WriteLine($"Número {numberCount}");
            }

        }
        public void MediaTresNumeros(int numero1, int numero2, int numero3)
        {
            Console.WriteLine("Irá fazer o cálculo da média de 3 números");

            Type type = typeof(ExercicioDia1);

            MethodInfo methodInfo = type.GetMethod("MediaTresNumeros");

            var media = (numero1 + numero2 + numero3) / methodInfo.GetParameters().Length;

            Console.WriteLine($"A média é {media}");

        }

        public void IsParOuImpar(int numero)
        {
            Console.WriteLine("Irá verificar se o número é par ou impar");

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número é par {numero}");
            }
            else
            {
                Console.WriteLine($"O número é impar {numero}");
            }

        }

        public void TabuadaNumero(int numero)
        {
            Console.WriteLine("Irá fazer a tabuada de um número");
            var contagemTabuada = 1;

            while (contagemTabuada <= 10)
            {

                Console.WriteLine($" {numero} * {contagemTabuada} = {numero * contagemTabuada}");
                contagemTabuada++;

            }

        }

        public void IsPrimo(int numero)
        {
            bool isPrimo = true;
            var calculo = Math.Sqrt(numero);
            if (numero < 2)
            {

                isPrimo = false;

            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if(numero % i == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                }
            }

            if (isPrimo)
            {
                Console.WriteLine($"O número é primo {numero}");
            }
            else
            {
                Console.WriteLine($"O número não é primo {numero}");
            }

        }

    }
}
