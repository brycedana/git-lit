using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();

        return input;
    }
    static int PromptUserNumber()
    {
        Console.Write("Input a number here: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int number)
    {
        int square = number * number; 

        return square; 
    }
    static void DisplayResult(string input, int square)
    {
        Console.WriteLine($"{input}, the square is {square}");
    }
}