class ImparParIncialFinal
{

    static void Main(string[] args)
    {

        Console.WriteLine("Digite um número inicial");
        int numInicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um número final");
        int numFinal = int.Parse(Console.ReadLine());

        for (int i = numFinal; i >= numInicial; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"O número {i} é par");
            }
            else
            {
                Console.WriteLine($"O número {i} é impar");
            }
        }
    }
}