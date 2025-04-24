class Program
{
    public static void Main()
    {
        Console.WriteLine("ja tem cadastro: sim ou não?");
        string num = Console.ReadLine();

        Console.WriteLine("o cupom é valido: sim ou não?");
        string num2 = Console.ReadLine();

        Console.WriteLine("o cupom ja foi usado: sim ou não?");
        string num3 = Console.ReadLine();

        bool resultado = num == "sim" && num2 == "sim" && num3 == "sim";

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