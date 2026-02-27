class TablaMultiplicacion
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("MULTIPLICACION");
        Console.WriteLine("Digite el numero de la tabla que desea consultar...");
        int numeroTabla = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"========== TABLA DEL {numeroTabla}: ===========");
        await Task.Delay(1000);
        for (int i = 1; i <= 10; i++)
        {
           
            Console.WriteLine($"{numeroTabla} * {i} : {numeroTabla * i}");
        }  Console.ReadKey();
    }
}
