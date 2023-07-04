using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EstudosLogica.Exercicios
{
    public class ExercicioDia2
    {

        public void InverterNumerosArray(int[] arrayNumeros)
        {
            int[] novoArray = new int[arrayNumeros.Length];

            for (int i = 1; i <= arrayNumeros.Length; i++)
            {

                novoArray[i - 1] = arrayNumeros[arrayNumeros.Length - i];

            }
            Console.WriteLine("Exibindo numeros invertidos");
            foreach (int i in novoArray)
            {
                Console.WriteLine(i);
            }
        }

        public void SomaItensArray(int[] arrayNumeros)
        {
            var soma = 0;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {

                soma += arrayNumeros[i];

            }

            Console.WriteLine($"Soma dos itens é : {soma}");
        }
        public void IsPalidromo(string stringParaInverter)
        {
            string palavraInvertida = string.Empty;

            for (int i = 1; i <= stringParaInverter.Length; i++)
            {

                palavraInvertida += stringParaInverter[stringParaInverter.Length - i];

            }

            if (palavraInvertida.ToString() == stringParaInverter)
            {
                Console.WriteLine($"{stringParaInverter} É um palidromo");
            }
            else
            {
                Console.WriteLine($"{stringParaInverter} Não é um palidromo");
            }
        }

        public void IsPangrama(string stringParaInverter)
        {
            var newStringParaInverter = stringParaInverter.Replace(" ", "");
            char[] stringParaInverterArray = newStringParaInverter.ToCharArray();
            char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] novoArrayCheck = new char[0];

            foreach (char c in stringParaInverterArray)
            {
                foreach (char c2 in alfabeto)
                {
                    if (c2 == c)
                    {
                        var charFoiEncontradoAntes = novoArrayCheck.Where(x => x == c).FirstOrDefault();

                        if (charFoiEncontradoAntes == 0)
                        {
                            Array.Resize(ref novoArrayCheck, novoArrayCheck.Length + 1);
                            novoArrayCheck[novoArrayCheck.Length - 1] = c;
                        }

                    }
                }

            }

            if (novoArrayCheck.Count() == 26)
            {
                Console.WriteLine($"{stringParaInverter} é um pangrama");
            }
            else
            {
                Console.WriteLine($"{stringParaInverter} Não é um pangrama");
            }
        }

        public void OrdernaArray(string numerosParaOrdenar)
        {
            var arrayParaOrdenar = numerosParaOrdenar.Split(" ");
            Array.Sort(arrayParaOrdenar);

            foreach (var numero in arrayParaOrdenar)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
