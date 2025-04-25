class Program
{
    public static void Main()
    {
        Console.WriteLine("escreva sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escreva sua renda");
        int renda = Convert.ToInt32(Console.ReadLine());


        bool resultado = idade > 65 || renda < 2000;

        if (resultado)
        {
            Console.WriteLine("você esta insento");
        }
    }
}