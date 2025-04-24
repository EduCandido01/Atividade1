class Program
{
    public static void Main()
    {
        Console.WriteLine("tem ingreço: sim ou não?");
        string num = Console.ReadLine();

        Console.WriteLine("Documento válido: sim ou não?");
        string num2 = Console.ReadLine();


        bool resultado = num == "sim" && num2 == "sim";

        if (resultado)
        {
            Console.WriteLine("entrada liberada");
        }

        else
        {
            Console.WriteLine("entrada não liberada");
        }
    }
}