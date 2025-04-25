class Program
{
    public static void Main()
    {
        Console.WriteLine("tem ingreço: sim ou não?");
        string ingre = Console.ReadLine();

        Console.WriteLine("Documento válido: sim ou não?");
        string valid = Console.ReadLine();


        bool resultado = ingre == "sim" && valid == "sim";

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