class Program
{
    public static void Main()// Se for menor de idade OU tiver comportamento suspeito, exiba "Monitorar".
    {
        Console.WriteLine("sua nota");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("sua frequencia");
        int num2 = Convert.ToInt32(Console.ReadLine());


        bool resultado = num >= 6 && num >= 75;

        if (resultado)
        {
            Console.WriteLine("Aprovado");
        }

        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
