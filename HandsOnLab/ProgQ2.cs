using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num>0) Console.WriteLine("Positive");
        else if (num==0) Console.WriteLine("Zero");
        else Console.WriteLine("Negative");

    }
}
