class Program
{
    public static void Main()
    {
        Console.WriteLine("você é cliente VIP? sim ou não?");
        string escre = Console.ReadLine();

        Console.WriteLine("Número de compras");
        int num = Convert.ToInt32(Console.ReadLine());


        bool resultado = escre == "não" && num < 10;

        if (!resultado)
        {
            Console.WriteLine("Ganha desconto especial");
        }

    }
}