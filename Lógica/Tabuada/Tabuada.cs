
class Tabuada
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {num}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = num * i;
            Console.WriteLine($"{num} x {i} = {resultado}");
        }
    }
    }