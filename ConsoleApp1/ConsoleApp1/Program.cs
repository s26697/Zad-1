class Program()
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static void AvgCalc(int[] tab)
    {
        int flex = 0;
        foreach (int e in tab)
        {
            flex += e;
        }
        Console.WriteLine("Średnią w tablicy jest liczba: " + flex/tab.Length);
        
    }
    
}

