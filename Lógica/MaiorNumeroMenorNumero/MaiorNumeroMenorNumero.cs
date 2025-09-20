
class MaiorNumeroMenorNumero
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números você deseja digitar?: ");
        int N = int.Parse(Console.ReadLine());

        int[] numeros = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] < 0)
            {
                Console.WriteLine("Número inválido! Digite um número não negativo.");
                i--;
            }
        }

        int maior = numeros[0];
        for (int i = 1; i < N; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine($"O maior número digitado foi: {maior} ");

        int menor = numeros[0];

        for (int i = 1; i < N; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        Console.WriteLine($"O menor número digitado foi: {menor}");
    }
}