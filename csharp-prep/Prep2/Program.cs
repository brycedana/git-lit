using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input your grade percentage: ");
        string Input = Console.ReadLine();
        int percentage = int.Parse(Input);

    //if-else if and else statements in regards to user input
        if ((percentage >= 90|| percentage >= 80))
        {
            Console.WriteLine("You passed with flying colors!");
        }
        else if((percentage >= 70))
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Oof! Better luck next time! Keep working hard!");
        }
    }
}