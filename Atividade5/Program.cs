class Program
{
    public static void Main()
    {
        Console.WriteLine("você é cliente VIP? sim ou não?");
        string num = Console.ReadLine();

        Console.WriteLine("Número de compra");
        int num2 = Convert.ToInt32(Console.ReadLine());


        bool resultado = num == "não" && num2 < 10;

        if (!resultado)
        {
            Console.WriteLine("Ganha desconto especial");
        }

    }
}