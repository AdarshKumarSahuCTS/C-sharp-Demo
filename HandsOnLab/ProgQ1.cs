using System;

class Program {
    static void Main() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:F2}");
    }
}
