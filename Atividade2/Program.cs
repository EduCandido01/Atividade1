class Program
{
    public static void Main()
    {
        Console.WriteLine("escreva o número");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escreva o número");
        string verdade = Console.ReadLine();

        bool resultado = num >= 18 && verdade == "sim";

        if (resultado)
        {
            Console.WriteLine("pode dirigir");
        }
    }
}
