class Program
{
    public static void Main()
    {
        Console.WriteLine("horario atual");
        int num = Convert.ToInt32(Console.ReadLine());


        bool resultado = num >= 6 && num <= 22;

        if (resultado)
        {
            Console.WriteLine("dentro do horario");
        }

        else
        {
            Console.WriteLine("Fora do horário");
        }
    }
}