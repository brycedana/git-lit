using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string nombre = Console.ReadLine();
    //Spanish because why not?
        Console.WriteLine("What is your last name? ");
        string apellido = Console.ReadLine();

        Console.WriteLine($"Welcome to C# {nombre} {apellido}.");
    }
}