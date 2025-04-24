class Program
{
    public static void Main()// Está isento se a idade for maior que 65 OU a renda for menor que 2000.
    {
        Console.WriteLine("escreva o número");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escreva o número");
        int num2 = Convert.ToInt32(Console.ReadLine());


        bool resultado = num > 65 || num2 < 2000;

        if (resultado)
        {
            Console.WriteLine("você esta insento");
        }
    }
}