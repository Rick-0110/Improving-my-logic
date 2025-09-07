class ParOuImpar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para ver-mos se é impar ou par");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Numero par");
        }
        else
        {
            Console.WriteLine("Numero impar");
        }
    }
}
