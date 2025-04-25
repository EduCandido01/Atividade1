class Program
{
    public static void Main()
    {

        Console.WriteLine("escreva seu cargo");
        string verdade = Console.ReadLine();

        bool resultado = verdade == "admin" || verdade == "supervisor";

        if (resultado)
        {
            Console.WriteLine("Acesso concedido");
        }
    }
}