using EstudosLogica.Exercicios;
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Este programa irá mostrar 10 resoluções de lógica diárias.");
        Console.WriteLine("Escolha o dia");
        Console.WriteLine("1 - Dia 1");



        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":

                var dia1 = new ExercicioDia1();

                dia1.NumerosUmADez();

                Console.WriteLine("Irá calcular a média de 3 números");

                Console.WriteLine("Informe o Primeiro número :");
                var numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o Segundo número :");
                var numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o Terceiro número :");
                var numero3 = Convert.ToInt32(Console.ReadLine());

                dia1.MediaTresNumeros(numero1, numero2, numero3);

                Console.WriteLine("Informe um número para verificar se ele é par ou impar :");
                var numeroImparOuPar = Convert.ToInt32(Console.ReadLine());
                dia1.IsParOuImpar(numeroImparOuPar);

                Console.WriteLine("Informe um número para ser feito a tabuada do mesmo :");
                var numeroTabuada = Convert.ToInt32(Console.ReadLine());
                dia1.TabuadaNumero(numeroTabuada);

                Console.WriteLine("Informe um número para verificar se o mesmo é primo");
                var numeroPrimo = Convert.ToInt32(Console.ReadLine());
                dia1.IsPrimo(numeroPrimo);
                break;
            default:
                break;
                Console.WriteLine("Nenhum dia escolhido");
                break;

        }

    }

}