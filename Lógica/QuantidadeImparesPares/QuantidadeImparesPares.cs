class QuantidadeImparesPares
{
    static void Main(string[] args)
    {

        Console.WriteLine("Say the first number");
        int FirstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("say the last number");
        int LastNum = int.Parse(Console.ReadLine());

        int Par = 0;
        int impar = 0;

        Console.WriteLine("\nNumero impar");
        for (int i = FirstNum; i <= LastNum; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                impar++;
            }
        }
        Console.WriteLine("\nNúmeros pares");
        for (int i = FirstNum; i <= LastNum; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                Par++;
            }
        }

        Console.WriteLine($"Quantidade de números impares: {impar}");
        Console.WriteLine($"Quantidades de números pares: {Par}");

    }
}