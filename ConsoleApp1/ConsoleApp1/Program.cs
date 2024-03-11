﻿class Program()
{
    public static void Main(string[] args)
    {
        int[] tab = { 1, 2, 3, 4, 5 };
       AvgCalc(tab); 
        
       MaxCalc(tab);


    }

    public static void AvgCalc(int[] tab)
    {
        int y = 0;
        foreach (int e in tab)
        {
            y += e;
        }
        Console.WriteLine("Średnią w tablicy jest liczba: " + y/tab.Length);
        
    }
   
    public static void MaxCalc(int[] tab)
    {
        int flex = 0;
        
        foreach (int e in tab)
        {
            if (e > flex)
            {
                flex = e;
            }
            
        }
        
        Console.WriteLine("Największa liczbą w tablicy jest: " + flex);
    }
}

