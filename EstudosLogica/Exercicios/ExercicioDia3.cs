using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLogica.Exercicios
{
    public class ExercicioDia3
    {

        public void SomaNumerosPares()
        {
            var somaPares = 0;
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    somaPares += i;
                }

            }

            Console.WriteLine($"\nA soma dos pares de 1 a 100 é : {somaPares}");
        }

        public void IsAnagramaOutraPalavra(string palavra1, string palavra2)
        {
            palavra1 = palavra1.Replace(" ", "");
            palavra2 = palavra2.Replace(" ", "");


            if (palavra1.Length != palavra2.Length)
            {
                Console.WriteLine("\nNão é um anagrama");

            }
            else
            {
                var letras1 = palavra1.ToArray();
                var letras2 = palavra2.ToArray();

                Array.Sort(letras1);
                Array.Sort(letras2);

                if (Enumerable.SequenceEqual(letras1, letras2))
                {
                    Console.WriteLine("\nÉ um anagrama");

                }
                else
                {
                    Console.WriteLine("\nNão é um anagrama");
                }

            }

        }
        public void ConverteData(DateTime dataParaConverter, CultureInfo cultureInfo)
        {
            cultureInfo.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy";

            Console.WriteLine($"Data convertida em mm-dd-aaaa {dataParaConverter.ToString("d", cultureInfo)}");

        }

        public void EncontraMaiorInteiro(string arrayInteiroString)
        {
            int[] arrayInteiros = Array.ConvertAll(arrayInteiroString.Split(" "), int.Parse);
            var maiorNumeroArray = 0;

            foreach (int i in arrayInteiros)
            {
                if (i > maiorNumeroArray)
                {
                    maiorNumeroArray = i;
                }

            }
            Console.WriteLine($"Maior numero do array é : {maiorNumeroArray}");

        }

        public void ContadorVogais(string vogais)
        {
            char[] arrayLetras = vogais.ToCharArray();
            char[] arrayVogais = { 'a', 'e', 'i', 'o', 'u' };
            var somaVogais = 0;

            foreach (char c in arrayLetras)
            {
                foreach (char v in arrayVogais)
                {
                    if (c == v) somaVogais++;
                }
            }

            Console.WriteLine($"\nEssa palavra tem {somaVogais} vogais");
        }
    }
}
