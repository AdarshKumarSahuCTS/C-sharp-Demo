using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        for (int i=0; i<5; i++)
        {
            arr[i]=int.TryParse(Console.ReadLine(), out arr[i]);
        }
        int max= arr[0];
        foreach (int n in arr)
        {
            if(n>max) max = n;
        }
        Console.WriteLine($"Max: {max}");
    }
}