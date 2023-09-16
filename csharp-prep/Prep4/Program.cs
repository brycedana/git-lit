using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new <int>();

        int input = -1; 
        while (input != 0)
        {
            Console.Write("Enter any number (0 to end)");

            string output = Console.ReadLine();
            input = int.Parse(output);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0; 
        foreach (int number in numbers)
        {
            sum += number; 
        }
        Console.WriteLine($"The sum is: {sum}");

        int max = numbers [0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                 max = number; 
            }
           
        }
        Console.WriteLine($"The max is: {max}");
    }
}