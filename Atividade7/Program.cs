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

        bool resultado = cadastro == "sim" && cupom == "sim" && cupom2 == "não";

        if (resultado)
        {
            Console.WriteLine("A promoção é válida");
        }

        else
        {
            if (cadastro == "não")
            {
                Console.WriteLine("Erro encontrado. Se cadastro");
            }
            if (cupom == "não")
            {
                Console.WriteLine("Erro encontrado. Sem cupom");
            }
            if (cupom2 == "sim")
            {
                Console.WriteLine("Erro encontrado. Cupom invalido");
            }
        }
    }
}