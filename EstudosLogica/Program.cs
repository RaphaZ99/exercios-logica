using EstudosLogica.Exercicios;
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Este programa irá mostrar 10 resoluções de lógica diárias.");
        Console.WriteLine("Escolha o dia");
        Console.WriteLine("1 - Dia 1");
        Console.WriteLine("2 - Dia 2");


        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":

                ExercicioDia1(); break;
            case "2":
                ExercicioDia2(); break;
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
        input= Console.ReadLine();

        dia2.IsPangrama(input);

        Console.WriteLine("\nDigite numeros para serem ordenados separado por espaços)");
        input = Console.ReadLine();

        dia2.OrdernaArray(input);

    }

}