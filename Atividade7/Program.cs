class Program
{
    public static void Main()
    {
        Console.WriteLine("ja tem cadastro: sim ou não?");
        string cadastro = Console.ReadLine();

        Console.WriteLine("o cupom é valido: sim ou não?");
        string cupom = Console.ReadLine();

        Console.WriteLine("o cupom ja foi usado: sim ou não?");
        string cupom2 = Console.ReadLine();

        bool resultado = cadastro == "sim" && cupom == "sim" && cupom2 == "sim";

        if (resultado)
        {
            Console.WriteLine("A promoção é válida");
        }

        else
        {
            Console.WriteLine("A promoção não é válida");
        }
    }
}