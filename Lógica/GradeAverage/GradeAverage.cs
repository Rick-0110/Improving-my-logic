class GradeAverage
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua nota na primeira unidade:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua nota na segunda unidade:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua nota na terceira unidade:");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;


        if (media >= 7)
        {
            Console.WriteLine($"Você foi aprovado com média {media}");
        }
        else
        {
            Console.WriteLine($"Você foi reprovado com média {media}");
        }

    }
}

