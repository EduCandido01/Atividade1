class Program
{
    public static void Main()
    {
        Console.WriteLine("idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("comportamento suspeito");
        string comport = Console.ReadLine();


        bool resultado = idade < 18 && comport == "sim";

        if (resultado)
        {
            Console.WriteLine("Monitorar");
        }

        else
        {
            Console.WriteLine("Não monitorar");
        }
    }
}
