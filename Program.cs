class Program
{
    public static void Main()
    {
        Console.WriteLine("escreva o número");
        int num = Convert.ToInt32 (Console.ReadLine());

        bool resultado = num < 10 && num > 20;

        if (resultado)
        {
            Console.WriteLine("fora do intervalo");
        }

        else
        {
            Console.WriteLine("dentro do intervalo");
        }
    }
}

