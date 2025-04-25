class Program
{
    public static void Main()
    {
        Console.WriteLine("escreva a sua idade");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Você tem carteira: sim ou não?");
        string verdade = Console.ReadLine();

        bool resultado = num >= 18 && verdade == "sim";

        if (resultado)
        {
            Console.WriteLine("pode dirigir");
        }
    }
}
