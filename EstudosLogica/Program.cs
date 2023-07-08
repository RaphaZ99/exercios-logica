using EstudosLogica.Exercicios;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Este programa irá mostrar 10 resoluções de lógica diárias.");
        Console.WriteLine("Escolha o dia");
        Console.WriteLine("1 - Dia 1");
        Console.WriteLine("2 - Dia 2");
        Console.WriteLine("3 - Dia 3");
        Console.WriteLine("4 - Dia 4");


        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":

                ExercicioDia1(); break;
            case "2":
                ExercicioDia2(); break;
            case "3":
                ExercicioDia3(); break;
            case "4":
                ExercicioDia4(); break;
            default:

                Console.WriteLine("Nenhum dia escolhido");
                break;

        }


    }
    public static void ExercicioDia1()
    {
        var dia1 = new ExercicioDia1();

        dia1.NumerosUmADez();

        Console.WriteLine("\nIrá calcular a média de 3 números");

        Console.WriteLine("\nInforme o Primeiro número :");
        var numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInforme o Segundo número :");
        var numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInforme o Terceiro número :");
        var numero3 = Convert.ToInt32(Console.ReadLine());

        dia1.MediaTresNumeros(numero1, numero2, numero3);

        Console.WriteLine("\nInforme um número para verificar se ele é par ou impar :");
        var numeroImparOuPar = Convert.ToInt32(Console.ReadLine());
        dia1.IsParOuImpar(numeroImparOuPar);

        Console.WriteLine("\nInforme um número para ser feito a tabuada do mesmo :");
        var numeroTabuada = Convert.ToInt32(Console.ReadLine());
        dia1.TabuadaNumero(numeroTabuada);

        Console.WriteLine("\nInforme um número para verificar se o mesmo é primo");
        var numeroPrimo = Convert.ToInt32(Console.ReadLine());
        dia1.IsPrimo(numeroPrimo);
    }
    public static void ExercicioDia2()
    {

        var dia2 = new ExercicioDia2();

        Console.WriteLine("\nEscreva numeros separado por espaços para ser invertido");
        var input = Console.ReadLine();

        int[] arrayNumbers = input.Split(" ").Select(int.Parse).ToArray();

        foreach (var number in arrayNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nInvertendo");

        dia2.InverterNumerosArray(arrayNumbers);



        Console.WriteLine("\nEscreva numeros separado por espaços para serem somados");
        input = Console.ReadLine();

        arrayNumbers = input.Split(" ").Select(int.Parse).ToArray();

        foreach (var number in arrayNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nSomando\n");

        dia2.SomaItensArray(arrayNumbers);

        Console.WriteLine("\nEscreva uma palavra para verificar se é um palidromo");
        input = Console.ReadLine();

        Console.WriteLine("\nFazendo checagem...\n");
        dia2.IsPalidromo(input);

        Console.WriteLine("\nDigite uma palavra para verificar se ele é um pangrama (Se possui todas as letras do alfabeto)");
        input = Console.ReadLine();

        dia2.IsPangrama(input);

        Console.WriteLine("\nDigite numeros para serem ordenados separado por espaços)");
        input = Console.ReadLine();

        dia2.OrdernaArray(input);

    }

    public static void ExercicioDia3()
    {
        var dia3 = new ExercicioDia3();

        Console.WriteLine("\nO programa a seguir irá somar todos os números pares de 1 a 100\n");
        dia3.SomaNumerosPares();

        Console.WriteLine("\nO programa a seguir irá verificar se a palavra é um anagrama\n");
        Console.WriteLine("\nDigite a primeira palavra a qual será verificado.\n");
        var palavra1 = Console.ReadLine();
        Console.WriteLine("\nDigite a segunda palavra para verificar se é um anagrama da primeira palavra\n");
        var palavra2 = Console.ReadLine();
        dia3.IsAnagramaOutraPalavra(palavra1, palavra2);

        Console.WriteLine("Informe uma data para ser convertido em dd/mm/aaa");
        var data = Console.ReadLine();

        CultureInfo cultureInfo = new CultureInfo("pt-br");
        cultureInfo.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
        dia3.ConverteData(Convert.ToDateTime(data.ToString(cultureInfo), cultureInfo), cultureInfo);

        Console.WriteLine("\n Informe numeros inteiros separados por espaço a qual será verificado qual será o maior");
        var arrayInteiros = Console.ReadLine();
        dia3.EncontraMaiorInteiro(arrayInteiros);

        Console.WriteLine("\n Digite uma palavra para ser verificado quantas vogais existe nela");
        var palavra = Console.ReadLine();
        dia3.ContadorVogais(palavra);

    }
    public static void ExercicioDia4()
    {

        var dia4 = new ExercicioDia4();

        Console.WriteLine("\nDigite um número para verificar se é um número de armstrong");
        Console.WriteLine("\nNumero perfeito é quando a soma dos seus divisores (exceto ele mesmo) é igual a ele");
        var input = Console.ReadLine();

        dia4.CalculoNumerArmstrong(input);

        Console.WriteLine("\nDigite um número para verificar se ele é um número perfeito.");
        input = Console.ReadLine();

        dia4.IsNumeroPerfeito(input);

        Console.WriteLine("\nDigite um ano para verificar se ele é bissexto.");
        input = Console.ReadLine();

        dia4.IsAnoBissexto(Convert.ToInt32(input));

        Console.WriteLine("\nDigite uma palavra para ser ordenada em ordem alfabética.");
        input = Console.ReadLine();

        dia4.OrderPlavaraOrdemAlfabetica(input);

    }

}