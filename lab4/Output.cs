public static class Output
{
    public static void PrintResult(string result, long elapsedTime)
    {
        Console.WriteLine("\nРезультат:");
        Console.WriteLine(result);
        Console.WriteLine($"\nЧас виконання: {elapsedTime} мс");
    }
}
